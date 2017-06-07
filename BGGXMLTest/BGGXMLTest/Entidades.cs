using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BGGXMLTest
{

    [XmlRoot(ElementName = "items")]
    public class Items
    {
        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }
        [XmlAttribute(AttributeName = "termsofuse")]
        public string Termsofuse { get; set; }
    }

    [XmlRoot(ElementName = "item")]
    public class Item
    {
        [XmlElement(ElementName = "thumbnail")]
        public Thumbnail Thumbnail { get; set; }
        [XmlElement(ElementName = "name")]
        public Name Name { get; set; }
        [XmlElement(ElementName = "yearpublished")]
        public Yearpublished Yearpublished { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "rank")]
        public string Rank { get; set; }
    }

    [XmlRoot(ElementName = "thumbnail")]
    public class Thumbnail
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "name")]
    public class Name
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "yearpublished")]
    public class Yearpublished
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

 

}
