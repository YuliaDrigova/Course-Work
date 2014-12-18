using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace courseWork
{
    class Writing_in_XML
    {

        
        public static bool SaveToXML(List<Film> list)
        {
            string path = "1.txt";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Film>));
            try
            {
                using (TextWriter writer = new StringWriter())
                {
                    string serialization;
                    serializer.Serialize(writer, list);
                    serialization = writer.ToString();

                    File.WriteAllText(path, serialization);
                }
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        public static List<Film> ReadFromXML()
        {
            string path = "1.txt";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Film>));
            string serialization = File.ReadAllText(path);

            if (!String.IsNullOrEmpty(serialization))
            {
                using (TextReader reader = new StringReader(serialization))
                {
                    return (List<Film>)serializer.Deserialize(reader);
                }
            }
            return new List<Film>();
        }
    }
}
