namespace TestEikonSxS
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.txbURLHandshake = new System.Windows.Forms.TextBox();
            this.btnHandshake = new System.Windows.Forms.Button();
            this.txbHandshakeResponse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.txbAPIKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSessionToken = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHandshakeResult = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLaunchApp = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txbResponse = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvAppList = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.btnWSConnect = new System.Windows.Forms.Button();
            this.txbURLWS = new System.Windows.Forms.TextBox();
            this.btnWSDisconnect = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lsbWSEvents = new System.Windows.Forms.ListBox();
            this.cmbAppName = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lsbContext = new System.Windows.Forms.ListBox();
            this.btnAddContext = new System.Windows.Forms.Button();
            this.btnDelContext = new System.Windows.Forms.Button();
            this.btnClearContext = new System.Windows.Forms.Button();
            this.cmbAddContext = new System.Windows.Forms.ComboBox();
            this.btnBroadcast = new System.Windows.Forms.Button();
            this.btnStopBroadcast = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.lblWSState = new System.Windows.Forms.Label();
            this.btnModifyContext = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txbNewContext = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbURLPing = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPingResponse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.txbPostData = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblWSStateMainUI = new System.Windows.Forms.Label();
            this.lblHandshakeResultMainUI = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnWSConnectMainUI = new System.Windows.Forms.Button();
            this.btnHandshakeMainUI = new System.Windows.Forms.Button();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbAutoWSConnect = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.chbAutoHandshake = new System.Windows.Forms.CheckBox();
            this.txbHandshakePOST = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Handshake URL";
            // 
            // txbURLHandshake
            // 
            this.txbURLHandshake.Location = new System.Drawing.Point(111, 41);
            this.txbURLHandshake.Name = "txbURLHandshake";
            this.txbURLHandshake.Size = new System.Drawing.Size(268, 20);
            this.txbURLHandshake.TabIndex = 10;
            // 
            // btnHandshake
            // 
            this.btnHandshake.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHandshake.Location = new System.Drawing.Point(385, 41);
            this.btnHandshake.Name = "btnHandshake";
            this.btnHandshake.Size = new System.Drawing.Size(75, 23);
            this.btnHandshake.TabIndex = 11;
            this.btnHandshake.Text = "Send";
            this.btnHandshake.UseVisualStyleBackColor = true;
            this.btnHandshake.Click += new System.EventHandler(this.btnHandshake_Click);
            // 
            // txbHandshakeResponse
            // 
            this.txbHandshakeResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbHandshakeResponse.Location = new System.Drawing.Point(409, 88);
            this.txbHandshakeResponse.Multiline = true;
            this.txbHandshakeResponse.Name = "txbHandshakeResponse";
            this.txbHandshakeResponse.ReadOnly = true;
            this.txbHandshakeResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbHandshakeResponse.Size = new System.Drawing.Size(375, 80);
            this.txbHandshakeResponse.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Product ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(406, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "API Key:";
            // 
            // txbProductID
            // 
            this.txbProductID.Location = new System.Drawing.Point(111, 15);
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.Size = new System.Drawing.Size(268, 20);
            this.txbProductID.TabIndex = 15;
            // 
            // txbAPIKey
            // 
            this.txbAPIKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAPIKey.Location = new System.Drawing.Point(460, 15);
            this.txbAPIKey.Name = "txbAPIKey";
            this.txbAPIKey.Size = new System.Drawing.Size(324, 20);
            this.txbAPIKey.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Session Token: ";
            // 
            // txbSessionToken
            // 
            this.txbSessionToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSessionToken.Location = new System.Drawing.Point(409, 174);
            this.txbSessionToken.Name = "txbSessionToken";
            this.txbSessionToken.ReadOnly = true;
            this.txbSessionToken.Size = new System.Drawing.Size(375, 20);
            this.txbSessionToken.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Handshake Result:";
            // 
            // lblHandshakeResult
            // 
            this.lblHandshakeResult.AutoSize = true;
            this.lblHandshakeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandshakeResult.Location = new System.Drawing.Point(117, 177);
            this.lblHandshakeResult.Name = "lblHandshakeResult";
            this.lblHandshakeResult.Size = new System.Drawing.Size(113, 13);
            this.lblHandshakeResult.TabIndex = 20;
            this.lblHandshakeResult.Text = "SUCCESS/FAILED";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Launch Eikon App:";
            // 
            // btnLaunchApp
            // 
            this.btnLaunchApp.Location = new System.Drawing.Point(282, 102);
            this.btnLaunchApp.Name = "btnLaunchApp";
            this.btnLaunchApp.Size = new System.Drawing.Size(75, 23);
            this.btnLaunchApp.TabIndex = 23;
            this.btnLaunchApp.Text = "Launch";
            this.btnLaunchApp.UseVisualStyleBackColor = true;
            this.btnLaunchApp.Click += new System.EventHandler(this.btnLaunchApp_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(408, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Response :";
            // 
            // txbResponse
            // 
            this.txbResponse.Location = new System.Drawing.Point(411, 287);
            this.txbResponse.Multiline = true;
            this.txbResponse.Name = "txbResponse";
            this.txbResponse.ReadOnly = true;
            this.txbResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbResponse.Size = new System.Drawing.Size(396, 141);
            this.txbResponse.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(360, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "List  of launched Apps:";
            // 
            // dgvAppList
            // 
            this.dgvAppList.AllowUserToAddRows = false;
            this.dgvAppList.AllowUserToDeleteRows = false;
            this.dgvAppList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAppList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppList.Location = new System.Drawing.Point(363, 102);
            this.dgvAppList.MultiSelect = false;
            this.dgvAppList.Name = "dgvAppList";
            this.dgvAppList.ReadOnly = true;
            this.dgvAppList.Size = new System.Drawing.Size(451, 136);
            this.dgvAppList.TabIndex = 27;
            this.dgvAppList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppList_CellContentDoubleClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Websocket URL: ";
            // 
            // btnWSConnect
            // 
            this.btnWSConnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnWSConnect.Location = new System.Drawing.Point(460, 26);
            this.btnWSConnect.Name = "btnWSConnect";
            this.btnWSConnect.Size = new System.Drawing.Size(75, 23);
            this.btnWSConnect.TabIndex = 31;
            this.btnWSConnect.Text = "Connect";
            this.btnWSConnect.UseVisualStyleBackColor = true;
            this.btnWSConnect.Click += new System.EventHandler(this.btnWSConnect_Click);
            // 
            // txbURLWS
            // 
            this.txbURLWS.Location = new System.Drawing.Point(112, 26);
            this.txbURLWS.Name = "txbURLWS";
            this.txbURLWS.Size = new System.Drawing.Size(342, 20);
            this.txbURLWS.TabIndex = 30;
            // 
            // btnWSDisconnect
            // 
            this.btnWSDisconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnWSDisconnect.Location = new System.Drawing.Point(541, 26);
            this.btnWSDisconnect.Name = "btnWSDisconnect";
            this.btnWSDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnWSDisconnect.TabIndex = 32;
            this.btnWSDisconnect.Text = "Disconnect";
            this.btnWSDisconnect.UseVisualStyleBackColor = true;
            this.btnWSDisconnect.Click += new System.EventHandler(this.btnWSDisconnect_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 475);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Websocket Events:";
            // 
            // lsbWSEvents
            // 
            this.lsbWSEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbWSEvents.FormattingEnabled = true;
            this.lsbWSEvents.HorizontalScrollbar = true;
            this.lsbWSEvents.Location = new System.Drawing.Point(16, 491);
            this.lsbWSEvents.Name = "lsbWSEvents";
            this.lsbWSEvents.ScrollAlwaysVisible = true;
            this.lsbWSEvents.Size = new System.Drawing.Size(824, 108);
            this.lsbWSEvents.TabIndex = 34;
            // 
            // cmbAppName
            // 
            this.cmbAppName.DropDownWidth = 350;
            this.cmbAppName.FormattingEnabled = true;
            this.cmbAppName.Items.AddRange(new object[] {
            "Quote",
            "News",
            "KOxMNC",
            "Graph",
            "THOMSONREUTERS.REALTIME.THINMONITOR",
            "APPxINDUSTRY",
            "THOMSONREUTERS.AIM.ROUTINES",
            "APPxCALCOPR",
            "THOMSONREUTERS.CHARTS.SEASONALITYCHART",
            "APPxCALCALLQ",
            "APPxFXPOLLS",
            "APPxCALCBNDC",
            "THOMSONREUTERS.FIXEDINCOME.FI_NIM",
            "TR.IRMI",
            "THOMSONREUTERS.FIXEDINCOME.RATESVIEWS",
            "THOMSONREUTERS.COMPANY.OVERVIEW",
            "APPxCALCTOTALRETURN",
            "APPxCOMPSNAPSHOT",
            "EVzCORPxCORPACTCALENDAR",
            "EVzCORPxEVENTSzEVENTS",
            "EVzCORPxFUNDTALSzQHSTRY",
            "ECONOMIC_MONITOR",
            "EVxAMRxCOMPANYxRESEARCH",
            "APPxPOLLING",
            "APPxASSETxALLOC",
            "GxHOME",
            "TR.PORTFOLIOANDLIST"});
            this.cmbAppName.Location = new System.Drawing.Point(79, 102);
            this.cmbAppName.Name = "cmbAppName";
            this.cmbAppName.Size = new System.Drawing.Size(196, 21);
            this.cmbAppName.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Add RIC: ";
            // 
            // lsbContext
            // 
            this.lsbContext.FormattingEnabled = true;
            this.lsbContext.Items.AddRange(new object[] {
            "EUR="});
            this.lsbContext.Location = new System.Drawing.Point(79, 156);
            this.lsbContext.Name = "lsbContext";
            this.lsbContext.Size = new System.Drawing.Size(278, 82);
            this.lsbContext.TabIndex = 37;
            this.lsbContext.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lsbContext_KeyUp);
            // 
            // btnAddContext
            // 
            this.btnAddContext.Location = new System.Drawing.Point(281, 129);
            this.btnAddContext.Name = "btnAddContext";
            this.btnAddContext.Size = new System.Drawing.Size(75, 23);
            this.btnAddContext.TabIndex = 39;
            this.btnAddContext.Text = "Add";
            this.btnAddContext.UseVisualStyleBackColor = true;
            this.btnAddContext.Click += new System.EventHandler(this.btnAddContext_Click);
            // 
            // btnDelContext
            // 
            this.btnDelContext.Location = new System.Drawing.Point(201, 244);
            this.btnDelContext.Name = "btnDelContext";
            this.btnDelContext.Size = new System.Drawing.Size(75, 23);
            this.btnDelContext.TabIndex = 40;
            this.btnDelContext.Text = "Delete";
            this.btnDelContext.UseVisualStyleBackColor = true;
            this.btnDelContext.Click += new System.EventHandler(this.btnDelContext_Click);
            // 
            // btnClearContext
            // 
            this.btnClearContext.Location = new System.Drawing.Point(282, 244);
            this.btnClearContext.Name = "btnClearContext";
            this.btnClearContext.Size = new System.Drawing.Size(75, 23);
            this.btnClearContext.TabIndex = 41;
            this.btnClearContext.Text = "Clear";
            this.btnClearContext.UseVisualStyleBackColor = true;
            this.btnClearContext.Click += new System.EventHandler(this.btnClearContext_Click);
            // 
            // cmbAddContext
            // 
            this.cmbAddContext.FormattingEnabled = true;
            this.cmbAddContext.Items.AddRange(new object[] {
            "EUR=",
            "GBP=",
            "TRI.N",
            ".SETI",
            "PTT.BK"});
            this.cmbAddContext.Location = new System.Drawing.Point(79, 129);
            this.cmbAddContext.Name = "cmbAddContext";
            this.cmbAddContext.Size = new System.Drawing.Size(196, 21);
            this.cmbAddContext.TabIndex = 42;
            this.cmbAddContext.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbAddContext_KeyUp);
            // 
            // btnBroadcast
            // 
            this.btnBroadcast.Location = new System.Drawing.Point(363, 240);
            this.btnBroadcast.Name = "btnBroadcast";
            this.btnBroadcast.Size = new System.Drawing.Size(93, 28);
            this.btnBroadcast.TabIndex = 43;
            this.btnBroadcast.Text = "Set Broadcast";
            this.btnBroadcast.UseVisualStyleBackColor = true;
            this.btnBroadcast.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnStopBroadcast
            // 
            this.btnStopBroadcast.Location = new System.Drawing.Point(462, 239);
            this.btnStopBroadcast.Name = "btnStopBroadcast";
            this.btnStopBroadcast.Size = new System.Drawing.Size(93, 29);
            this.btnStopBroadcast.TabIndex = 44;
            this.btnStopBroadcast.Text = "Stop Broadcast";
            this.btnStopBroadcast.UseVisualStyleBackColor = true;
            this.btnStopBroadcast.Click += new System.EventHandler(this.btnUnLink_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(37, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Current State: ";
            // 
            // lblWSState
            // 
            this.lblWSState.AutoSize = true;
            this.lblWSState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWSState.Location = new System.Drawing.Point(117, 51);
            this.lblWSState.Name = "lblWSState";
            this.lblWSState.Size = new System.Drawing.Size(127, 16);
            this.lblWSState.TabIndex = 46;
            this.lblWSState.Text = "DISCONNECTED";
            // 
            // btnModifyContext
            // 
            this.btnModifyContext.Location = new System.Drawing.Point(745, 245);
            this.btnModifyContext.Name = "btnModifyContext";
            this.btnModifyContext.Size = new System.Drawing.Size(72, 23);
            this.btnModifyContext.TabIndex = 47;
            this.btnModifyContext.Text = "Modify RIC";
            this.btnModifyContext.UseVisualStyleBackColor = true;
            this.btnModifyContext.Click += new System.EventHandler(this.btnModifyContext_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(570, 249);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 13);
            this.label20.TabIndex = 48;
            this.label20.Text = "New Ric";
            // 
            // txbNewContext
            // 
            this.txbNewContext.Location = new System.Drawing.Point(624, 246);
            this.txbNewContext.Name = "txbNewContext";
            this.txbNewContext.Size = new System.Drawing.Size(115, 20);
            this.txbNewContext.TabIndex = 49;
            this.txbNewContext.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbNewContext_KeyUp);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(412, 23);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL:";
            // 
            // txbURLPing
            // 
            this.txbURLPing.Location = new System.Drawing.Point(170, 25);
            this.txbURLPing.Name = "txbURLPing";
            this.txbURLPing.Size = new System.Drawing.Size(234, 20);
            this.txbURLPing.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Response: ";
            // 
            // txbPingResponse
            // 
            this.txbPingResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPingResponse.Location = new System.Drawing.Point(565, 24);
            this.txbPingResponse.Name = "txbPingResponse";
            this.txbPingResponse.ReadOnly = true;
            this.txbPingResponse.Size = new System.Drawing.Size(222, 20);
            this.txbPingResponse.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Result:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(562, 52);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(185, 16);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "<result>/PASSED/FAILED";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabConfig);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 460);
            this.tabControl1.TabIndex = 50;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabMain.Controls.Add(this.label23);
            this.tabMain.Controls.Add(this.txbPostData);
            this.tabMain.Controls.Add(this.label22);
            this.tabMain.Controls.Add(this.lblWSStateMainUI);
            this.tabMain.Controls.Add(this.lblHandshakeResultMainUI);
            this.tabMain.Controls.Add(this.label21);
            this.tabMain.Controls.Add(this.label15);
            this.tabMain.Controls.Add(this.btnWSConnectMainUI);
            this.tabMain.Controls.Add(this.btnHandshakeMainUI);
            this.tabMain.Controls.Add(this.label12);
            this.tabMain.Controls.Add(this.txbNewContext);
            this.tabMain.Controls.Add(this.btnLaunchApp);
            this.tabMain.Controls.Add(this.label20);
            this.tabMain.Controls.Add(this.label13);
            this.tabMain.Controls.Add(this.btnModifyContext);
            this.tabMain.Controls.Add(this.txbResponse);
            this.tabMain.Controls.Add(this.btnStopBroadcast);
            this.tabMain.Controls.Add(this.cmbAppName);
            this.tabMain.Controls.Add(this.btnBroadcast);
            this.tabMain.Controls.Add(this.label18);
            this.tabMain.Controls.Add(this.cmbAddContext);
            this.tabMain.Controls.Add(this.lsbContext);
            this.tabMain.Controls.Add(this.dgvAppList);
            this.tabMain.Controls.Add(this.label14);
            this.tabMain.Controls.Add(this.btnClearContext);
            this.tabMain.Controls.Add(this.btnAddContext);
            this.tabMain.Controls.Add(this.btnDelContext);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(820, 434);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 271);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 13);
            this.label23.TabIndex = 58;
            this.label23.Text = "POST Data generated:";
            // 
            // txbPostData
            // 
            this.txbPostData.Location = new System.Drawing.Point(13, 287);
            this.txbPostData.Multiline = true;
            this.txbPostData.Name = "txbPostData";
            this.txbPostData.ReadOnly = true;
            this.txbPostData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbPostData.Size = new System.Drawing.Size(392, 141);
            this.txbPostData.TabIndex = 57;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 107);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 56;
            this.label22.Text = "Eikon App:";
            // 
            // lblWSStateMainUI
            // 
            this.lblWSStateMainUI.AutoSize = true;
            this.lblWSStateMainUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWSStateMainUI.Location = new System.Drawing.Point(193, 39);
            this.lblWSStateMainUI.Name = "lblWSStateMainUI";
            this.lblWSStateMainUI.Size = new System.Drawing.Size(480, 16);
            this.lblWSStateMainUI.TabIndex = 55;
            this.lblWSStateMainUI.Text = "DISCONNECTED - please click Connect button, or go to Config Page";
            // 
            // lblHandshakeResultMainUI
            // 
            this.lblHandshakeResultMainUI.AutoSize = true;
            this.lblHandshakeResultMainUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandshakeResultMainUI.Location = new System.Drawing.Point(193, 9);
            this.lblHandshakeResultMainUI.Name = "lblHandshakeResultMainUI";
            this.lblHandshakeResultMainUI.Size = new System.Drawing.Size(534, 16);
            this.lblHandshakeResultMainUI.TabIndex = 54;
            this.lblHandshakeResultMainUI.Text = "DISCONNECTED - please click Send Hanshake button, or go to Config Page";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(144, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 53;
            this.label21.Text = "Status: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(144, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Status: ";
            // 
            // btnWSConnectMainUI
            // 
            this.btnWSConnectMainUI.Location = new System.Drawing.Point(13, 36);
            this.btnWSConnectMainUI.Name = "btnWSConnectMainUI";
            this.btnWSConnectMainUI.Size = new System.Drawing.Size(125, 23);
            this.btnWSConnectMainUI.TabIndex = 51;
            this.btnWSConnectMainUI.Text = "Connect WebSocket";
            this.btnWSConnectMainUI.UseVisualStyleBackColor = true;
            this.btnWSConnectMainUI.Click += new System.EventHandler(this.btnWSConnect_Click);
            // 
            // btnHandshakeMainUI
            // 
            this.btnHandshakeMainUI.Location = new System.Drawing.Point(13, 6);
            this.btnHandshakeMainUI.Name = "btnHandshakeMainUI";
            this.btnHandshakeMainUI.Size = new System.Drawing.Size(125, 23);
            this.btnHandshakeMainUI.TabIndex = 50;
            this.btnHandshakeMainUI.Text = "Send Handshake";
            this.btnHandshakeMainUI.UseVisualStyleBackColor = true;
            this.btnHandshakeMainUI.Click += new System.EventHandler(this.btnHandshake_Click);
            // 
            // tabConfig
            // 
            this.tabConfig.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabConfig.Controls.Add(this.btnResetConfig);
            this.tabConfig.Controls.Add(this.btnSaveConfig);
            this.tabConfig.Controls.Add(this.groupBox3);
            this.tabConfig.Controls.Add(this.groupBox2);
            this.tabConfig.Controls.Add(this.groupBox1);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(820, 434);
            this.tabConfig.TabIndex = 1;
            this.tabConfig.Text = "Config";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConfig.Location = new System.Drawing.Point(684, 402);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(127, 26);
            this.btnSaveConfig.TabIndex = 50;
            this.btnSaveConfig.Text = "Save Configuration";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chbAutoWSConnect);
            this.groupBox3.Controls.Add(this.txbURLWS);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btnWSConnect);
            this.groupBox3.Controls.Add(this.lblWSState);
            this.groupBox3.Controls.Add(this.btnWSDisconnect);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(13, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(798, 85);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3 (Optional): establish WebSocket for Linking Context features to work:";
            // 
            // chbAutoWSConnect
            // 
            this.chbAutoWSConnect.AutoSize = true;
            this.chbAutoWSConnect.Location = new System.Drawing.Point(625, 28);
            this.chbAutoWSConnect.Name = "chbAutoWSConnect";
            this.chbAutoWSConnect.Size = new System.Drawing.Size(154, 17);
            this.chbAutoWSConnect.TabIndex = 47;
            this.chbAutoWSConnect.Text = "Auto connect when startup";
            this.chbAutoWSConnect.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.chbAutoHandshake);
            this.groupBox2.Controls.Add(this.txbHandshakePOST);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txbAPIKey);
            this.groupBox2.Controls.Add(this.txbProductID);
            this.groupBox2.Controls.Add(this.txbHandshakeResponse);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txbSessionToken);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnHandshake);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txbURLHandshake);
            this.groupBox2.Controls.Add(this.lblHandshakeResult);
            this.groupBox2.Location = new System.Drawing.Point(13, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 208);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 1: send HTTP POST for Handshake";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(409, 72);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Response :";
            // 
            // chbAutoHandshake
            // 
            this.chbAutoHandshake.AutoSize = true;
            this.chbAutoHandshake.Location = new System.Drawing.Point(562, 45);
            this.chbAutoHandshake.Name = "chbAutoHandshake";
            this.chbAutoHandshake.Size = new System.Drawing.Size(208, 17);
            this.chbAutoHandshake.TabIndex = 21;
            this.chbAutoHandshake.Text = "Auto perform Handshake when startup";
            this.chbAutoHandshake.UseVisualStyleBackColor = true;
            // 
            // txbHandshakePOST
            // 
            this.txbHandshakePOST.Location = new System.Drawing.Point(21, 88);
            this.txbHandshakePOST.Multiline = true;
            this.txbHandshakePOST.Name = "txbHandshakePOST";
            this.txbHandshakePOST.ReadOnly = true;
            this.txbHandshakePOST.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbHandshakePOST.Size = new System.Drawing.Size(358, 80);
            this.txbHandshakePOST.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "POST Data generated:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbURLPing);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbPingResponse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 78);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 0 (optional): Test connection to Eikon SxS server - send HTTP GET to localho" +
    "st port 9000";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(54, 25);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(66, 20);
            this.numPort.TabIndex = 9;
            this.numPort.Value = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.numPort.ValueChanged += new System.EventHandler(this.numPort_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Port: ";
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.Location = new System.Drawing.Point(578, 404);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(100, 23);
            this.btnResetConfig.TabIndex = 51;
            this.btnResetConfig.Text = "Reset Config";
            this.btnResetConfig.UseVisualStyleBackColor = true;
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(852, 619);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lsbWSEvents);
            this.Controls.Add(this.label17);
            this.Name = "MainUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Eikon Side by Side API";
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbURLHandshake;
        private System.Windows.Forms.Button btnHandshake;
        private System.Windows.Forms.TextBox txbHandshakeResponse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.TextBox txbAPIKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSessionToken;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblHandshakeResult;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLaunchApp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbResponse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvAppList;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnWSConnect;
        private System.Windows.Forms.TextBox txbURLWS;
        private System.Windows.Forms.Button btnWSDisconnect;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lsbWSEvents;
        private System.Windows.Forms.ComboBox cmbAppName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox lsbContext;
        private System.Windows.Forms.Button btnAddContext;
        private System.Windows.Forms.Button btnDelContext;
        private System.Windows.Forms.Button btnClearContext;
        private System.Windows.Forms.ComboBox cmbAddContext;
        private System.Windows.Forms.Button btnBroadcast;
        private System.Windows.Forms.Button btnStopBroadcast;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblWSState;
        private System.Windows.Forms.Button btnModifyContext;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txbNewContext;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbURLPing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPingResponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbHandshakePOST;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbAutoHandshake;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.CheckBox chbAutoWSConnect;
        private System.Windows.Forms.Button btnWSConnectMainUI;
        private System.Windows.Forms.Button btnHandshakeMainUI;
        private System.Windows.Forms.Label lblWSStateMainUI;
        private System.Windows.Forms.Label lblHandshakeResultMainUI;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txbPostData;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnResetConfig;
    }
}

