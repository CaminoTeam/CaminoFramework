using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CaminoLib
{
    public static class MdSerializer
    {

        public static string Serialize<T>(this T input)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(input.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, input);
                return textWriter.ToString();
            }
        }

        public static T Deserialize<T>(string input)
        {
            var sr = new StringReader(input);
            var ser = new XmlSerializer(typeof(T));
            var output = (T)ser.Deserialize(sr);

            sr.Close();
            return output;
        }
    }
}
