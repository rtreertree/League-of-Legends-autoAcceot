namespace LeagueAutoAccept
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.Desktop.UI.AnimatorNS.Animation animation1 = new Siticone.Desktop.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopHeadPanel = new System.Windows.Forms.Panel();
            this.FormTitleLabel = new System.Windows.Forms.Label();
            this.MiniButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.QuitButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.champSelectName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TEST = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.champListBox = new System.Windows.Forms.ListBox();
            this.ChampNameLabel = new System.Windows.Forms.Label();
            this.ChampTitleLabel = new System.Windows.Forms.Label();
            this.LaneSelectPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowPanel();
            this.LaneSelect5 = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            this.LaneSelect4 = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            this.LaneSelect3 = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            this.LaneSelect2 = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            this.LaneSelect1 = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.startBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.StartedPanel = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.RunningLaneLogo = new System.Windows.Forms.PictureBox();
            this.runningPicture = new System.Windows.Forms.PictureBox();
            this.CancelRunningBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.siticoneTransition1 = new Siticone.Desktop.UI.WinForms.SiticoneTransition();
            this.TopHeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LaneSelectPanel1.SuspendLayout();
            this.StartedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RunningLaneLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TopHeadPanel
            // 
            this.TopHeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.TopHeadPanel.Controls.Add(this.FormTitleLabel);
            this.TopHeadPanel.Controls.Add(this.MiniButton);
            this.TopHeadPanel.Controls.Add(this.QuitButton);
            this.siticoneTransition1.SetDecoration(this.TopHeadPanel, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.TopHeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopHeadPanel.Location = new System.Drawing.Point(0, 0);
            this.TopHeadPanel.Name = "TopHeadPanel";
            this.TopHeadPanel.Size = new System.Drawing.Size(583, 36);
            this.TopHeadPanel.TabIndex = 0;
            this.TopHeadPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopHeadPanel_MouseDown);
            this.TopHeadPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopHeadPanel_MouseMove);
            this.TopHeadPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopHeadPanel_MouseUp);
            // 
            // FormTitleLabel
            // 
            this.FormTitleLabel.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.FormTitleLabel, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.FormTitleLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormTitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormTitleLabel.Location = new System.Drawing.Point(147, 9);
            this.FormTitleLabel.Name = "FormTitleLabel";
            this.FormTitleLabel.Size = new System.Drawing.Size(270, 38);
            this.FormTitleLabel.TabIndex = 3;
            this.FormTitleLabel.Text = "League of Legends auto accept\r\n\r\n";
            // 
            // MiniButton
            // 
            this.siticoneTransition1.SetDecoration(this.MiniButton, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.MiniButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MiniButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MiniButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MiniButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MiniButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.MiniButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(46)))));
            this.MiniButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MiniButton.ForeColor = System.Drawing.SystemColors.Window;
            this.MiniButton.Location = new System.Drawing.Point(514, 4);
            this.MiniButton.Name = "MiniButton";
            this.MiniButton.Size = new System.Drawing.Size(30, 29);
            this.MiniButton.TabIndex = 2;
            this.MiniButton.Text = "_";
            this.MiniButton.Click += new System.EventHandler(this.MiniButton_Click);
            // 
            // QuitButton
            // 
            this.siticoneTransition1.SetDecoration(this.QuitButton, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.QuitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.QuitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.QuitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.QuitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.QuitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.QuitButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(46)))));
            this.QuitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.QuitButton.Location = new System.Drawing.Point(550, 4);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(30, 29);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.Text = "X";
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // champSelectName
            // 
            this.champSelectName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.siticoneTransition1.SetDecoration(this.champSelectName, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.champSelectName.DefaultText = "";
            this.champSelectName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.champSelectName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.champSelectName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.champSelectName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.champSelectName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.champSelectName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.champSelectName.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.champSelectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.champSelectName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.champSelectName.Location = new System.Drawing.Point(38, 71);
            this.champSelectName.Margin = new System.Windows.Forms.Padding(1);
            this.champSelectName.Name = "champSelectName";
            this.champSelectName.PasswordChar = '\0';
            this.champSelectName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(103)))), ((int)(((byte)(153)))));
            this.champSelectName.PlaceholderText = "champion name";
            this.champSelectName.SelectedText = "";
            this.champSelectName.Size = new System.Drawing.Size(204, 25);
            this.champSelectName.TabIndex = 1;
            this.champSelectName.TextChanged += new System.EventHandler(this.siticoneTextBox1_TextChanged);
            // 
            // TEST
            // 
            this.siticoneTransition1.SetDecoration(this.TEST, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.TEST.Location = new System.Drawing.Point(38, 374);
            this.TEST.Name = "TEST";
            this.TEST.Size = new System.Drawing.Size(84, 34);
            this.TEST.TabIndex = 2;
            this.TEST.Text = "TEST";
            this.TEST.UseVisualStyleBackColor = true;
            this.TEST.Visible = false;
            this.TEST.Click += new System.EventHandler(this.TEST_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.siticoneTransition1.SetDecoration(this.pictureBox1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(423, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.siticoneTransition1.SetDecoration(this.button1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(128, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "TEST2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // champListBox
            // 
            this.champListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.champListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneTransition1.SetDecoration(this.champListBox, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.champListBox.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.champListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.champListBox.FormattingEnabled = true;
            this.champListBox.ItemHeight = 23;
            this.champListBox.Location = new System.Drawing.Point(38, 103);
            this.champListBox.Margin = new System.Windows.Forms.Padding(4);
            this.champListBox.Name = "champListBox";
            this.champListBox.Size = new System.Drawing.Size(204, 253);
            this.champListBox.TabIndex = 6;
            this.champListBox.SelectedIndexChanged += new System.EventHandler(this.champListBox_SelectedIndexChanged);
            // 
            // ChampNameLabel
            // 
            this.ChampNameLabel.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.ChampNameLabel, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.ChampNameLabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChampNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(193)))), ((int)(((byte)(222)))));
            this.ChampNameLabel.Location = new System.Drawing.Point(246, 71);
            this.ChampNameLabel.Name = "ChampNameLabel";
            this.ChampNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChampNameLabel.Size = new System.Drawing.Size(104, 32);
            this.ChampNameLabel.TabIndex = 7;
            this.ChampNameLabel.Text = "{NAME}";
            this.ChampNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChampTitleLabel
            // 
            this.ChampTitleLabel.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.ChampTitleLabel, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.ChampTitleLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChampTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(222)))));
            this.ChampTitleLabel.Location = new System.Drawing.Point(252, 116);
            this.ChampTitleLabel.Name = "ChampTitleLabel";
            this.ChampTitleLabel.Size = new System.Drawing.Size(87, 23);
            this.ChampTitleLabel.TabIndex = 8;
            this.ChampTitleLabel.Text = "{Title}";
            this.ChampTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LaneSelectPanel1
            // 
            this.LaneSelectPanel1.BackColor = System.Drawing.Color.Transparent;
            this.LaneSelectPanel1.Controls.Add(this.LaneSelect5);
            this.LaneSelectPanel1.Controls.Add(this.LaneSelect4);
            this.LaneSelectPanel1.Controls.Add(this.LaneSelect3);
            this.LaneSelectPanel1.Controls.Add(this.LaneSelect2);
            this.LaneSelectPanel1.Controls.Add(this.LaneSelect1);
            this.siticoneTransition1.SetDecoration(this.LaneSelectPanel1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.LaneSelectPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(28)))), ((int)(((byte)(61)))));
            this.LaneSelectPanel1.Location = new System.Drawing.Point(252, 147);
            this.LaneSelectPanel1.Name = "LaneSelectPanel1";
            this.LaneSelectPanel1.ShadowColor = System.Drawing.Color.Black;
            this.LaneSelectPanel1.ShadowStyle = Siticone.Desktop.UI.WinForms.SiticoneShadowPanel.ShadowMode.ForwardDiagonal;
            this.LaneSelectPanel1.Size = new System.Drawing.Size(165, 209);
            this.LaneSelectPanel1.TabIndex = 9;
            // 
            // LaneSelect5
            // 
            this.LaneSelect5.AutoSize = true;
            this.LaneSelect5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LaneSelect5.CheckedState.BorderThickness = 0;
            this.LaneSelect5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LaneSelect5.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LaneSelect5.CheckedState.InnerOffset = -4;
            this.siticoneTransition1.SetDecoration(this.LaneSelect5, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.LaneSelect5.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LaneSelect5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(221)))), ((int)(((byte)(245)))));
            this.LaneSelect5.Location = new System.Drawing.Point(19, 152);
            this.LaneSelect5.Name = "LaneSelect5";
            this.LaneSelect5.Size = new System.Drawing.Size(61, 27);
            this.LaneSelect5.TabIndex = 16;
            this.LaneSelect5.Text = "Adc";
            this.LaneSelect5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LaneSelect5.UncheckedState.BorderThickness = 2;
            this.LaneSelect5.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.LaneSelect5.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.LaneSelect5.CheckedChanged += new System.EventHandler(this.LaneSelect5_CheckedChanged);
            // 
            // LaneSelect4
            // 
            this.LaneSelect4.AutoSize = true;
            this.LaneSelect4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LaneSelect4.CheckedState.BorderThickness = 0;
            this.LaneSelect4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LaneSelect4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LaneSelect4.CheckedState.InnerOffset = -4;
            this.siticoneTransition1.SetDecoration(this.LaneSelect4, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.LaneSelect4.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LaneSelect4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(221)))), ((int)(((byte)(245)))));
            this.LaneSelect4.Location = new System.Drawing.Point(19, 119);
            this.LaneSelect4.Name = "LaneSelect4";
            this.LaneSelect4.Size = new System.Drawing.Size(105, 27);
            this.LaneSelect4.TabIndex = 15;
            this.LaneSelect4.Text = "Support";
            this.LaneSelect4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LaneSelect4.UncheckedState.BorderThickness = 2;
            this.LaneSelect4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.LaneSelect4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.LaneSelect4.CheckedChanged += new System.EventHandler(this.LaneSelect4_CheckedChanged);
            // 
            // LaneSelect3
            // 
            this.LaneSelect3.AutoSize = true;
            this.LaneSelect3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LaneSelect3.CheckedState.BorderThickness = 0;
            this.LaneSelect3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LaneSelect3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LaneSelect3.CheckedState.InnerOffset = -4;
            this.siticoneTransition1.SetDecoration(this.LaneSelect3, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.LaneSelect3.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LaneSelect3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(221)))), ((int)(((byte)(245)))));
            this.LaneSelect3.Location = new System.Drawing.Point(19, 86);
            this.LaneSelect3.Name = "LaneSelect3";
            this.LaneSelect3.Size = new System.Drawing.Size(61, 27);
            this.LaneSelect3.TabIndex = 14;
            this.LaneSelect3.Text = "Mid";
            this.LaneSelect3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LaneSelect3.UncheckedState.BorderThickness = 2;
            this.LaneSelect3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.LaneSelect3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.LaneSelect3.CheckedChanged += new System.EventHandler(this.LaneSelect3_CheckedChanged);
            // 
            // LaneSelect2
            // 
            this.LaneSelect2.AutoSize = true;
            this.LaneSelect2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LaneSelect2.CheckedState.BorderThickness = 0;
            this.LaneSelect2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LaneSelect2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LaneSelect2.CheckedState.InnerOffset = -4;
            this.siticoneTransition1.SetDecoration(this.LaneSelect2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.LaneSelect2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LaneSelect2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(221)))), ((int)(((byte)(245)))));
            this.LaneSelect2.Location = new System.Drawing.Point(19, 53);
            this.LaneSelect2.Name = "LaneSelect2";
            this.LaneSelect2.Size = new System.Drawing.Size(94, 27);
            this.LaneSelect2.TabIndex = 13;
            this.LaneSelect2.Text = "Jungle";
            this.LaneSelect2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LaneSelect2.UncheckedState.BorderThickness = 2;
            this.LaneSelect2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.LaneSelect2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.LaneSelect2.CheckedChanged += new System.EventHandler(this.LaneSelect2_CheckedChanged);
            // 
            // LaneSelect1
            // 
            this.LaneSelect1.AutoSize = true;
            this.LaneSelect1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LaneSelect1.CheckedState.BorderThickness = 0;
            this.LaneSelect1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LaneSelect1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LaneSelect1.CheckedState.InnerOffset = -4;
            this.siticoneTransition1.SetDecoration(this.LaneSelect1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.LaneSelect1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LaneSelect1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(221)))), ((int)(((byte)(245)))));
            this.LaneSelect1.Location = new System.Drawing.Point(19, 20);
            this.LaneSelect1.Name = "LaneSelect1";
            this.LaneSelect1.Size = new System.Drawing.Size(61, 27);
            this.LaneSelect1.TabIndex = 12;
            this.LaneSelect1.Text = "Top";
            this.LaneSelect1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LaneSelect1.UncheckedState.BorderThickness = 2;
            this.LaneSelect1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.LaneSelect1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.LaneSelect1.CheckedChanged += new System.EventHandler(this.LaneSelect1_CheckedChanged);
            // 
            // siticoneSeparator1
            // 
            this.siticoneTransition1.SetDecoration(this.siticoneSeparator1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.siticoneSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(2)))));
            this.siticoneSeparator1.FillThickness = 3;
            this.siticoneSeparator1.Location = new System.Drawing.Point(38, 50);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(505, 10);
            this.siticoneSeparator1.TabIndex = 11;
            // 
            // startBtn
            // 
            this.startBtn.Animated = true;
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(2)))));
            this.startBtn.BorderRadius = 3;
            this.siticoneTransition1.SetDecoration(this.startBtn, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.startBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.startBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.startBtn.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(221)))), ((int)(((byte)(245)))));
            this.startBtn.Location = new System.Drawing.Point(252, 365);
            this.startBtn.Name = "startBtn";
            this.startBtn.PressedDepth = 50;
            this.startBtn.Size = new System.Drawing.Size(292, 43);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "Start";
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // StartedPanel
            // 
            this.StartedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.StartedPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(102)))), ((int)(((byte)(2)))));
            this.StartedPanel.BorderThickness = 2;
            this.StartedPanel.Controls.Add(this.RunningLaneLogo);
            this.StartedPanel.Controls.Add(this.runningPicture);
            this.StartedPanel.Controls.Add(this.CancelRunningBtn);
            this.siticoneTransition1.SetDecoration(this.StartedPanel, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.StartedPanel.Location = new System.Drawing.Point(12, 39);
            this.StartedPanel.Name = "StartedPanel";
            this.StartedPanel.Size = new System.Drawing.Size(559, 422);
            this.StartedPanel.TabIndex = 13;
            this.StartedPanel.Visible = false;
            this.StartedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.StartedPanel_Paint);
            // 
            // RunningLaneLogo
            // 
            this.siticoneTransition1.SetDecoration(this.RunningLaneLogo, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.RunningLaneLogo.Location = new System.Drawing.Point(82, 306);
            this.RunningLaneLogo.Name = "RunningLaneLogo";
            this.RunningLaneLogo.Size = new System.Drawing.Size(90, 90);
            this.RunningLaneLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RunningLaneLogo.TabIndex = 3;
            this.RunningLaneLogo.TabStop = false;
            // 
            // runningPicture
            // 
            this.siticoneTransition1.SetDecoration(this.runningPicture, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.runningPicture.Location = new System.Drawing.Point(82, 32);
            this.runningPicture.Name = "runningPicture";
            this.runningPicture.Size = new System.Drawing.Size(405, 255);
            this.runningPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.runningPicture.TabIndex = 2;
            this.runningPicture.TabStop = false;
            // 
            // CancelRunningBtn
            // 
            this.CancelRunningBtn.Animated = true;
            this.CancelRunningBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(132)))), ((int)(((byte)(212)))));
            this.CancelRunningBtn.BorderThickness = 2;
            this.siticoneTransition1.SetDecoration(this.CancelRunningBtn, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.CancelRunningBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelRunningBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelRunningBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelRunningBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelRunningBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelRunningBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(69)))));
            this.CancelRunningBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(71)))), ((int)(((byte)(110)))));
            this.CancelRunningBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelRunningBtn.ForeColor = System.Drawing.Color.White;
            this.CancelRunningBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.CancelRunningBtn.Location = new System.Drawing.Point(336, 356);
            this.CancelRunningBtn.Name = "CancelRunningBtn";
            this.CancelRunningBtn.Size = new System.Drawing.Size(151, 40);
            this.CancelRunningBtn.TabIndex = 1;
            this.CancelRunningBtn.Text = "Cancel";
            this.CancelRunningBtn.Click += new System.EventHandler(this.CancelRunningBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.Desktop.UI.AnimatorNS.AnimationType.Transparent;
            this.siticoneTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(35)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(583, 476);
            this.Controls.Add(this.StartedPanel);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.siticoneSeparator1);
            this.Controls.Add(this.LaneSelectPanel1);
            this.Controls.Add(this.ChampTitleLabel);
            this.Controls.Add(this.ChampNameLabel);
            this.Controls.Add(this.champListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TEST);
            this.Controls.Add(this.champSelectName);
            this.Controls.Add(this.TopHeadPanel);
            this.siticoneTransition1.SetDecoration(this, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "League auto accept";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopHeadPanel.ResumeLayout(false);
            this.TopHeadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LaneSelectPanel1.ResumeLayout(false);
            this.LaneSelectPanel1.PerformLayout();
            this.StartedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RunningLaneLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel TopHeadPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton QuitButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox champSelectName;
        private Button TEST;
        private PictureBox pictureBox1;
        private Button button1;
        private ListBox champListBox;
        private Label ChampNameLabel;
        private Label ChampTitleLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowPanel LaneSelectPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton LaneSelect5;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton LaneSelect4;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton LaneSelect3;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton LaneSelect2;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton LaneSelect1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton MiniButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton startBtn;
        private Label FormTitleLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel StartedPanel;
        private PictureBox runningPicture;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton CancelRunningBtn;
        private PictureBox RunningLaneLogo;
        private Siticone.Desktop.UI.WinForms.SiticoneTransition siticoneTransition1;
        private System.Windows.Forms.Timer timer1;
    }
}