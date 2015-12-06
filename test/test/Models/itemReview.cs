using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace test
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("itemReview")]
    public class itemReview
    {
        public itemReview()
        {

        }

        [System.Xml.Serialization.XmlElementAttribute("itemId")]
        public long itemId { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("name")]
        public string name { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("salePrice")]
        public decimal salePrice { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("categoryPath")]
        public string categoryPath { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("brandName")]
        public string brandName { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("productUrl")]
        public string productUrl { get; set; }

        [XmlArrayItem(typeof(Review))]
        public Review[] reviews { get; set; }
    }
}