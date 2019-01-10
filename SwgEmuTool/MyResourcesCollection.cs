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
    public class MyResourcesCollection : IDisposable
    {
        public List<MyResource> MyResources { get; set; } = new List<MyResource>();

        [XmlIgnore]
        public bool isDirty = false;

        public static void Initialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(MyResourcesCollection));

            if (!File.Exists("MyResourceData.xml"))
            {
                TextWriter writer = new StreamWriter("MyResourceData.xml");
                serializer.Serialize(writer, Form1.MyResources);
                writer.Close();
            }

            using (Stream stream = new FileStream("MyResourceData.xml", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    Form1.MyResources = (MyResourcesCollection)serializer.Deserialize(sr);
                    Form1.MyResources.isDirty = false;
                }
            }
        }

        public List<MyResource> GetResourcesByGalaxy(int galaxy)
        {
            return MyResources.Where(r => r.Galaxy == galaxy).OrderBy(r => r.SpawnName).ToList();
        }

        public List<MyResource> GetResourcesByGroup(int groupid, int galaxy)
        {
            List<ResourceType> types = Form1.ResourceTypes.GetResourceTypesByGroup(groupid);

            return GetResourcesByGalaxy(galaxy).Where(r => types.Contains(Form1.ResourceTypes.GetResourceTypeByID(r.ResourceType))).OrderBy(r => r.SpawnName).ToList();
        }

        public List<MyResource> GetResourcesByType(int typeid, int galaxy)
        {
            return GetResourcesByGalaxy(galaxy).Where(r => r.ResourceType == typeid).OrderBy(r => r.SpawnName).ToList();
        }

        public MyResource GetResource(string spawnName, int galaxy)
        {
            return GetResourcesByGalaxy(galaxy).FirstOrDefault(r => r.SpawnName == spawnName);
        }

        public void RemoveResource(string spawnName, int galaxy)
        {
            MyResource res = GetResource(spawnName, galaxy);
            if (res != null)
            {
                MyResources.Remove(res);
                isDirty = true;
            }
        }

        public void AddResource(Resource res, int units, bool filter, bool generic, decimal cpu)
        {
            MyResource r = GetResource(res.SpawnName, res.Galaxy);
            if (r == null)
            {
                r = new MyResource();
                r.SpawnName = res.SpawnName;
                r.Galaxy = res.Galaxy;
                r.Units = units;
                r.Filter = filter;
                r.Generic = generic;
                r.CPU = cpu;
                MyResources.Add(r);
            }
            else
            {
                r.Units = r.Units + units;
                r.Filter = filter;
                r.Generic = generic;
                r.CPU = cpu;
            }
            isDirty = true;
        }

        public void Dispose()
        {
            if (isDirty)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(MyResourcesCollection));
                TextWriter writer = new StreamWriter("MyResourceData.xml");
                serializer.Serialize(writer, this);
                writer.Close();
            }
        }
    }

    [Serializable]
    public class MyResource
    {
        // XML Fields
        public string SpawnName
        {
            get { return spawnName.ToLower(); }
            set
            {
                spawnName = value.ToLower();
                if (Galaxy > 0)
                    Resource = Form1.Resources.GetResourceByName(value, Galaxy);
            }
        }
        public int Galaxy
        {
            get { return galaxy; }
            set
            {
                galaxy = value;
                if (!string.IsNullOrEmpty(spawnName))
                    Resource = Form1.Resources.GetResourceByName(SpawnName, Galaxy);
            }
        }
        public int Units { get; set; }
        public bool Filter { get; set; }
        public bool Generic { get; set; }
        public decimal CPU { get; set; }

        // Support Fields
        private string spawnName = null;
        private int galaxy = 0;

        // Internal Fields
        [XmlIgnore]
        public Resource Resource { get; private set; } = null;
        [XmlIgnore]
        public string ResourceTypeName { get => Resource.ResourceTypeName; }
        [XmlIgnore]
        public int ResourceType { get => Resource.ResourceType; }
        [XmlIgnore]
        public int ER { get => Resource.ER; }
        [XmlIgnore]
        public int CR { get => Resource.CR; }
        [XmlIgnore]
        public int CD { get => Resource.CD; }
        [XmlIgnore]
        public int DR { get => Resource.DR; }
        [XmlIgnore]
        public int FL { get => Resource.FL; }
        [XmlIgnore]
        public int HR { get => Resource.HR; }
        [XmlIgnore]
        public int MA { get => Resource.MA; }
        [XmlIgnore]
        public int PE { get => Resource.PE; }
        [XmlIgnore]
        public int OQ { get => Resource.OQ; }
        [XmlIgnore]
        public int SR { get => Resource.SR; }
        [XmlIgnore]
        public int UT { get => Resource.UT; }

        // Overrides
        public override string ToString()
        {
            return string.Format("{0}:{1}", Galaxy, SpawnName);
        }
    }
}
