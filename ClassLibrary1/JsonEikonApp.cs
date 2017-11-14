using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Generic Json Post content headers:
 POST /sxs/v1/ HTTP/1.1
        Host: 127.0.0.1:9000
    Content-Type: application/json
    */

namespace EikonSxSClassLibrary
{

    public class JsonApp
    {
        public string sessionToken { get; set; } = "";
        public string appId { get; set; } = "";
        public JsonContext context { get; set; } = new JsonContext();


        public override string ToString()
        {
            string strResult = appId + " : ";

            foreach (JsonEntities a in context.entities)
            {
                strResult += a.RIC + ", ";
            }

            return strResult;
        }

    }

    public class JsonContext
    {
        public List<JsonEntities> entities { get; set; } = new List<JsonEntities>();
    }


    public class JsonEntities
    {
        public string RIC { get; set; } = "";

        public string datasource { get; set; } = "Q";


        public JsonEntities(string strInput = "")
        {
            RIC = strInput;
        }

    }

    /* Json to Launch Quote App 
    {
        "command": "launch",
        "sessionToken": "<session token returned from handshake>",
        "appId": "Quote Object"
    }

    Launching News App
    {
    "command": "launch",
    "sessionToken": "<session token returned from handshake>",
    "appId": "News",
    "context": {
       "entities": [{
           "RIC": "TRI.TO"
           }]
    }

    Good Response:
    {
    "isSuccess": true,
    "instanceId":  "<some instance Id>"
    }

    Bad Response:
    {
    "isSuccess": false,
    "error": {
        "code": 0,
        "message": "Unknown AppId."
    }
    }   

    */

    public class JsonLaunchApp : JsonApp
    {
        public string command { get; } = "launch";        
    }


    public class JsonChangeContext
    {
        public string command { get; } = "contextChanged";

        public string sessionToken { get; set; } = "";
        //public string instanceId { get; set; } = "";
        public JsonContext context { get; set; } = new JsonContext();
    }



    /*Json to show/hide Feedback for Linking (Broadcast  from our App to EikonApp)
     *  
     *  POST /sxs/v1/ HTTP/1.1
        Host: 127.0.0.1:9000
    Content-Type: application/json
    {
    "command": "showFeedbackForLinking",     <-- or (hideFeedbackForLinking)
    "sessionToken": "<session token>",
    "instanceId": "<a target app instance id>"
       }
     * 
     * 
     Response:
     HTTP/1.1 200 OK
    Content-Type: application/json
 
     {
    "isSuccess": true
    }
    */
    public class JsonShowFeedbackForLinking
    {
        public string command { get; set; } = "showFeedbackForLinking";

        public string sessionToken { get; set; } = "";
        public string instanceId { get; set; } = "";        
    }

    /* Json to Set Active State: 
    {
    "command": "activeStateChanged",
    "sessionToken": "<access token>",
    "isActive": true   <- or flase
    }

    RESPONSE:
    {
    "isSuccess": true
    }
    */
    public class JsonSetActiveState
    {
        public string command { get; } = "activeStateChanged";

        public string sessionToken { get; set; } = "";
        public bool isActive { get; set; } = true;
    }


    /* Json to Link / Unlink App
    {
    "command": "link",     <--  or "unlink"
    "sessionToken": "<session token>",
    "targetInstanceId": "<a target app instance id>"
    }

    Response     
    {
    "isSuccess": true   <-- or false
    }
    */
    public class JsonLinkApp
    {
        public string command { get; set; } = "";
        public string sessionToken { get; set; } = "";
        public string targetInstanceId { get; set; } = "";

    }


 


    /* Json Handshake   

    {
        "command":  "handshake",
        "appKey":   "<some private key>"
    }

    RESPOPNSE:
    HTTP/1.1 200 OK
    Content-Type: application/json
 
    {
    "isSuccess": true,
    "sessionToken":  "<generated session token>"
    }*/
    public class JsonHandshake
    {
        public string command { get; } = "handshake";
        public string productId { get; set; } = "";
        public string apiKey { get; set; } = "";

        public JsonHandshake(string pId = "", string aKey = "")
        {
            productId = pId;
            apiKey = aKey;
        }
    }


}
