using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test
{
    [Serializable()]
    public class Review
    {
        public Review()
        {

        }
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public string name { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("reviewText")]
        public string reviewText { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("submissionTime")]
        public string submissionTime { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("title")]
        public string title { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("upVotes")]
        public int upVotes { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("downVotes")]
        public int downVotes { get; set; }

    }
}