using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CardMarketPriceMgmnt
{
    public static class RequestHelper
    {
        public static HttpWebResponse makeRequest(CardMarkAppToken cmat, EnHttpMethod httpMethod, string url)
        {
            String method = HttpMethod_h.enHttpMethodToStr(httpMethod);
            // String url = "https://api.cardmarket.com/ws/v1.1/account";

            HttpWebRequest request = WebRequest.CreateHttp(url) as HttpWebRequest;
            OAuthHeader header = new OAuthHeader(cmat);
            request.Headers.Add(HttpRequestHeader.Authorization, header.getAuthorizationHeader(method, url));
            request.Method = method;
            

            return request.GetResponse() as HttpWebResponse;
            
        }

        public static void makeRequestAndSaveBinToFile(CardMarkAppToken cmat, EnHttpMethod httpMethod, string url, string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                }
                catch(Exception ex)
                {
                    throw new Exception(string.Format("{0}: beim löschen von Datei {1}:{2}",
                        ex.Message, filePath, ex.ToString()
                        ));
                }
            }
            HttpWebResponse response = makeRequest(cmat, httpMethod, url);
            using (Stream output = File.OpenWrite(filePath))
            using (Stream input = response.GetResponseStream())
            {
                input.CopyTo(output);
            }
        }

        public static string makeJsonRequest(CardMarkAppToken cmat, EnHttpMethod httpMethod, string url)
        {

            HttpWebResponse response = makeRequest(cmat, httpMethod, url);
            //XmlDocument doc = new XmlDocument();
            //doc.Load(response.GetResponseStream());
            // proceed further
            string s;
            using (var readr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                s = readr.ReadToEnd();
            }
            return s;
        }
    }
}
