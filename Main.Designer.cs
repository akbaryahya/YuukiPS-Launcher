﻿namespace YuukiPS_Launcher
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            btStartNormal = new Button();
            GetServerHost = new TextBox();
            label2 = new Label();
            GetProxyPort = new TextBox();
            TabMain = new TabControl();
            tabPage1 = new TabPage();
            grConfigGameLite = new GroupBox();
            Set_LA_Select = new Button();
            Set_LA_GameFolder = new TextBox();
            label5 = new Label();
            stIsRunProxy = new Label();
            groupBox8 = new GroupBox();
            btStartYuukiServer = new Button();
            GetTypeGame = new ComboBox();
            btStartOfficialServer = new Button();
            grProfile = new GroupBox();
            GetProfileServer = new ComboBox();
            btload = new Button();
            btsave = new Button();
            label8 = new Label();
            grExtra = new GroupBox();
            Enable_WipeLoginCache = new CheckBox();
            EnableSendLog = new CheckBox();
            ExtraCheat = new CheckBox();
            Enable_RPC = new CheckBox();
            grProxy = new GroupBox();
            CheckProxyEnable = new CheckBox();
            groupBox3 = new GroupBox();
            Get_LA_Version = new Label();
            Get_LA_MD5 = new Label();
            Get_LA_CH = new Label();
            Get_LA_REL = new Label();
            tabPage2 = new TabPage();
            tabControl2 = new TabControl();
            tabPage10 = new TabPage();
            groupBox4 = new GroupBox();
            Server_DL_DB = new Button();
            Server_DL_JAVA = new Button();
            groupBox6 = new GroupBox();
            Server_DL_RES = new Button();
            comboBox2 = new ComboBox();
            Server_Start = new Button();
            SetVersion = new Label();
            groupBox5 = new GroupBox();
            Server_DL_GC = new Button();
            comboBox1 = new ComboBox();
            Server_Config_OpenFolder = new Button();
            tabPage11 = new TabPage();
            textBox4 = new TextBox();
            label17 = new Label();
            textBox3 = new TextBox();
            label16 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label15 = new Label();
            textBox1 = new TextBox();
            label14 = new Label();
            linkDiscord = new LinkLabel();
            linkGithub = new LinkLabel();
            linkWeb = new LinkLabel();
            CheckGameRun = new System.Windows.Forms.Timer(components);
            CheckProxyRun = new System.Windows.Forms.Timer(components);
            TabMain.SuspendLayout();
            tabPage1.SuspendLayout();
            grConfigGameLite.SuspendLayout();
            groupBox8.SuspendLayout();
            grProfile.SuspendLayout();
            grExtra.SuspendLayout();
            grProxy.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage10.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            tabPage11.SuspendLayout();
            SuspendLayout();
            // 
            // btStartNormal
            // 
            btStartNormal.BackColor = Color.FromArgb(52, 152, 219);
            btStartNormal.FlatStyle = FlatStyle.Flat;
            btStartNormal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btStartNormal.ForeColor = Color.White;
            btStartNormal.Location = new Point(10, 54);
            btStartNormal.Name = "btStartNormal";
            btStartNormal.Size = new Size(120, 40);
            btStartNormal.TabIndex = 0;
            btStartNormal.Text = "Launch";
            btStartNormal.UseVisualStyleBackColor = false;
            btStartNormal.Click += BTStartNormal_Click;
            // 
            // GetServerHost
            // 
            GetServerHost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GetServerHost.Location = new Point(10, 20);
            GetServerHost.Name = "GetServerHost";
            GetServerHost.PlaceholderText = "https://ps.yuuki.me";
            GetServerHost.Size = new Size(250, 29);
            GetServerHost.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(270, 25);
            label2.Name = "label2";
            label2.Size = new Size(37, 19);
            label2.TabIndex = 4;
            label2.Text = "Port:";
            // 
            // GetProxyPort
            // 
            GetProxyPort.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            GetProxyPort.Location = new Point(310, 22);
            GetProxyPort.Name = "GetProxyPort";
            GetProxyPort.Size = new Size(60, 25);
            GetProxyPort.TabIndex = 5;
            GetProxyPort.Text = "2242";
            // 
            // TabMain
            // 
            TabMain.Controls.Add(tabPage1);
            TabMain.Controls.Add(tabPage2);
            TabMain.Dock = DockStyle.Fill;
            TabMain.Location = new Point(0, 0);
            TabMain.Name = "TabMain";
            TabMain.SelectedIndex = 0;
            TabMain.Size = new Size(720, 396);
            TabMain.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(grConfigGameLite);
            tabPage1.Controls.Add(stIsRunProxy);
            tabPage1.Controls.Add(groupBox8);
            tabPage1.Controls.Add(grProfile);
            tabPage1.Controls.Add(grExtra);
            tabPage1.Controls.Add(grProxy);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(712, 368);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Connect";
            // 
            // grConfigGameLite
            // 
            grConfigGameLite.Controls.Add(Set_LA_Select);
            grConfigGameLite.Controls.Add(Set_LA_GameFolder);
            grConfigGameLite.Controls.Add(label5);
            grConfigGameLite.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grConfigGameLite.Location = new Point(10, 110);
            grConfigGameLite.Name = "grConfigGameLite";
            grConfigGameLite.Size = new Size(457, 60);
            grConfigGameLite.TabIndex = 19;
            grConfigGameLite.TabStop = false;
            grConfigGameLite.Text = "Game Config";
            // 
            // Set_LA_Select
            // 
            Set_LA_Select.BackColor = Color.FromArgb(46, 204, 113);
            Set_LA_Select.FlatStyle = FlatStyle.Flat;
            Set_LA_Select.ForeColor = Color.White;
            Set_LA_Select.Location = new Point(381, 20);
            Set_LA_Select.Name = "Set_LA_Select";
            Set_LA_Select.Size = new Size(70, 30);
            Set_LA_Select.TabIndex = 9;
            Set_LA_Select.Text = "Choose";
            Set_LA_Select.UseVisualStyleBackColor = false;
            Set_LA_Select.Click += Set_LA_Select_Click;
            // 
            // Set_LA_GameFolder
            // 
            Set_LA_GameFolder.Location = new Point(110, 20);
            Set_LA_GameFolder.Name = "Set_LA_GameFolder";
            Set_LA_GameFolder.ReadOnly = true;
            Set_LA_GameFolder.Size = new Size(200, 25);
            Set_LA_GameFolder.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 23);
            label5.Name = "label5";
            label5.Size = new Size(90, 19);
            label5.TabIndex = 0;
            label5.Text = "Game Folder:";
            // 
            // stIsRunProxy
            // 
            stIsRunProxy.AutoSize = true;
            stIsRunProxy.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            stIsRunProxy.Location = new Point(10, 340);
            stIsRunProxy.Name = "stIsRunProxy";
            stIsRunProxy.Size = new Size(79, 19);
            stIsRunProxy.TabIndex = 8;
            stIsRunProxy.Text = "Status: OFF";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(btStartYuukiServer);
            groupBox8.Controls.Add(GetServerHost);
            groupBox8.Controls.Add(btStartNormal);
            groupBox8.Controls.Add(GetTypeGame);
            groupBox8.Controls.Add(btStartOfficialServer);
            groupBox8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox8.Location = new Point(10, 10);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(457, 100);
            groupBox8.TabIndex = 18;
            groupBox8.TabStop = false;
            groupBox8.Text = "Connect to server";
            // 
            // btStartYuukiServer
            // 
            btStartYuukiServer.BackColor = Color.FromArgb(52, 152, 219);
            btStartYuukiServer.FlatStyle = FlatStyle.Flat;
            btStartYuukiServer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btStartYuukiServer.ForeColor = Color.White;
            btStartYuukiServer.Location = new Point(360, 20);
            btStartYuukiServer.Name = "btStartYuukiServer";
            btStartYuukiServer.Size = new Size(91, 35);
            btStartYuukiServer.TabIndex = 20;
            btStartYuukiServer.Text = "YuukiPS";
            btStartYuukiServer.UseVisualStyleBackColor = false;
            btStartYuukiServer.Click += BTStartYuukiServer_Click;
            // 
            // GetTypeGame
            // 
            GetTypeGame.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GetTypeGame.FormattingEnabled = true;
            GetTypeGame.Location = new Point(151, 61);
            GetTypeGame.Name = "GetTypeGame";
            GetTypeGame.Size = new Size(300, 29);
            GetTypeGame.TabIndex = 14;
            GetTypeGame.SelectedIndexChanged += GetTypeGame_SelectedIndexChanged;
            // 
            // btStartOfficialServer
            // 
            btStartOfficialServer.BackColor = Color.FromArgb(46, 204, 113);
            btStartOfficialServer.FlatStyle = FlatStyle.Flat;
            btStartOfficialServer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btStartOfficialServer.ForeColor = Color.White;
            btStartOfficialServer.Location = new Point(273, 20);
            btStartOfficialServer.Name = "btStartOfficialServer";
            btStartOfficialServer.Size = new Size(81, 35);
            btStartOfficialServer.TabIndex = 13;
            btStartOfficialServer.Text = "Official";
            btStartOfficialServer.UseVisualStyleBackColor = false;
            btStartOfficialServer.Click += BTStartOfficialServer_Click;
            // 
            // grProfile
            // 
            grProfile.Controls.Add(GetProfileServer);
            grProfile.Controls.Add(btload);
            grProfile.Controls.Add(btsave);
            grProfile.Controls.Add(label8);
            grProfile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grProfile.Location = new Point(6, 176);
            grProfile.Name = "grProfile";
            grProfile.Size = new Size(461, 108);
            grProfile.TabIndex = 17;
            grProfile.TabStop = false;
            grProfile.Text = "Profile";
            // 
            // GetProfileServer
            // 
            GetProfileServer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GetProfileServer.FormattingEnabled = true;
            GetProfileServer.Location = new Point(14, 33);
            GetProfileServer.Name = "GetProfileServer";
            GetProfileServer.Size = new Size(234, 29);
            GetProfileServer.TabIndex = 15;
            GetProfileServer.SelectedIndexChanged += GetProfileServer_SelectedIndexChanged;
            // 
            // btload
            // 
            btload.BackColor = Color.FromArgb(52, 152, 219);
            btload.FlatStyle = FlatStyle.Flat;
            btload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btload.ForeColor = Color.White;
            btload.Location = new Point(380, 28);
            btload.Name = "btload";
            btload.Size = new Size(75, 38);
            btload.TabIndex = 16;
            btload.Text = "Load";
            btload.UseVisualStyleBackColor = false;
            btload.Click += BTLoadClick;
            // 
            // btsave
            // 
            btsave.BackColor = Color.FromArgb(46, 204, 113);
            btsave.FlatStyle = FlatStyle.Flat;
            btsave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btsave.ForeColor = Color.White;
            btsave.Location = new Point(294, 28);
            btsave.Name = "btsave";
            btsave.Size = new Size(80, 38);
            btsave.TabIndex = 2;
            btsave.Text = "Save";
            btsave.UseVisualStyleBackColor = false;
            btsave.Click += SetLASaveClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(118, 69);
            label8.Name = "label8";
            label8.Size = new Size(269, 19);
            label8.TabIndex = 13;
            label8.Text = "Click 'Save' to store current profile settings";
            // 
            // grExtra
            // 
            grExtra.BackColor = Color.FromArgb(240, 240, 240);
            grExtra.Controls.Add(Enable_WipeLoginCache);
            grExtra.Controls.Add(EnableSendLog);
            grExtra.Controls.Add(ExtraCheat);
            grExtra.Controls.Add(Enable_RPC);
            grExtra.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grExtra.ForeColor = Color.FromArgb(60, 60, 60);
            grExtra.Location = new Point(487, 158);
            grExtra.Name = "grExtra";
            grExtra.Size = new Size(217, 139);
            grExtra.TabIndex = 12;
            grExtra.TabStop = false;
            grExtra.Text = "Extra";
            // 
            // Enable_WipeLoginCache
            // 
            Enable_WipeLoginCache.AutoSize = true;
            Enable_WipeLoginCache.ForeColor = Color.FromArgb(60, 60, 60);
            Enable_WipeLoginCache.Location = new Point(10, 80);
            Enable_WipeLoginCache.Name = "Enable_WipeLoginCache";
            Enable_WipeLoginCache.Size = new Size(97, 23);
            Enable_WipeLoginCache.TabIndex = 20;
            Enable_WipeLoginCache.Text = "Wipe Login";
            Enable_WipeLoginCache.UseVisualStyleBackColor = true;
            // 
            // Enable_SendLog
            // 
            EnableSendLog.AutoSize = true;
            EnableSendLog.Checked = true;
            EnableSendLog.CheckState = CheckState.Checked;
            EnableSendLog.ForeColor = Color.FromArgb(60, 60, 60);
            EnableSendLog.Location = new Point(10, 55);
            EnableSendLog.Name = "Enable_SendLog";
            EnableSendLog.Size = new Size(91, 23);
            EnableSendLog.TabIndex = 2;
            EnableSendLog.Text = "Send Logs";
            EnableSendLog.UseVisualStyleBackColor = true;
            // 
            // Extra_Cheat
            // 
            ExtraCheat.AutoSize = true;
            ExtraCheat.ForeColor = Color.FromArgb(60, 60, 60);
            ExtraCheat.Location = new Point(10, 30);
            ExtraCheat.Name = "Extra_Cheat";
            ExtraCheat.Size = new Size(64, 23);
            ExtraCheat.TabIndex = 0;
            ExtraCheat.Text = "Cheat";
            ExtraCheat.UseVisualStyleBackColor = true;
            // 
            // Enable_RPC
            // 
            Enable_RPC.AutoSize = true;
            Enable_RPC.ForeColor = Color.FromArgb(60, 60, 60);
            Enable_RPC.Location = new Point(10, 105);
            Enable_RPC.Name = "Enable_RPC";
            Enable_RPC.Size = new Size(169, 23);
            Enable_RPC.TabIndex = 1;
            Enable_RPC.Text = "Rich Presence (Discord)";
            Enable_RPC.UseVisualStyleBackColor = true;
            Enable_RPC.CheckedChanged += ExtraEnableRPCCheckedChanged;
            // 
            // grProxy
            // 
            grProxy.BackColor = Color.FromArgb(240, 240, 240);
            grProxy.Controls.Add(GetProxyPort);
            grProxy.Controls.Add(CheckProxyEnable);
            grProxy.Controls.Add(label2);
            grProxy.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grProxy.ForeColor = Color.FromArgb(60, 60, 60);
            grProxy.Location = new Point(487, 308);
            grProxy.Name = "grProxy";
            grProxy.Size = new Size(217, 51);
            grProxy.TabIndex = 11;
            grProxy.TabStop = false;
            grProxy.Text = "Proxy";
            // 
            // CheckProxyEnable
            // 
            CheckProxyEnable.AutoSize = true;
            CheckProxyEnable.Checked = true;
            CheckProxyEnable.CheckState = CheckState.Checked;
            CheckProxyEnable.ForeColor = Color.FromArgb(60, 60, 60);
            CheckProxyEnable.Location = new Point(10, 25);
            CheckProxyEnable.Name = "CheckProxyEnable";
            CheckProxyEnable.Size = new Size(68, 23);
            CheckProxyEnable.TabIndex = 7;
            CheckProxyEnable.Text = "Enable";
            CheckProxyEnable.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(240, 240, 240);
            groupBox3.Controls.Add(Get_LA_Version);
            groupBox3.Controls.Add(Get_LA_MD5);
            groupBox3.Controls.Add(Get_LA_CH);
            groupBox3.Controls.Add(Get_LA_REL);
            groupBox3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.FromArgb(60, 60, 60);
            groupBox3.Location = new Point(487, 8);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(217, 144);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Game Info";
            // 
            // Get_LA_Version
            // 
            Get_LA_Version.AutoSize = true;
            Get_LA_Version.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Get_LA_Version.ForeColor = Color.FromArgb(60, 60, 60);
            Get_LA_Version.Location = new Point(10, 30);
            Get_LA_Version.Name = "Get_LA_Version";
            Get_LA_Version.Size = new Size(120, 19);
            Get_LA_Version.TabIndex = 3;
            Get_LA_Version.Text = "Version: Unknown";
            // 
            // Get_LA_MD5
            // 
            Get_LA_MD5.AutoSize = true;
            Get_LA_MD5.Cursor = Cursors.Hand;
            Get_LA_MD5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Get_LA_MD5.ForeColor = Color.FromArgb(60, 60, 60);
            Get_LA_MD5.Location = new Point(10, 110);
            Get_LA_MD5.Name = "Get_LA_MD5";
            Get_LA_MD5.Size = new Size(106, 19);
            Get_LA_MD5.TabIndex = 7;
            Get_LA_MD5.Text = "MD5: Unknown";
            Get_LA_MD5.Click += GetLAMD5Click;
            // 
            // Get_LA_CH
            // 
            Get_LA_CH.AutoSize = true;
            Get_LA_CH.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Get_LA_CH.ForeColor = Color.FromArgb(60, 60, 60);
            Get_LA_CH.Location = new Point(10, 55);
            Get_LA_CH.Name = "Get_LA_CH";
            Get_LA_CH.Size = new Size(125, 19);
            Get_LA_CH.TabIndex = 4;
            Get_LA_CH.Text = "Channel: Unknown";
            // 
            // Get_LA_REL
            // 
            Get_LA_REL.AutoSize = true;
            Get_LA_REL.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Get_LA_REL.ForeColor = Color.FromArgb(50, 50, 50);
            Get_LA_REL.Location = new Point(10, 80);
            Get_LA_REL.Name = "Get_LA_REL";
            Get_LA_REL.Size = new Size(128, 20);
            Get_LA_REL.TabIndex = 5;
            Get_LA_REL.Text = "Release: Unknown";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(tabControl2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(712, 368);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Server";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage10);
            tabControl2.Controls.Add(tabPage11);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl2.Location = new Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(706, 362);
            tabControl2.TabIndex = 8;
            // 
            // tabPage10
            // 
            tabPage10.BackColor = Color.White;
            tabPage10.Controls.Add(groupBox4);
            tabPage10.Controls.Add(groupBox6);
            tabPage10.Controls.Add(Server_Start);
            tabPage10.Controls.Add(SetVersion);
            tabPage10.Controls.Add(groupBox5);
            tabPage10.Controls.Add(Server_Config_OpenFolder);
            tabPage10.Location = new Point(4, 29);
            tabPage10.Name = "tabPage10";
            tabPage10.Padding = new Padding(3);
            tabPage10.Size = new Size(698, 329);
            tabPage10.TabIndex = 0;
            tabPage10.Text = "Home";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Server_DL_DB);
            groupBox4.Controls.Add(Server_DL_JAVA);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(10, 10);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(170, 120);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Download Package";
            // 
            // Server_DL_DB
            // 
            Server_DL_DB.Location = new Point(10, 73);
            Server_DL_DB.Name = "Server_DL_DB";
            Server_DL_DB.Size = new Size(150, 35);
            Server_DL_DB.TabIndex = 1;
            Server_DL_DB.Text = "MongoDB";
            Server_DL_DB.UseVisualStyleBackColor = true;
            // 
            // Server_DL_JAVA
            // 
            Server_DL_JAVA.Location = new Point(10, 29);
            Server_DL_JAVA.Name = "Server_DL_JAVA";
            Server_DL_JAVA.Size = new Size(150, 35);
            Server_DL_JAVA.TabIndex = 0;
            Server_DL_JAVA.Text = "Java";
            Server_DL_JAVA.UseVisualStyleBackColor = true;
            Server_DL_JAVA.Click += ServerDLJAVAClick;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(Server_DL_RES);
            groupBox6.Controls.Add(comboBox2);
            groupBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(196, 10);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(180, 120);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Version Resources";
            // 
            // Server_DL_RES
            // 
            Server_DL_RES.Location = new Point(10, 73);
            Server_DL_RES.Name = "Server_DL_RES";
            Server_DL_RES.Size = new Size(160, 35);
            Server_DL_RES.TabIndex = 8;
            Server_DL_RES.Text = "Download";
            Server_DL_RES.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Yuuki Gitlab 3.1", "Yuuki Gitlab 3.0", "Yuuki Gitlab 2.8", "Yuuki Gitlab 2.7", "Yuuki Gitlab 2.6" });
            comboBox2.Location = new Point(10, 29);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 29);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "Yuuki Gitlab 3.1";
            // 
            // Server_Start
            // 
            Server_Start.BackColor = Color.FromArgb(52, 152, 219);
            Server_Start.Cursor = Cursors.Hand;
            Server_Start.FlatStyle = FlatStyle.Flat;
            Server_Start.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Server_Start.ForeColor = Color.White;
            Server_Start.Location = new Point(10, 10);
            Server_Start.Name = "Server_Start";
            Server_Start.Size = new Size(120, 40);
            Server_Start.TabIndex = 0;
            Server_Start.Text = "Start Server";
            Server_Start.UseVisualStyleBackColor = false;
            Server_Start.Click += ServerStartClick;
            // 
            // SetVersion
            // 
            SetVersion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SetVersion.Location = new Point(10, 306);
            SetVersion.Name = "SetVersion";
            SetVersion.Size = new Size(94, 20);
            SetVersion.TabIndex = 12;
            SetVersion.Text = "Version: 0.0.0";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(Server_DL_GC);
            groupBox5.Controls.Add(comboBox1);
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(382, 10);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(300, 120);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Grasscutter Version";
            // 
            // Server_DL_GC
            // 
            Server_DL_GC.BackColor = Color.FromArgb(46, 204, 113);
            Server_DL_GC.Cursor = Cursors.Hand;
            Server_DL_GC.FlatStyle = FlatStyle.Flat;
            Server_DL_GC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Server_DL_GC.ForeColor = Color.White;
            Server_DL_GC.Location = new Point(10, 70);
            Server_DL_GC.Name = "Server_DL_GC";
            Server_DL_GC.Size = new Size(280, 40);
            Server_DL_GC.TabIndex = 3;
            Server_DL_GC.Text = "Download";
            Server_DL_GC.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DockerGS 2.6", "DockerGS 2.7", "DockerGS 2.8", "DockerGS 3.0", "DockerGS 3.1" });
            comboBox1.Location = new Point(10, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(280, 29);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "DockerGC 3.1";
            // 
            // Server_Config_OpenFolder
            // 
            Server_Config_OpenFolder.BackColor = Color.FromArgb(52, 152, 219);
            Server_Config_OpenFolder.Cursor = Cursors.Hand;
            Server_Config_OpenFolder.Enabled = false;
            Server_Config_OpenFolder.FlatStyle = FlatStyle.Flat;
            Server_Config_OpenFolder.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Server_Config_OpenFolder.ForeColor = Color.White;
            Server_Config_OpenFolder.Location = new Point(10, 141);
            Server_Config_OpenFolder.Name = "Server_Config_OpenFolder";
            Server_Config_OpenFolder.Size = new Size(150, 35);
            Server_Config_OpenFolder.TabIndex = 1;
            Server_Config_OpenFolder.Text = "Open Server Folder";
            Server_Config_OpenFolder.UseVisualStyleBackColor = false;
            // 
            // tabPage11
            // 
            tabPage11.BackColor = Color.FromArgb(236, 240, 241);
            tabPage11.Controls.Add(textBox4);
            tabPage11.Controls.Add(label17);
            tabPage11.Controls.Add(textBox3);
            tabPage11.Controls.Add(label16);
            tabPage11.Controls.Add(button1);
            tabPage11.Controls.Add(textBox2);
            tabPage11.Controls.Add(label15);
            tabPage11.Controls.Add(textBox1);
            tabPage11.Controls.Add(label14);
            tabPage11.Location = new Point(4, 29);
            tabPage11.Name = "tabPage11";
            tabPage11.Padding = new Padding(10);
            tabPage11.Size = new Size(698, 329);
            tabPage11.TabIndex = 1;
            tabPage11.Text = "Custom Settings";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(10, 220);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(620, 22);
            textBox4.TabIndex = 8;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(10, 195);
            label17.Name = "label17";
            label17.Size = new Size(170, 21);
            label17.TabIndex = 7;
            label17.Text = "MongoDB Folder (BIN):";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(10, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(620, 22);
            textBox3.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(10, 140);
            label16.Name = "label16";
            label16.Size = new Size(130, 21);
            label16.TabIndex = 5;
            label16.Text = "Java Folder (BIN):";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 152, 219);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(530, 260);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(10, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(620, 22);
            textBox2.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(10, 85);
            label15.Name = "label15";
            label15.Size = new Size(215, 21);
            label15.TabIndex = 2;
            label15.Text = "Grasscutter Resources Folder:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(10, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(620, 22);
            textBox1.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(10, 30);
            label14.Name = "label14";
            label14.Size = new Size(140, 21);
            label14.TabIndex = 0;
            label14.Text = "Grasscutter Folder:";
            // 
            // linkDiscord
            // 
            linkDiscord.AutoSize = true;
            linkDiscord.Dock = DockStyle.Right;
            linkDiscord.Location = new Point(673, 0);
            linkDiscord.Name = "linkDiscord";
            linkDiscord.Size = new Size(47, 15);
            linkDiscord.TabIndex = 13;
            linkDiscord.TabStop = true;
            linkDiscord.Text = "Discord";
            linkDiscord.LinkClicked += LinkDiscordLinkClicked;
            // 
            // linkGithub
            // 
            linkGithub.AutoSize = true;
            linkGithub.Dock = DockStyle.Right;
            linkGithub.Location = new Point(630, 0);
            linkGithub.Name = "linkGithub";
            linkGithub.Size = new Size(43, 15);
            linkGithub.TabIndex = 14;
            linkGithub.TabStop = true;
            linkGithub.Text = "Github";
            linkGithub.LinkClicked += LinkGithubLinkClicked;
            // 
            // linkWeb
            // 
            linkWeb.AutoSize = true;
            linkWeb.Dock = DockStyle.Right;
            linkWeb.Location = new Point(599, 0);
            linkWeb.Name = "linkWeb";
            linkWeb.Size = new Size(31, 15);
            linkWeb.TabIndex = 15;
            linkWeb.TabStop = true;
            linkWeb.Text = "Web";
            linkWeb.LinkClicked += LinkWebLinkClicked;
            // 
            // CheckGameRun
            // 
            CheckGameRun.Enabled = true;
            CheckGameRun.Interval = 1000;
            CheckGameRun.Tick += CheckGameRun_Tick;
            // 
            // CheckProxyRun
            // 
            CheckProxyRun.Enabled = true;
            CheckProxyRun.Interval = 1000;
            CheckProxyRun.Tick += CheckProxyRunTick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 396);
            Controls.Add(linkWeb);
            Controls.Add(linkGithub);
            Controls.Add(linkDiscord);
            Controls.Add(TabMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            Text = "YuukiPS Launcher";
            FormClosing += MainFormClosing;
            Load += Main_Load;
            TabMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            grConfigGameLite.ResumeLayout(false);
            grConfigGameLite.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            grProfile.ResumeLayout(false);
            grProfile.PerformLayout();
            grExtra.ResumeLayout(false);
            grExtra.PerformLayout();
            grProxy.ResumeLayout(false);
            grProxy.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage10.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            tabPage11.ResumeLayout(false);
            tabPage11.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btStartNormal;
        private TextBox GetServerHost;
        private Label label2;
        private TextBox GetProxyPort;
        private TabControl TabMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button Server_Start;
        private GroupBox grProxy;
        private CheckBox CheckProxyEnable;
        private Label SetVersion;
        private Label stIsRunProxy;
        private LinkLabel linkDiscord;
        private LinkLabel linkGithub;
        private LinkLabel linkWeb;
        private GroupBox grExtra;
        private CheckBox ExtraCheat;
        private CheckBox Enable_RPC;
        private TextBox Set_LA_GameFolder;
        private Label label5;
        private Button btsave;
        private GroupBox groupBox3;
        private Label Get_LA_MD5;
        private Label Get_LA_REL;
        private Label Get_LA_CH;
        private Label Get_LA_Version;
        private Button Set_LA_Select;
        private System.Windows.Forms.Timer CheckGameRun;
        private System.Windows.Forms.Timer CheckProxyRun;
        private Label label8;
        private Button Server_Config_OpenFolder;
        private ComboBox comboBox1;
        private GroupBox groupBox4;
        private Button Server_DL_JAVA;
        private Button Server_DL_DB;
        private GroupBox groupBox5;
        private Button Server_DL_GC;
        private GroupBox groupBox6;
        private Button Server_DL_RES;
        private ComboBox comboBox2;
        private TabControl tabControl2;
        private TabPage tabPage10;
        private TabPage tabPage11;
        private TextBox textBox4;
        private Label label17;
        private TextBox textBox3;
        private Label label16;
        private Button button1;
        private TextBox textBox2;
        private Label label15;
        private TextBox textBox1;
        private Label label14;
        private Button btStartOfficialServer;
        private ComboBox GetTypeGame;
        private GroupBox grProfile;
        private ComboBox GetProfileServer;
        private Button btload;
        private GroupBox groupBox8;
        private GroupBox grConfigGameLite;
        private Button btStartYuukiServer;
        private CheckBox EnableSendLog;
        private CheckBox Enable_WipeLoginCache;
    }
}