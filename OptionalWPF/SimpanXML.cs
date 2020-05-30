using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace OptionalWPF
{
    class SimpanXML
    {
        public static void simpandata(object obj, string namafile)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(namafile);
            sr.Serialize(writer, obj);
            writer.Close();
        }
    }
}
