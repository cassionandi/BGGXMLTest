using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace BGGXMLTest
{

    [XmlRoot(ElementName = "items")]
    public class ItemsDetalhe
    {
        [XmlElement(ElementName = "item")]
        public ItemDetalhe Item { get; set; }
        [XmlAttribute(AttributeName = "termsofuse")]
        public string Termsofuse { get; set; }
    }

    [XmlRoot(ElementName = "name")]
    public class NameDetalhe
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "sortindex")]
        public string Sortindex { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "link")]
    public class LinkDetalhe
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "yearpublished")]
    public class YearpublishedDetalhe
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "seriescode")]
    public class SeriescodeDetalhe
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "item")]
    public class ItemDetalhe
    {
        [XmlElement(ElementName = "thumbnail")]
        public string Thumbnail { get; set; }
        [XmlElement(ElementName = "image")]
        public string Image { get; set; }
        [XmlElement(ElementName = "name")]
        public List<NameDetalhe> Name { get; set; }
        [XmlElement(ElementName = "link")]
        public List<LinkDetalhe> Link { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "yearpublished")]
        public YearpublishedDetalhe Yearpublished { get; set; }
        [XmlElement(ElementName = "seriescode")]
        public SeriescodeDetalhe Seriescode { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }



}
