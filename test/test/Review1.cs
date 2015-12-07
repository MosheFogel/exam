using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Xml;

namespace test
{
    public class Review1
    {
        public string getUrl1(long num, string text)
        {
            string url = "http://api.walmartlabs.com/v1/reviews/" + num.ToString()+ "?apiKey=59se8z5xmud85mwcuk9fvkry&overallRatingRange=50&format=xml";
       
            return url;
         }

        public HttpWebResponse GetResponse(string url)
        {
            HttpWebRequest webrequest = null;
            string completeUri = String.Format(url, "image", "sushi");
            webrequest = (HttpWebRequest)webrequest.Create(url);
            HttpWebResponse webResponse = null;
            webResponse = (HttpWebResponse)webResponse.GetResponseHeader();
            return webResponse;
        }

        public List<T> ReviewList<T>(HttpWebResponse webResponse)
        {
            List<T> l = new List<T>();
            XmlReader xmlReader = null;
            xmlReader = XmlReader.Create(webResponse.GetResponseStream());



            return l;
        }
    }
}