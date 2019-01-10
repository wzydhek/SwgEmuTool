using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Serialization;
using System.Reflection;
using System.IO;

namespace SwgEmuTool
{
    public class GalaxyCollection
    {
        public List<Galaxy> Galaxies { get; set; } = new List<Galaxy>();

        public static void Initialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GalaxyCollection));
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SwgEmuTool.xml.GalaxyData.xml"))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    Form1.Galaxies = (GalaxyCollection)serializer.Deserialize(sr);
                }
            }
        }

        public Galaxy GetGalaxyByID(int id)
        {
            return Galaxies.FirstOrDefault(g => g.ID == id);
        }

        public Galaxy GetGalaxyByGHID(int id)
        {
            return Galaxies.FirstOrDefault(g => g.GHID == id);
        }

        public Galaxy GetGalaxyByName(string name)
        {
            return Galaxies.FirstOrDefault(g => g.Name == name);
        }
    }

    public class Galaxy
    {
        // XML Fields
        public int ID { get; set; }
        public string Name { get; set; }
        public bool NGE { get; set; }
        public int GHID { get; set; }

        // Overrides
        public override string ToString()
        {
            return Name;
        }
    }
}
