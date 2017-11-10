using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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
