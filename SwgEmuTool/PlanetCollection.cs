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
    [Serializable]
    public class PlanetCollection
    {
        public List<Planet> Planets { get; set; } = new List<Planet>();

        public static void Initialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PlanetCollection));
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SwgEmuTool.xml.PlanetData.xml"))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    Form1.Planets = (PlanetCollection)serializer.Deserialize(sr);
                }
            }
        }

        public string GetPlanetName(int id)
        {
            return Planets.FirstOrDefault(p => p.ID == id).Name;
        }

        public int GetPlanetID(string name)
        {
            return Planets.FirstOrDefault(p => p.Name == name).ID;
        }
    }

    [Serializable]
    public class Planet
    {
        // XML Fields
        public int ID { get; set; }
        public string Name { get; set; }
        public int GalaxyID { get; set; }

        // Overrides
        public override string ToString()
        {
            return Name;
        }
    }
}
