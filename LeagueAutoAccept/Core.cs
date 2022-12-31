using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeagueAutoAccept
{
    internal class Core
    {
        public string port = "";
        public string password = "";
        public string summoerID = "";
        public string allChampion = "";

        public Core()
        {
            setInit();
        }


        public string getAllChampion()
        {
            if (allChampion == "")
            {
                allChampion = get($"/lol-champions/v1/inventories/{summoerID}/champions-minimal");
            }
            return allChampion;
        }

        public void selectChamp(string champID, bool complete)
        {
            string session = get("/lol-champ-select/v1/session");
            using JsonDocument sessionDoc = JsonDocument.Parse(session);
            JsonElement sessionJson = sessionDoc.RootElement;
            int selection = Int32.Parse(sessionJson.GetProperty("localPlayerCellId").ToString());
            request("PATCH", $"/lol-champ-select/v1/session/actions/{selection}", "{\"completed\":" + complete.ToString().ToLower() + ",\"championId\":" + champID + "}");
        }
        public void sendChat(string text)
        {
            string conversations = get("/lol-chat/v1/conversations");

            using JsonDocument dataDoc = JsonDocument.Parse(conversations);
            JsonElement dataJson = dataDoc.RootElement;

            for (int i = 0; i < dataJson.GetArrayLength(); i++)
            {
                var save = dataJson[i].GetProperty("type");
                if (save.ToString() == "championSelect")
                {
                    string id = dataJson[i].GetProperty("id").ToString();
                    string message = request("POST", $"/lol-chat/v1/conversations/{id}/messages", "{\"body\":\"" + text + "\"}");
                }
            }
        }

        public bool checkLobbyState()
        {
            string conversations = get("/lol-chat/v1/conversations");

            using JsonDocument dataDoc = JsonDocument.Parse(conversations);
            JsonElement dataJson = dataDoc.RootElement;

            for (int i = 0; i < dataJson.GetArrayLength(); i++)
            {
                var save = dataJson[i].GetProperty("type");
                if (save.ToString() == "championSelect")
                {
                    return true;
                }
            }
            return false;
        }

        public void setInit()
        {
            Process process = Process.GetProcessesByName("LeagueClient").FirstOrDefault();
            string query = "SELECT ExecutablePath, ProcessID FROM Win32_Process";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            if (process == null)
            {
                Debug.WriteLine("League not found");
                //Environment.Exit(1);
                return;
            }
            foreach (ManagementObject item in searcher.Get())
            {
                object id = item["ProcessID"];
                object path = item["ExecutablePath"];
                if (id.ToString() == process.Id.ToString())
                {
                    if (path == null)
                    {
                        Debug.WriteLine("ERROR RUN THIS APP AS ADMIN");
                    }
                    string pathDir = Path.GetDirectoryName(path.ToString());
                    FileStream stream = new FileStream(pathDir + "\\lockfile", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    string data = "";
                    int i = 0;
                    while ((i = stream.ReadByte()) != -1) { data += (char)i; }
                    string[] pass = data.Split(":");
                    //Debug.WriteLine($"Port : {pass[2]}, Password : {pass[3]}");
                    port = pass[2];
                    password = pass[3];

                    string currentSummner = get("/lol-summoner/v1/current-summoner");
                    using JsonDocument playerDoc = JsonDocument.Parse(currentSummner);
                    JsonElement playerJson = playerDoc.RootElement;
                    summoerID = playerJson.GetProperty("summonerId").ToString();

                    return;
                }
            }
        }

        public bool checkSearchState()
        {
            string state = get("/lol-lobby/v2/lobby/matchmaking/search-state");
            using JsonDocument stateDoc = JsonDocument.Parse(state);
            JsonElement stateJson = stateDoc.RootElement;
            if (stateJson.GetProperty("searchState").ToString() == "Found")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void acceptmatch()
        {
            try
            {
                string accept = request("POST", "/lol-matchmaking/v1/ready-check/accept", "{}");
            }catch { }
            
        }


        public string request(string method, string endpoint, string data)
        {
            string encoded = Convert.ToBase64String(Encoding.ASCII.GetBytes("riot:" + password));
            string url = $"https://127.0.0.1:{port}{endpoint}";

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            byte[] encodeData = Encoding.ASCII.GetBytes(data);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.Method = method;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(encodeData, 0, encodeData.Length);
            }
            string responseString = "";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch { }
            return responseString;
        }

        public string get(string endpoint)
        {
            string encoded = Convert.ToBase64String(Encoding.ASCII.GetBytes("riot:" + password));
            string url = $"https://127.0.0.1:{port}{endpoint}";

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.Method = "GET";
            string responseString = "";

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch { }
            return responseString;
        }

        public Bitmap getBitmap(string endpoint)
        {
            string encoded = Convert.ToBase64String(Encoding.ASCII.GetBytes("riot:" + password));
            string url = $"https://127.0.0.1:{port}{endpoint}";

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.Method = "GET";
            Bitmap bmpReturn = null;
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                
                //Convert Base64 string to byte[]
                byte[] byteBuffer = Convert.FromBase64String(responseString);
                MemoryStream memoryStream = new MemoryStream(byteBuffer);
                memoryStream.Position = 0;
                bmpReturn = (Bitmap)Bitmap.FromStream(memoryStream);
                memoryStream.Close();
                memoryStream = null;
                byteBuffer = null;
            }
            catch { }
            
            return bmpReturn;

        }
    }
}
