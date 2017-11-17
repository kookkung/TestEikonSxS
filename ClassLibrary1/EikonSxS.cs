using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EikonSxSClassLibrary
{
    public enum linkMethod
    {
        BROADCAST,          // broadcast to Eikon APp
        STOPBROADCAST,      // stop broadcast to Eikon App
        RECEIVED,           // Receive broadcast from Eikon App
        STOPRECEIVED        // Stop receive broadcast from Eikon App
    }

    public enum showFeedbackMethod
    {
        SHOW,               // Show Feedback for Linking on Eikon App
        HIDE                // Hide
    }

    public enum activeState
    {
        ACTIVE,
        INACTIVE
    }

    public class EikonSxS
    {
        public int PORT { get; set; } = 9000;
        public bool ISVALIDPORT { get; set; } = false;
        public string URL_PING { get; set; } = "http://127.0.0.1:9000/ping";
        public string URL_SXS { get; set; } = "http://127.0.0.1:9000/sxs/v1";
        public string PRODUCT_ID { get; set; } = "";
        public string APIKEY { get; set; } = "";

        
        public string SESSIONTOKEN { get; set; } = "";
        public bool ISHANDSHAKESUCCESS  { get; set; } = false;

        public List<EikonApp> EIKONAPP { get; set; } = new List<EikonApp>();


        private RestClient restClient = new RestClient();

        public EikonSxS()
        {

        }


        public string DoPingTest()
        {
            string strResponse = "";

            restClient.URI = URL_PING;
            restClient.httpMethod = httpMethod.GET;

            strResponse = restClient.GetRequest();

            return strResponse;

        }

        public string DoHandshake(out string outPostData)
        {
            string strResponse = string.Empty;

            restClient.httpMethod = httpMethod.POST;
            restClient.URI = URL_SXS;            
                        
            JsonHandshake jHandshake = new JsonHandshake(PRODUCT_ID, APIKEY);            
            string strPostData = JsonConvert.SerializeObject(jHandshake, Formatting.Indented);
            // return generated PostData to out string
            outPostData = strPostData;
            
            strResponse = restClient.PostRequest(strPostData);            
                        

            // Using Newtonsoft.Json library to do JSON Deserialization Object
            try
            {
                var myObject = JsonConvert.DeserializeObject<dynamic>(strResponse);
                
                if (myObject.isSuccess == true)
                {
                    SESSIONTOKEN = myObject.sessionToken;
                    ISHANDSHAKESUCCESS = true;              

                }
                else
                {
                    SESSIONTOKEN = "";
                    ISHANDSHAKESUCCESS = false;
                    DebugOutput("ERROR");                    
                }

            }
            catch (Exception ex)
            {

                //strResponse = ex.Message.ToString();
            }


            return strResponse;
        }


        public string DoLaunchApp(string appName, List<string> context, out string stroutPostData)
        {
            string strResponse = string.Empty;

            restClient.httpMethod = httpMethod.POST;
            restClient.URI = URL_SXS;
                        
            JsonLaunchApp jLaunchApp = new JsonLaunchApp();
            jLaunchApp.appId = appName;
            jLaunchApp.sessionToken = SESSIONTOKEN;


            // Add RIC (context) to our JSon object
            foreach (string str in context) {
                jLaunchApp.context.entities.Add(new JsonEntities(str));                
            }
            

            // Serialize JSonLaunchApp object to create JSON data for POST Request
            string strPostData = JsonConvert.SerializeObject(jLaunchApp, Formatting.Indented);

            stroutPostData = strPostData;

            DebugOutput(strPostData);            

            strResponse = restClient.PostRequest(strPostData);

            // Using Newtonsoft.Json library to do JSON Deserialization Object from Web Response
            try
            {
                var myObject = JsonConvert.DeserializeObject<dynamic>(strResponse);

                if (myObject.isSuccess == true)
                {
                    DebugOutput("instanceID: " + myObject.instanceId);
                    EIKONAPP.Add(new EikonApp(myObject.instanceId.ToString(), jLaunchApp));
                }
                else
                {
                    DebugOutput("ERROR LAUNCHING APP");
                }

            }
            catch (Exception ex)
            {

                //strResponse = ex.Message.ToString();
            }

            return strResponse;
        }

        public string DoChangeContext(string strNewRic, out string stroutPostData)
        {
            string strResponse = string.Empty;

            restClient.httpMethod = httpMethod.POST;
            restClient.URI = URL_SXS;

            JsonChangeContext jContextChange = new JsonChangeContext();
            jContextChange.sessionToken = SESSIONTOKEN;
            //jContextChange.instanceId = INSTANCEID;
            jContextChange.context.entities.Add(new JsonEntities(strNewRic));



            // Serialize JSonLaunchApp object to create JSON data for POST Request
            string strPostData = JsonConvert.SerializeObject(jContextChange, Formatting.Indented);

            stroutPostData = strPostData;

            DebugOutput(strPostData);

            strResponse = restClient.PostRequest(strPostData);

            // Using Newtonsoft.Json library to do JSON Deserialization Object from Web Response
            try
            {
                var myObject = JsonConvert.DeserializeObject<dynamic>(strResponse);

                if (myObject.isSuccess == true)
                {
                    DebugOutput("Context Changed Success: " + myObject.instanceId);

                    // Context changed success, scroll through list to change the Ricname of each App
                    foreach (EikonApp myApp in EIKONAPP)
                    {
                        if (myApp.BROADCASTTO == true){

                            // clear current entities list & add a new one with new Ric name that we made the broadcast
                            myApp.APP.context.entities.Clear();
                            myApp.APP.context.entities.Add(new JsonEntities(strNewRic));

                        }

                    }
                    
                }
                else
                {
                    DebugOutput("ERROR Changing Context");
                }

            }
            catch (Exception ex)
            {

                //strResponse = ex.Message.ToString();
            }
            
            return strResponse;
        }


    


        public string ProcessIncomingWSMessage(string strMessage)
        {
            string strResponse = "";
            string strInstanceId = "";

            // Check if it's valid JSON Message from server, and process the JSon Request
            try
            {
                var myObject = JsonConvert.DeserializeObject<dynamic>(strMessage);

                DebugOutput("COMMAND: " + myObject.command);

                string strCommand = myObject.command;

                switch (strCommand)
                {
                    // received Linked command from Eikon App (Eikon App links to our app)
                    case "linked":
                        DebugOutput("FOUND LINK COMMAND: " + myObject.command + " ID: "+ myObject.instanceId);
                        strInstanceId = myObject.instanceId;
                        ChangeLinkToMyApp(linkMethod.RECEIVED, strInstanceId);    
                        break;

                    // received Unlinked command from Eikon App (Eikon App unlinks our app)
                    case "unlinked":
                        DebugOutput("FOUND UNLINK COMMAND: " + myObject.command + " ID: " + myObject.instanceId);
                        strInstanceId = myObject.instanceId;
                        ChangeLinkToMyApp(linkMethod.STOPRECEIVED, strInstanceId);  
                        break;

                    // Linked EIkon App received Unlinked command from Eikon App (Eikon App unlinks our app)
                    case "contextReceived":
                        strInstanceId = myObject.instanceId;
                        string strJsonContext = myObject.context;
                        DebugOutput("CONTEXT CHANGED RECEIVED: " + myObject.command + " ID: " + myObject.instanceId + " context: " + strJsonContext);
                                                
                        ProcessContextReceived(strInstanceId, strJsonContext);
                        break;

                    case "hideFeedbackForLinking":
                        strResponse = "hideFeedbackForLinking";
                        break;
                    case "showFeedbackForLinking":
                        strResponse = "showFeedbackForLinking";
                        break;

                    case "workspaceChanged":
                    default:
                        break;

                }


            }
            catch (Exception)
            {

                //strResponse = ex.Message.ToString();
            }


            return strResponse;
        }


        public void DebugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }

        }


        // bLink = true <-  Link,  false <-  Unlink.   
        private bool ChangeLinkToMyApp(linkMethod lnkMethod, string id)
        {
            bool bSuccess = false;            

            // Scroll through our Object and change state to Linked
            foreach (EikonApp myApp in EIKONAPP)
            {
                DebugOutput("myApp ID : " + myApp.INSTANCEID);
                if (string.Equals(myApp.INSTANCEID,id))
                {
                    // Found our instance, change status to Linked
                    DebugOutput("FOUND OUR LINKED APP with Instance ID :" + myApp.INSTANCEID);

                    if (lnkMethod == linkMethod.RECEIVED)
                        myApp.RECEIVEDFROM = true;
                    else if (lnkMethod == linkMethod.STOPRECEIVED)
                        myApp.RECEIVEDFROM = false;
                    
                    bSuccess = true;
                }                

            }

            return bSuccess;
        }


        private bool ProcessContextReceived(string strId, string strJsonContext)
        {
            bool bSuccess = false;      

            // Deserializa JSon contxt string to JSonContext object
            JsonContext context = JsonConvert.DeserializeObject<JsonContext>(strJsonContext);


            // Scroll through our Object and change context if found
            foreach (EikonApp myApp in EIKONAPP)
            {
                
                if (string.Equals(myApp.INSTANCEID, strId))
                {
                    // Found our instance, clear old entities and add new entities
                    myApp.APP.context.entities.Clear();

                    foreach (JsonEntities entities in context.entities)
                    {
                        myApp.APP.context.entities.Add(entities);
                        
                    }

                    bSuccess = true;
                }

            }            

            return bSuccess;
        }   


        public string BroadcastApp(linkMethod lnkMethod, EikonApp myApp, out string stroutPostData)
        {
            string strResponse = "";

            JsonLinkApp jLinkApp = new JsonLinkApp();

            if (lnkMethod == linkMethod.BROADCAST)
                jLinkApp.command = "link";
            else if (lnkMethod == linkMethod.STOPBROADCAST)
                jLinkApp.command = "unlink";
            else
                jLinkApp.command = "";

            jLinkApp.sessionToken = SESSIONTOKEN;
            jLinkApp.targetInstanceId = myApp.INSTANCEID;


            // Serialize JSonLaunchApp object to create JSON data for POST Request
            string strPostData = JsonConvert.SerializeObject(jLinkApp, Formatting.Indented);

            stroutPostData = strPostData;

            DebugOutput(strPostData);

            strResponse = restClient.PostRequest(strPostData);

            // Using Newtonsoft.Json library to do JSON Deserialization Object from Web Response
            try
            {
                var myObject = JsonConvert.DeserializeObject<dynamic>(strResponse);

                if (myObject.isSuccess == true)
                {
                    //Link/Unlink process Successfull, update our islinked state


                    if (lnkMethod == linkMethod.BROADCAST)
                    {
                        myApp.BROADCASTTO = true;
                        DebugOutput("Set Broadcast To Success instanceID: " + myApp.INSTANCEID);
                    }
                        
                    else if (lnkMethod == linkMethod.STOPBROADCAST)
                    {
                        myApp.BROADCASTTO = false;
                        DebugOutput("Stop Broadcast Success instanceID: " + myApp.INSTANCEID);
                    }                       

                                        
                }
                else
                {
                    DebugOutput("ERROR in Linking/Unlinkg APP");
                }

            }
            catch (Exception ex)
            {

                //strResponse = ex.Message.ToString();
            }


            return strResponse;
        }

        // Clear Link State to unlinked on all Eikon App
        public void ResetLinkState()
        {
            foreach (EikonApp myApp in EIKONAPP)
            {
                myApp.BROADCASTTO = false;
                myApp.RECEIVEDFROM = false;
            }


        }


        public string DoShowFeedbackForLinking(showFeedbackMethod showMethod, string strId, out string stroutPostData)
        {
            string strResponse = "";
            JsonShowFeedbackForLinking jShowFeedback = new JsonShowFeedbackForLinking();

            if (showMethod == showFeedbackMethod.SHOW)
            {
                jShowFeedback.command = "showFeedbackForLinking";

            } else
            {
                jShowFeedback.command = "hideFeedbackForLinking";

            }

            jShowFeedback.sessionToken = SESSIONTOKEN;
            jShowFeedback.instanceId = strId;


            // Serialize JSonLaunchApp object to create JSON data for POST Request
            string strPostData = JsonConvert.SerializeObject(jShowFeedback, Formatting.Indented);

            stroutPostData = strPostData;

            DebugOutput(strPostData);

            strResponse = restClient.PostRequest(strPostData);

            // Using Newtonsoft.Json library to do JSON Deserialization Object from Web Response
            try
            {
                var myObject = JsonConvert.DeserializeObject<dynamic>(strResponse);

                if (myObject.isSuccess == true)
                {
                    //Show/Hide Feedback  process Successful               

                
                }
                else
                {
                    DebugOutput("ERROR in Show/Hide Feedback for Linking");
                }

            }
            catch (Exception ex)
            {

                //strResponse = ex.Message.ToString();
            }



            return strResponse;
        }

        // Set Active State,  stil doesn't know the exact result  so  no button on UI to do this yet...
        public string DoSetActiveState(activeState aState)
        {
            string strResponse = "";

            JsonSetActiveState jSetActiveState = new JsonSetActiveState();

            if (aState == activeState.ACTIVE)
            {
                jSetActiveState.isActive = true;
            } else
            {
                jSetActiveState.isActive = false;
            }

            jSetActiveState.sessionToken = SESSIONTOKEN;


            // Serialize JSonLaunchApp object to create JSON data for POST Request
            string strPostData = JsonConvert.SerializeObject(jSetActiveState);

            DebugOutput(strPostData);

            strResponse = restClient.PostRequest(strPostData);

            // Using Newtonsoft.Json library to do JSON Deserialization Object from Web Response
            try
            {
                var myObject = JsonConvert.DeserializeObject<dynamic>(strResponse);

                if (myObject.isSuccess == true)
                {
                    //Set Active state Successful          
                    DebugOutput("SET ACTIVE STATE SUCCESSFULL,  ACTIVESTATE:" + jSetActiveState.isActive);

                }
                else
                {
                    DebugOutput("ERROR in Show/Hide Feedback for Linking");
                }

            }
            catch (Exception ex)
            {

                //strResponse = ex.Message.ToString();
            }


            return strResponse;
        }


    }

}
