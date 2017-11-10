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


namespace TestEikonSxS
{
    public partial class MainUI : Form
    {

        EikonSxS eikon = new EikonSxS();
        BindingSource bndEikonApps = new BindingSource();

        WebSocket websocket;


        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string text);




        public MainUI()
        {
            InitializeComponent();
            
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            txbResponse.Text = "";
            txbURL.Text = "http://127.0.0.1:9000/ping";            
            lblResult.Text = "";

            txbHandshakeURL.Text = "http://127.0.0.1:9000/sxs/v1";
            txbProductID.Text = "THEWOODBRIDGECOMPANY.CHACHANSXSAPP";
            txbAPIKey.Text = "95f79bb960db4964a00c7f6a1cb5cc674f5c3410";

            lblHandshakeResult.Text = "click SEND button";
                        
            cmbAppName.Text = "Quote";

            bndEikonApps.DataSource = eikon.EIKONAPP;
            dgvAppList.DataSource = bndEikonApps;            
            dgvAppList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAppList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            
            txbWSURL.Text = @"ws://localhost:9000/sxs/v1/notifications?sessionToken=<session token>";

            

            //ws.OnMessage += (test, a) => DebugOutput("Websocket OnMessage: " + a.Data);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
       
            eikon.URL_PING = txbURL.Text;
            txbResponse.Text = eikon.DoPingTest();

            try
            {
                int nResultPort = int.Parse(txbResponse.Text);

                if (nResultPort == eikon.PORT)
                {
                    lblResult.Text = "SUCCESS at port " + txbResponse.Text;

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
                txbDebug.Text = txbDebug.Text + strDebugText + Environment.NewLine;
                txbDebug.SelectionStart = txbDebug.TextLength;
                txbDebug.ScrollToCaret();
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }

        }

        private void btnHandshake_Click(object sender, EventArgs e)
        {  

            string strResponse = "";

            eikon.PRODUCT_ID = txbProductID.Text;
            eikon.APIKEY = txbAPIKey.Text;
            strResponse = eikon.DoHandshake();

            txbHandshakeResponse.Text = strResponse;

            if (eikon.ISHANDSHAKESUCCESS)
            {
                txbSessionToken.Text = eikon.SESSIONTOKEN;
                txbWSURL.Text = @"ws://localhost:9000/sxs/v1/notifications?sessionToken=" + eikon.SESSIONTOKEN;
                lblHandshakeResult.Text = "SUCCESS";
            }
            else
            {
                txbSessionToken.Text = "";
                lblHandshakeResult.Text = "FAILED";
            }    
        }



        private void btnLaunchApp_Click(object sender, EventArgs e)
        {
            List<string> context = new List<string>();

            // Create list of Rics to launch along with Eikon App
            foreach (string str in lsbContext.Items)
            {
                context.Add(str);
            }
                
            txbLaunchAppResponse.Text = eikon.DoLaunchApp(cmbAppName.Text, context);
            //txbLaunchAppResponse.Text = eikon.DoLaunchApp(cmbAppName.Text);

            DebugOutput(lsbContext.Items.ToString());

            bndEikonApps.ResetBindings(false);

        }

        private void btnWSConnect_Click(object sender, EventArgs e)
        {
            
            websocket = new WebSocket(txbWSURL.Text);

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
            websocket.Send("Hello World!");
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
                if (websocket != null){

                    if (websocket.State == WebSocketState.Open)
                        lblWSState.Text = "CONNECTED";
                    else if (websocket.State == WebSocketState.Closed)
                        lblWSState.Text = "DISCONNECTED";
                    else if (websocket.State == WebSocketState.Connecting)
                        lblWSState.Text = "CONECTTING";
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
            // Scroll through datagridview and perform link on each selected rows
            foreach (DataGridViewRow item in dgvAppList.SelectedRows)
            {
                EikonApp myApp = (EikonApp)item.DataBoundItem;

                eikon.BroadcastApp(linkMethod.BROADCAST, myApp);
                
            }

            bndEikonApps.ResetBindings(false);
        }

        private void btnUnLink_Click(object sender, EventArgs e)
        {
            // Scroll through datagridview and perform ulink on each selected rows
            foreach (DataGridViewRow item in dgvAppList.SelectedRows)
            {
                EikonApp myApp = (EikonApp)item.DataBoundItem;

                eikon.BroadcastApp(linkMethod.STOPBROADCAST, myApp);

            }

            bndEikonApps.ResetBindings(false);
        }
    }
}
