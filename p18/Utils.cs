using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

namespace p17_repasopoo {
    public static class Utils {
        public static void GrabarXml(string arch, Red red) {
            FileStream f = File.Open(arch, FileMode.Create);
            XmlSerializer xml = new XmlSerializer(typeof(Red));
            xml.Serialize(f,red);
        }
        public static void LeerXml(string arch, ref Red red) {
            FileStream  f = File.Open(arch, FileMode.Open);
            XmlSerializer xml = new XmlSerializer(typeof(Red));
            red = (Red) xml.Deserialize(f);
        }
    }
}