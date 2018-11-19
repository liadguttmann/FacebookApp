using System.Net;
using System.IO;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_301595856_304843824
{
    public class HttpAdapter
    {
        public string httpGetData(string httpUrl)
        {
            var request = (HttpWebRequest)WebRequest.Create(httpUrl);
            var response = (HttpWebResponse)request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
    }
}
