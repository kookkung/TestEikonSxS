using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace EikonSxSClassLibrary
{
    public enum httpMethod
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public enum linkMethod
    {
        LINK,
        UNLINK,
        LINKED,
        UNLINKED
    }

    public class RestClient
    {
        public string URI { get; set; }
        public httpMethod httpMethod { get; set; }

        public RestClient()
        {
            URI = string.Empty;
            httpMethod = httpMethod.GET;
        }

        public string GetRequest()
        {
            string strResponse = string.Empty;


            // Make HTTP Request
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);

                request.Method = httpMethod.ToString();

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {

                        return "ERROR";
                    }


                    // Process Response Stream (could be JSON, XML, HTML , etc...)  
                    using (Stream responseStream = response.GetResponseStream())
                    {

                        if (responseStream != null)
                        {

                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponse = reader.ReadToEnd();
                            }

                        }

                    }

                }

            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }  


            return strResponse;
        }

        public string PostRequest(string postData)
        {
            string strResponse = string.Empty;

            httpMethod = httpMethod.POST;

            try
            {
                // Encoding post data
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] data = encoding.GetBytes(postData);

                WebRequest request = WebRequest.Create("http://127.0.0.1:9000/sxs/v1/");
                request.Method = "POST";
                //request.ContentType = "application/x-www-form-urlencoded";
                request.ContentType = "application/json";
                request.ContentLength = data.Length;

                Stream stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                WebResponse response = request.GetResponse();
                stream = response.GetResponseStream();

                StreamReader sr = new StreamReader(stream);
                strResponse = sr.ReadToEnd();
                sr.Close();
                stream.Close();

            }
            catch (Exception exp)
            {
                strResponse = exp.Message.ToString();                
            }

            
            

            return strResponse;
        }

    }
}
  