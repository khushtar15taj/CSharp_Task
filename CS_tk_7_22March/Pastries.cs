using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CS_tk_7_22March
{
    [Serializable]
    public class Pastries
    {
        public void DessertWriter()
        {

            try
            {
                bool append = false;
                var fileName = @"D:\XMLSerializer.xml";
                List<string> desserts = new List<string>();
                desserts.Add("BlacForest");
                desserts.Add("Chocolava");
                XmlSerializer serializer = new XmlSerializer(typeof(List<string>));

                using (Stream stream = File.Open(fileName, append ? FileMode.Append : FileMode.Create))
                {
                    serializer.Serialize(stream, desserts);
                }
            }
            catch (SerializationException e) 
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw e;
            }
        }

        public void DesserReader()
        {
            try
            {
                var fileName = @"D:\XMLSerializer.xml";
                XmlSerializer deserializer = new XmlSerializer(typeof(List<string>));
                TextReader reader = new StreamReader(fileName);
                object obj = deserializer.Deserialize(reader);
                reader.Close();

                var t = (List<string>)obj;

                foreach (string s in t)
                {
                    Console.Error.WriteLine(s);
                }

                FileInfo info = new FileInfo(fileName);
                Console.WriteLine(info.Length);
                Console.WriteLine(info.CreationTime);
               
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }


        }
    }
}
