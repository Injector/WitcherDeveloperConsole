using System.Xml.Serialization;
using System.IO;

namespace WitcherDebug
{
    public static class XmlParser
    {
        public static T Parse<T>(string xml)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var stringReader = new StringReader(xml))
                return (T)xmlSerializer.Deserialize(stringReader);
        }
    }

    [XmlRoot("config")]
    public class XmlConfig
    {
        [XmlElement("interval")]
        public int Interval = 5000;
        [XmlElement("auto")]
        public bool Auto;
        [XmlElement("language")]
        public string Language = "ru";
    }
}
