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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbResponse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txbDebug = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbHandshakeURL = new System.Windows.Forms.TextBox();
            this.btnHandshake = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbHandshakeResponse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.txbLaunchAppResponse = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvAppList = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnWSConnect = new System.Windows.Forms.Button();
            this.txbWSURL = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step 1 : Test Connection to Eikon SxS server - send HTTP GET request to local hos" +
    "t port 9000";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(432, 37);
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
            this.label2.Location = new System.Drawing.Point(36, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL:";
            // 
            // txbURL
            // 
            this.txbURL.Location = new System.Drawing.Point(95, 38);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(331, 20);
            this.txbURL.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Response: ";
            // 
            // txbResponse
            // 
            this.txbResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbResponse.Location = new System.Drawing.Point(587, 38);
            this.txbResponse.Name = "txbResponse";
            this.txbResponse.ReadOnly = true;
            this.txbResponse.Size = new System.Drawing.Size(330, 20);
            this.txbResponse.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Result:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(92, 65);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(185, 16);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "<result>/PASSED/FAILED";
            // 
            // txbDebug
            // 
            this.txbDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDebug.Location = new System.Drawing.Point(32, 956);
            this.txbDebug.Multiline = true;
            this.txbDebug.Name = "txbDebug";
            this.txbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDebug.Size = new System.Drawing.Size(886, 81);
            this.txbDebug.TabIndex = 8;
            this.txbDebug.Text = "DEBUG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Handshake URL";
            // 
            // txbHandshakeURL
            // 
            this.txbHandshakeURL.Location = new System.Drawing.Point(95, 149);
            this.txbHandshakeURL.Name = "txbHandshakeURL";
            this.txbHandshakeURL.Size = new System.Drawing.Size(331, 20);
            this.txbHandshakeURL.TabIndex = 10;
            // 
            // btnHandshake
            // 
            this.btnHandshake.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHandshake.Location = new System.Drawing.Point(433, 149);
            this.btnHandshake.Name = "btnHandshake";
            this.btnHandshake.Size = new System.Drawing.Size(75, 23);
            this.btnHandshake.TabIndex = 11;
            this.btnHandshake.Text = "Send";
            this.btnHandshake.UseVisualStyleBackColor = true;
            this.btnHandshake.Click += new System.EventHandler(this.btnHandshake_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Response: ";
            // 
            // txbHandshakeResponse
            // 
            this.txbHandshakeResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbHandshakeResponse.Location = new System.Drawing.Point(95, 178);
            this.txbHandshakeResponse.Multiline = true;
            this.txbHandshakeResponse.Name = "txbHandshakeResponse";
            this.txbHandshakeResponse.Size = new System.Drawing.Size(822, 83);
            this.txbHandshakeResponse.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Step 2 : Send HTTP POST request for Handshake";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Product ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(450, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "API Key:";
            // 
            // txbProductID
            // 
            this.txbProductID.Location = new System.Drawing.Point(95, 123);
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.Size = new System.Drawing.Size(329, 20);
            this.txbProductID.TabIndex = 15;
            // 
            // txbAPIKey
            // 
            this.txbAPIKey.Location = new System.Drawing.Point(504, 123);
            this.txbAPIKey.Name = "txbAPIKey";
            this.txbAPIKey.Size = new System.Drawing.Size(277, 20);
            this.txbAPIKey.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Session Token: ";
            // 
            // txbSessionToken
            // 
            this.txbSessionToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSessionToken.Location = new System.Drawing.Point(331, 272);
            this.txbSessionToken.Name = "txbSessionToken";
            this.txbSessionToken.Size = new System.Drawing.Size(586, 20);
            this.txbSessionToken.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Handshake Result:";
            // 
            // lblHandshakeResult
            // 
            this.lblHandshakeResult.AutoSize = true;
            this.lblHandshakeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandshakeResult.Location = new System.Drawing.Point(106, 275);
            this.lblHandshakeResult.Name = "lblHandshakeResult";
            this.lblHandshakeResult.Size = new System.Drawing.Size(113, 13);
            this.lblHandshakeResult.TabIndex = 20;
            this.lblHandshakeResult.Text = "SUCCESS/FAILED";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Steps 4 - Launch App:";
            // 
            // btnLaunchApp
            // 
            this.btnLaunchApp.Location = new System.Drawing.Point(432, 310);
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
            this.label13.Location = new System.Drawing.Point(437, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Response :";
            // 
            // txbLaunchAppResponse
            // 
            this.txbLaunchAppResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbLaunchAppResponse.Location = new System.Drawing.Point(433, 364);
            this.txbLaunchAppResponse.Multiline = true;
            this.txbLaunchAppResponse.Name = "txbLaunchAppResponse";
            this.txbLaunchAppResponse.Size = new System.Drawing.Size(474, 83);
            this.txbLaunchAppResponse.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 546);
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
            this.dgvAppList.Location = new System.Drawing.Point(31, 570);
            this.dgvAppList.MultiSelect = false;
            this.dgvAppList.Name = "dgvAppList";
            this.dgvAppList.ReadOnly = true;
            this.dgvAppList.Size = new System.Drawing.Size(716, 186);
            this.dgvAppList.TabIndex = 27;
            this.dgvAppList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppList_CellContentDoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 480);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(272, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Step 3 (Optional) create WebSocket for Linking context:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 508);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Websocket URL: ";
            // 
            // btnWSConnect
            // 
            this.btnWSConnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnWSConnect.Location = new System.Drawing.Point(516, 508);
            this.btnWSConnect.Name = "btnWSConnect";
            this.btnWSConnect.Size = new System.Drawing.Size(75, 23);
            this.btnWSConnect.TabIndex = 31;
            this.btnWSConnect.Text = "Connect";
            this.btnWSConnect.UseVisualStyleBackColor = true;
            this.btnWSConnect.Click += new System.EventHandler(this.btnWSConnect_Click);
            // 
            // txbWSURL
            // 
            this.txbWSURL.Location = new System.Drawing.Point(129, 508);
            this.txbWSURL.Name = "txbWSURL";
            this.txbWSURL.Size = new System.Drawing.Size(373, 20);
            this.txbWSURL.TabIndex = 30;
            // 
            // btnWSDisconnect
            // 
            this.btnWSDisconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnWSDisconnect.Location = new System.Drawing.Point(597, 508);
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
            this.label17.Location = new System.Drawing.Point(450, 774);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Websocket Events:";
            // 
            // lsbWSEvents
            // 
            this.lsbWSEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbWSEvents.FormattingEnabled = true;
            this.lsbWSEvents.HorizontalScrollbar = true;
            this.lsbWSEvents.Location = new System.Drawing.Point(453, 790);
            this.lsbWSEvents.Name = "lsbWSEvents";
            this.lsbWSEvents.ScrollAlwaysVisible = true;
            this.lsbWSEvents.Size = new System.Drawing.Size(465, 160);
            this.lsbWSEvents.TabIndex = 34;
            // 
            // cmbAppName
            // 
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
            this.cmbAppName.Location = new System.Drawing.Point(129, 310);
            this.cmbAppName.Name = "cmbAppName";
            this.cmbAppName.Size = new System.Drawing.Size(278, 21);
            this.cmbAppName.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(73, 342);
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
            this.lsbContext.Location = new System.Drawing.Point(129, 364);
            this.lsbContext.Name = "lsbContext";
            this.lsbContext.Size = new System.Drawing.Size(278, 82);
            this.lsbContext.TabIndex = 37;
            this.lsbContext.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lsbContext_KeyUp);
            // 
            // btnAddContext
            // 
            this.btnAddContext.Location = new System.Drawing.Point(331, 337);
            this.btnAddContext.Name = "btnAddContext";
            this.btnAddContext.Size = new System.Drawing.Size(75, 23);
            this.btnAddContext.TabIndex = 39;
            this.btnAddContext.Text = "Add";
            this.btnAddContext.UseVisualStyleBackColor = true;
            this.btnAddContext.Click += new System.EventHandler(this.btnAddContext_Click);
            // 
            // btnDelContext
            // 
            this.btnDelContext.Location = new System.Drawing.Point(250, 452);
            this.btnDelContext.Name = "btnDelContext";
            this.btnDelContext.Size = new System.Drawing.Size(75, 23);
            this.btnDelContext.TabIndex = 40;
            this.btnDelContext.Text = "Delete";
            this.btnDelContext.UseVisualStyleBackColor = true;
            this.btnDelContext.Click += new System.EventHandler(this.btnDelContext_Click);
            // 
            // btnClearContext
            // 
            this.btnClearContext.Location = new System.Drawing.Point(332, 452);
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
            this.cmbAddContext.Location = new System.Drawing.Point(129, 337);
            this.cmbAddContext.Name = "cmbAddContext";
            this.cmbAddContext.Size = new System.Drawing.Size(196, 21);
            this.cmbAddContext.TabIndex = 42;
            this.cmbAddContext.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbAddContext_KeyUp);
            // 
            // btnBroadcast
            // 
            this.btnBroadcast.Location = new System.Drawing.Point(814, 570);
            this.btnBroadcast.Name = "btnBroadcast";
            this.btnBroadcast.Size = new System.Drawing.Size(93, 28);
            this.btnBroadcast.TabIndex = 43;
            this.btnBroadcast.Text = "Set Broadcast";
            this.btnBroadcast.UseVisualStyleBackColor = true;
            this.btnBroadcast.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnStopBroadcast
            // 
            this.btnStopBroadcast.Location = new System.Drawing.Point(814, 604);
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
            this.label19.Location = new System.Drawing.Point(706, 513);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Current State: ";
            // 
            // lblWSState
            // 
            this.lblWSState.AutoSize = true;
            this.lblWSState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWSState.Location = new System.Drawing.Point(780, 511);
            this.lblWSState.Name = "lblWSState";
            this.lblWSState.Size = new System.Drawing.Size(127, 16);
            this.lblWSState.TabIndex = 46;
            this.lblWSState.Text = "DISCONNECTED";
            // 
            // btnModifyContext
            // 
            this.btnModifyContext.Location = new System.Drawing.Point(814, 733);
            this.btnModifyContext.Name = "btnModifyContext";
            this.btnModifyContext.Size = new System.Drawing.Size(93, 23);
            this.btnModifyContext.TabIndex = 47;
            this.btnModifyContext.Text = "Modify RIC";
            this.btnModifyContext.UseVisualStyleBackColor = true;
            this.btnModifyContext.Click += new System.EventHandler(this.btnModifyContext_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(796, 691);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 13);
            this.label20.TabIndex = 48;
            this.label20.Text = "New Ric to Broadcast";
            // 
            // txbNewContext
            // 
            this.txbNewContext.Location = new System.Drawing.Point(799, 707);
            this.txbNewContext.Name = "txbNewContext";
            this.txbNewContext.Size = new System.Drawing.Size(108, 20);
            this.txbNewContext.TabIndex = 49;
            this.txbNewContext.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbNewContext_KeyUp);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 1049);
            this.Controls.Add(this.txbNewContext);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnModifyContext);
            this.Controls.Add(this.lblWSState);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnStopBroadcast);
            this.Controls.Add(this.btnBroadcast);
            this.Controls.Add(this.cmbAddContext);
            this.Controls.Add(this.btnClearContext);
            this.Controls.Add(this.btnDelContext);
            this.Controls.Add(this.btnAddContext);
            this.Controls.Add(this.lsbContext);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbAppName);
            this.Controls.Add(this.lsbWSEvents);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnWSDisconnect);
            this.Controls.Add(this.btnWSConnect);
            this.Controls.Add(this.txbWSURL);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvAppList);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txbLaunchAppResponse);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnLaunchApp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblHandshakeResult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbSessionToken);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbAPIKey);
            this.Controls.Add(this.txbProductID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbHandshakeResponse);
            this.Controls.Add(this.btnHandshake);
            this.Controls.Add(this.txbHandshakeURL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDebug);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbResponse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label1);
            this.Name = "MainUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MooMoo Test Eikon Side by Side API";
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbResponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txbDebug;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbHandshakeURL;
        private System.Windows.Forms.Button btnHandshake;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbHandshakeResponse;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.TextBox txbLaunchAppResponse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvAppList;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnWSConnect;
        private System.Windows.Forms.TextBox txbWSURL;
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
    }
}

