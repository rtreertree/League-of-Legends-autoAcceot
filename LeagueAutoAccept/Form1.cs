using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace LeagueAutoAccept
{
    public partial class Form1 : Form
    {
        public Thread taskThread;
        public bool isRunning = false;
        Core core = new Core();
        string champID = "";
        string champName = "";
        string laneSelect = "";
        string laneUrl = "";
        string currentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public Form1()
        {
            
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            core.setInit();
            if (core.port == "" || core.password == "")
            {
                MessageBox.Show("Can not acces League client", "ERROR_CONNECT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        public void StartMatchAccept()
        {
            while (isRunning)
            {
                if (core.checkSearchState())
                {
                    Thread.Sleep(1000);
                    core.acceptmatch();
                    break;
                }
                Thread.Sleep(1);
            }
            while (isRunning)
            {
                Thread.Sleep(1);
                if (core.checkLobbyState())
                {
                    core.sendChat(laneSelect.ToLower());
                    core.selectChamp(champID, true);
                    Thread.Sleep(500);
                    core.sendChat(laneSelect.ToUpper());
                    break;
                }
            }
            isRunning = false;
        }



        private void QuitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            champListBox.Items.Clear();
            using JsonDocument AllChampionDoc = JsonDocument.Parse(core.getAllChampion());
            JsonElement allChampion = AllChampionDoc.RootElement;
            for(int i = 1; i < allChampion.GetArrayLength(); i++)
            {
                if (allChampion[i].GetProperty("alias").ToString().ToLower().Contains(champSelectName.Text.ToLower())){
                    champListBox.Items.Add($" {allChampion[i].GetProperty("id")} {allChampion[i].GetProperty("alias")}");
                }
                // Debug.WriteLine(allChampion[i].GetProperty("alias"));
            }
            
            if(champListBox.Items.Count > 0)
            {
                champListBox.SelectedIndex = 0;
            }else
            {
                ChampNameLabel.Text = "";
                ChampTitleLabel.Text = "";
                var request = WebRequest.Create($"http://ddragon.leagueoflegends.com/cdn/12.23.1/img/profileicon/588.png");
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBox1.Image = Bitmap.FromStream(stream);
                }
            }
        }


        public void UpdateForm()
        {

        }
        private void TEST_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(currentDir);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            // isRunning = false;
            StartedPanel.Visible = true;
        }

        private void champListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] textArgs = champListBox.SelectedItem.ToString().Split(" ");

            using JsonDocument AllChampionDoc = JsonDocument.Parse(core.getAllChampion());
            JsonElement allChampion = AllChampionDoc.RootElement;
            for (int i = 1; i < allChampion.GetArrayLength(); i++)
            {
                if (allChampion[i].GetProperty("id").ToString() == textArgs[1])
                {
                    ChampNameLabel.Text = allChampion[i].GetProperty("alias").ToString();
                    ChampTitleLabel.Text = allChampion[i].GetProperty("title").ToString();
                }
            }
            
            champName = textArgs[2];
            champID = textArgs[1];
            pictureBox1.Image = Image.FromFile($"./asset/loading/{champName}_0.jpg");
        }


        //Top head panel
        int mouseX, mouseY = 0;
        bool mouseDown = false;
        private void TopHeadPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void TopHeadPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void MiniButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void TopHeadPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LaneSelect1_CheckedChanged(object sender, EventArgs e)
        {
            laneSelect = "top";
            laneUrl = "401305-CHALLENGER.png";
        }

        private void LaneSelect2_CheckedChanged(object sender, EventArgs e)
        {
            laneSelect = "jg";
            laneUrl = "401301-CHALLENGER.png";
        }

        private void LaneSelect3_CheckedChanged(object sender, EventArgs e)
        {
            laneSelect = "mid";
            laneUrl = "401304-CHALLENGER.png";
        }

        private void LaneSelect4_CheckedChanged(object sender, EventArgs e)
        {
            laneSelect = "sup";
            laneUrl = "401302-CHALLENGER.png";
        }

        private void LaneSelect5_CheckedChanged(object sender, EventArgs e)
        {
            laneSelect = "adc";
            laneUrl = "401303-CHALLENGER.png";
        }

        private void StartedPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelRunningBtn_Click(object sender, EventArgs e)
        {
            StartedPanel.Visible = false;
            isRunning = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isRunning == false)
            {
                StartedPanel.Visible = false;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if(laneSelect == "" || champID == "")
            {
                MessageBox.Show("ERROR_INPUT_INCORRECT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(MessageBox.Show($"Selected champion : {champName}\nSelected lane : {laneSelect}", "Accept", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) {
                return;
            }

            runningPicture.Image = Image.FromFile($"./asset/splash/{champName}_0.jpg");

            var request2 = WebRequest.Create($"http://ddragon.leagueoflegends.com/cdn/img/challenges-images/{laneUrl}");
            using (var response = request2.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                RunningLaneLogo.Image = Bitmap.FromStream(stream);
            }

            StartedPanel.Visible = true;

            taskThread = new Thread(new ThreadStart(StartMatchAccept));
            taskThread.Name = "taskThread";
            isRunning = true;
            taskThread.Start();
        }


    }
}