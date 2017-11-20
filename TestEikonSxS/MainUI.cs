using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EikonSxSClassLibrary;
using Newtonsoft.Json;
using WebSocket4Net;
using SuperSocket.ClientEngine;
using System.Timers;


namespace TestEikonSxS
{
    public partial class MainUI : Form
    {

        EikonSxS eikon = new EikonSxS();
        BindingSource bndEikonApps = new BindingSource();

        WebSocket websocket;

        System.Timers.Timer timeShowFeedback = new System.Timers.Timer(1000);


        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string text);




        public MainUI()
        {
            InitializeComponent();
            
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            // Load settings from Properties
            numPort.Value = Properties.Settings.Default.Port;            
            chbAutoHandshake.Checked = Properties.Settings.Default.IsAutoHandshake;
            chbAutoWSConnect.Checked = Properties.Settings.Default.IsAutoWSConnect;
            txbProductID.Text = Properties.Settings.Default.ProductID;
            txbAPIKey.Text = Properties.Settings.Default.APIKey;

            txbPingResponse.Text = "";
            txbURLPing.Text = string.Format("http://127.0.0.1:{0}/ping", numPort.Value);            
            lblResult.Text = "";
                        
            txbURLHandshake.Text = string.Format("http://127.0.0.1:{0}/sxs/v1", numPort.Value);            
            txbURLWS.Text = string.Format("ws://localhost:{0}/sxs/v1/notifications?sessionToken=", numPort.Value);


            lblHandshakeResult.Text = "click SEND button";
                        
            cmbAppName.Text = "Quote";

            bndEikonApps.DataSource = eikon.EIKONAPP;
            dgvAppList.DataSource = bndEikonApps;            
            dgvAppList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAppList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;           
            
                                   
            btnModifyContext.Enabled = false;

            // If auto Handshake or Or create Websocket, do it
            if (chbAutoHandshake.Checked) {
                btnHandshake_Click(this, new EventArgs());
            }

            if (chbAutoWSConnect.Checked)
            {
                btnWSConnect_Click(this, new EventArgs());
            }

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
       
            eikon.URL_PING = txbURLPing.Text;
            txbPingResponse.Text = eikon.DoPingTest();

            try
            {
                int nResultPort = int.Parse(txbPingResponse.Text);

                if (nResultPort == eikon.PORT)
                {
                    lblResult.Text = "SUCCESS at port " + txbPingResponse.Text;
                    eikon.ISVALIDPORT = true;

                } else
                {
                    lblResult.Text = "FAILED";        
                    

                }

            }
            catch (Exception)
            {

                lblResult.Text = "FAILED";
            }                  
                        

        }


        private void DebugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                /*txbDebug.Text = txbDebug.Text + strDebugText + Environment.NewLine;
                txbDebug.SelectionStart = txbDebug.TextLength;
                txbDebug.ScrollToCaret();*/
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }

        }

        private void btnHandshake_Click(object sender, EventArgs e)
        {  

            string strResponse = "";
            string strPostData = "";

            eikon.PRODUCT_ID = txbProductID.Text;
            eikon.APIKEY = txbAPIKey.Text;
            eikon.URL_SXS = txbURLHandshake.Text;
            strResponse = eikon.DoHandshake(out strPostData);

            txbHandshakePOST.Text = strPostData;
            txbHandshakeResponse.Text = strResponse;

            if (eikon.ISHANDSHAKESUCCESS)
            {
                txbSessionToken.Text = eikon.SESSIONTOKEN;
                //txbURLWS.Text = @"ws://localhost:9000/sxs/v1/notifications?sessionToken=" + eikon.SESSIONTOKEN;
                txbURLWS.Text = txbURLWS.Text + eikon.SESSIONTOKEN;
                lblHandshakeResult.Text = "SUCCESS";
                lblHandshakeResultMainUI.Text = "SUCCESS at port " + eikon.PORT +" - Ready to launch Eikon Apps";          

            }
            else
            {
                txbSessionToken.Text = "";
                lblHandshakeResult.Text = "FAILED";
                lblHandshakeResultMainUI.Text = "FAILED - please click Send Hanshake button, or go to Config Page";
            }    
        }



        private void btnLaunchApp_Click(object sender, EventArgs e)
        {
            string strPostData = "";

            List<string> context = new List<string>();

            // Create list of Rics to launch along with Eikon App
            foreach (string str in lsbContext.Items)
            {
                context.Add(str);
            }
                
            txbResponse.Text = eikon.DoLaunchApp(cmbAppName.Text, context, out strPostData);
            //txbLaunchAppResponse.Text = eikon.DoLaunchApp(cmbAppName.Text);
            txbPostData.Text = strPostData;


            DebugOutput(lsbContext.Items.ToString());

            bndEikonApps.ResetBindings(false);

        }

        private void btnWSConnect_Click(object sender, EventArgs e)
        {
            
            websocket = new WebSocket(txbURLWS.Text);

            websocket.Opened += new EventHandler(websocket_Opened);
            websocket.Closed += new EventHandler(websocket_Closed);
            //websocket.Error += new EventHandler<ErrorEventArgs>(websocket_Error);
            websocket.Error += new EventHandler<ErrorEventArgs>(websocket_Error);
            websocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(websocket_MessageReceived);


            DebugOutput(websocket.State.ToString());
            
            websocket.Open();
        }


        private void btnWSDisconnect_Click(object sender, EventArgs e)
        {
            //DebugOutput(websocket.State.ToString());

            if ((websocket != null) && (websocket.State == WebSocketState.Open)){
                websocket.Close();
            }
            
        }


        private void websocket_Opened(object sender, EventArgs e)
        {
            //DebugOutput(Environment.NewLine + "WEB SOCKET OPENED, sender = " + sender.ToString() + " Event = " + e.ToString() + Environment.NewLine);

            this.ProcessMessageReceived("WEB SOCKET OPENED");
            //websocket.Send("Hello World!");
        }

        private void ProcessMessageReceived(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            //if (this.txbWSResult.InvokeRequired)
            if (this.lsbWSEvents.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(ProcessMessageReceived);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                
                // Add MessageReceived to the listbox
                lsbWSEvents.Items.Add(text);


                // Set Label to show the current Websocket State
                if (websocket != null)
                {

                    if (websocket.State == WebSocketState.Open)
                    {
                        lblWSState.Text = "CONNECTED";
                        lblWSStateMainUI.Text = "CONNECTED - ready for Linking / Exchange Context";
                    }
                    else if (websocket.State == WebSocketState.Closed)
                    {
                        // Socket state changed to Closed, Reset All the Link states to Unlinked in all Eikon Apps
                        eikon.ResetLinkState();
                        lblWSState.Text = "DISCONNECTED";
                        lblWSStateMainUI.Text = "DISCONNECTED - please click Connect button, or go to Config Page";
                    }
                    else if (websocket.State == WebSocketState.Connecting)
                    {
                        lblWSState.Text = "CONNECTING";
                        //lblWSStateMainUI.Text = "CONNECTING";
                    }
                    else lblWSState.Text = "UNKNOWN";                            

                }

                // Process JSON Message Received
                string strResult = "";

                strResult = eikon.ProcessIncomingWSMessage(text);

                // Show message in WebSoct Event box
                //if (!string.IsNullOrEmpty(strResult))
                  //  lsbWSEvents.Items.Add(strResult);

                lsbWSEvents.SelectedIndex = lsbWSEvents.Items.Count - 1;

                // if message = show / hide Link,  change background color
                if (string.Equals(strResult, "showFeedbackForLinking"))
                {                    
                    this.BackColor = Color.DarkKhaki;
                } else {
                    // reset back color
                    this.BackColor = Color.Empty;
                }


                bndEikonApps.ResetBindings(false);
            }
        }


        private void websocket_Closed(object sender, EventArgs e)
        {
            this.ProcessMessageReceived("WEB SOCKET CLOSED");
            //DebugOutput(Environment.NewLine + "WEB SOCKET CLOSED"+ Environment.NewLine);
        }

        private void websocket_MessageReceived(object sender, EventArgs e)
        {
            MessageReceivedEventArgs msg = (MessageReceivedEventArgs)e;

            //DebugOutput(Environment.NewLine + "WEB SOCKET MESSAGE RECEIVED: " + sender.ToString() + " : " + e.ToString() + Environment.NewLine);            
            //this.SetText("WS MESSAGE RECEIEVED, sender = " + sender.ToString() + " , e = " + a.Message);
            this.ProcessMessageReceived(msg.Message);          



        }

        private void websocket_Error(object sender, EventArgs e)
        {
            ErrorEventArgs error = (ErrorEventArgs)e;
            //DebugOutput(Environment.NewLine + "WEB SOCKET ERROR " + Environment.NewLine);
            this.ProcessMessageReceived("WS ERROR :  " + error.Exception.Message.ToString());

        }

        private void btnAddContext_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbAddContext.Text.Trim()))
            {

                lsbContext.Items.Add(cmbAddContext.Text);

                cmbAddContext.Text = "";
            }

        }

        private void btnClearContext_Click(object sender, EventArgs e)
        {
            lsbContext.Items.Clear();
        }

        private void btnDelContext_Click(object sender, EventArgs e)
        {
            lsbContext.Items.Remove(lsbContext.SelectedItem);
        }

      

        private void lsbContext_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {                
                btnDelContext_Click(sender, e);
            }
            
        }

        private void cmbAddContext_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddContext_Click(sender, e);
            }
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            string strPostData = "";
            string strResponse = "";

            // Scroll through datagridview and perform link on each selected rows
            foreach (DataGridViewRow item in dgvAppList.SelectedRows)
            {
                EikonApp myApp = (EikonApp)item.DataBoundItem;

                strResponse = eikon.BroadcastApp(linkMethod.BROADCAST, myApp, out strPostData);

                txbPostData.Text = strPostData;
                txbResponse.Text = strResponse;
                
            }

            bndEikonApps.ResetBindings(false);
            
            // Enable  New Ric Broadcast button, as we assume when user click this Link button , he does set Broadcast at least 1 time
            btnModifyContext.Enabled = true;
        }

        private void btnUnLink_Click(object sender, EventArgs e)
        {
            string strPostData = "";
            string strResponse = "";

            // Scroll through datagridview and perform ulink on each selected rows
            foreach (DataGridViewRow item in dgvAppList.SelectedRows)
            {
                EikonApp myApp = (EikonApp)item.DataBoundItem;

                strResponse = eikon.BroadcastApp(linkMethod.STOPBROADCAST, myApp, out strPostData);

                txbPostData.Text = strPostData;
                txbResponse.Text = strResponse;
            }

            bndEikonApps.ResetBindings(false);
        }

        private void btnModifyContext_Click(object sender, EventArgs e)
        {
            string strPostData = "";
            string strResponse = "";

            // just Broadcast Ric if user enter a Ric in Textbox
            if (!string.IsNullOrEmpty(txbNewContext.Text)) {

                strResponse = eikon.DoChangeContext(txbNewContext.Text, out strPostData);

                txbPostData.Text = strPostData;
                txbResponse.Text = strResponse;

            } 

            // Update UI
            bndEikonApps.ResetBindings(false);
        }

        private void txbNewContext_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnModifyContext_Click(sender, e);
            }
        }

        private void dgvAppList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DebugOutput("Cell Content DBL CLICKED");
            EikonApp myApp;

            // Double click content in the Cell,  show Feedback on Linked object on Eikon App
            // Scroll through datagridview and perform ulink on each selected rows
            foreach (DataGridViewRow item in dgvAppList.SelectedRows)
            {
                myApp = (EikonApp)item.DataBoundItem;

                // Found our selected App, if this App Broadcasts to Eikon App, Perform ShowLinkingApp Highlight 
                if (myApp.BROADCASTTO == true)
                {
                    //eikon.Do
                    string strPostData = "";
                    string strResponse = "";

                    strResponse = eikon.DoShowFeedbackForLinking(showFeedbackMethod.SHOW, myApp.INSTANCEID, out strPostData);

                    txbResponse.Text = strResponse;
                    txbPostData.Text = strPostData;

                    // Start timer , when timer reached -> Hide Feedback to this Instance ID                    
                    timeShowFeedback.Elapsed += delegate { MyElapsedMethod(myApp.INSTANCEID); };
                    // Hook up the Elapsed event for the timer. 
                    timeShowFeedback.AutoReset = true;
                    timeShowFeedback.Enabled = true;

                }

            }
        }

        void MyElapsedMethod(string strInstanceId)
        {

            //DebugOutput("TIMER 2000 REACHED");

            // Timer reached,  hide feed back for Linking
            string strPostData = "";
            //string strResponse = "";

            timeShowFeedback.Enabled = false;
            eikon.DoShowFeedbackForLinking(showFeedbackMethod.HIDE, strInstanceId, out strPostData);

            //txbResponse.Text = strResponse;
            //txbPostData.Text = strPostData;

        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show(
@"Save the following configuration?

Port Number
Product ID & API Key
Auto Handshake when startup
Auto Connect WebSocket when startup",
                                     "Save Confirmation",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes' is selected, Save the Configuration
                // Save values to Properties Settings
                Properties.Settings.Default.Port = numPort.Value;                
                Properties.Settings.Default.IsAutoHandshake = chbAutoHandshake.Checked;
                Properties.Settings.Default.IsAutoWSConnect = chbAutoWSConnect.Checked;
                Properties.Settings.Default.ProductID = txbProductID.Text;
                Properties.Settings.Default.APIKey = txbAPIKey.Text;

                Properties.Settings.Default.Save();
                
            }
        }

        private void btnResetConfig_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Reset configuration to the following?\n\nPort Number = 9000\nProduct ID & API Key = <blank>\nAuto Handshake when startup: No\nAuto Connect WebSocket when startup:No",
                                     "Save Confirmation",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes' is selected, Reset the Perperties Settings to its original value
                Properties.Settings.Default.Reset();
                MainUI_Load(sender, e);
            }
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            txbURLPing.Text = string.Format("http://127.0.0.1:{0}/ping", numPort.Value);
            txbURLHandshake.Text = string.Format("http://127.0.0.1:{0}/sxs/v1", numPort.Value);            
            txbURLWS.Text = string.Format("ws://localhost:{0}/sxs/v1/notifications?sessionToken=", numPort.Value);
        }
    }
}
