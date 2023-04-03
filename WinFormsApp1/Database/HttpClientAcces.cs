//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Net;
//using System.Text;
//using System.Threading.Tasks;

namespace WinFormsApp1.Database
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    internal class HttpClientAcces
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public HttpClientAcces()
        {
            endPoint = "";
            httpMethod = httpVerb.GET;
        }

        public string MakeRequest()
        {
            string strResponseValue = string.Empty;
            var request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = httpMethod.ToString();
            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                strResponseValue = "{'errorMessage': [ex.Massage.ToString()], 'error' : {}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            return strResponseValue;
        }
    }
}
