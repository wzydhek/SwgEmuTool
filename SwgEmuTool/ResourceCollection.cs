using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Serialization;
using System.Reflection;
using System.IO;
using System.Xml;

namespace SwgEmuTool
{
    [Serializable]
    public class ResourceCollection : IDisposable
    {
        public List<Resource> Resources { get; set; } = new List<Resource>();

        [XmlIgnore]
        public bool isDirty = false;

        public static void Initialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ResourceCollection));

            if (!File.Exists("ResourceData.xml"))
            {
                TextWriter writer = new StreamWriter("ResourceData.xml");
                serializer.Serialize(writer, Form1.Resources);
                writer.Close();
            }

            using (Stream stream = new FileStream("ResourceData.xml", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    Form1.Resources = (ResourceCollection)serializer.Deserialize(sr);
                    Form1.Resources.isDirty = false;
                }
            }
        }

        public Resource GetResourceByName(string name, int galaxy)
        {
            return Resources.FirstOrDefault(r => r.Galaxy == galaxy && r.SpawnName == name);
        }

        public List<string> GetResourceNamesByGalaxy(int galaxy)
        {
            return Resources.Where(r => r.Galaxy == galaxy).Select(r => r.SpawnName).ToList();
        }

        public List<string> GetActiveResourceNamesByGalaxy(int galaxy)
        {
            return Resources.Where(r => r.Galaxy == galaxy && r.Unavailable == null).Select(r => r.SpawnName).ToList();
        }

        public List<string> GetResourcePlanets(string name, int galaxy)
        {
            return GetResourceByName(name, galaxy).Planets;
        }

        public void SaveResources()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ResourceCollection));
            TextWriter writer = new StreamWriter("ResourceData.xml");
            serializer.Serialize(writer, this);
            writer.Close();
        }

        public List<Resource> GetResourcesByGroup(int groupid, int galaxy)
        {
            List<ResourceType> types = Form1.ResourceTypes.GetResourceTypesByGroup(groupid);

            return GetResourcesByGalaxy(galaxy).Where(r => types.Contains(Form1.ResourceTypes.GetResourceTypeByID(r.ResourceType))).OrderBy(r => r.SpawnName).ToList();
        }

        public List<Resource> GetResourcesByType(int typeid, int galaxy)
        {
            return GetResourcesByGalaxy(galaxy).Where(r => r.ResourceType == typeid).OrderBy(r => r.SpawnName).ToList();
        }

        public List<Resource> GetResourcesByGalaxy(int galaxy)
        {
            return Resources.Where(r => r.Galaxy == galaxy).ToList();
        }

        public void Add(Resource res)
        {
            Resources.Add(res);
            isDirty = true;
        }

        public void Dispose()
        {
            if (isDirty)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ResourceCollection));
                TextWriter writer = new StreamWriter("ResourceData.xml");
                serializer.Serialize(writer, this);
                writer.Close();
            }
        }
    }

    [Serializable]
    public class Resource
    {
        // XML Fields
        public string SpawnName { get => spawnName; set => spawnName = value.ToLower(); }
        public int Galaxy { get; set; }
        public int ResourceType { get => resourceType.typeID; set => resourceType = Form1.ResourceTypes.GetResourceTypeByID(value); }
        public DateTime Entered { get; set; }
        public DateTime? Unavailable { get; set; } = null;
        public int ER
        {
            get
            {
                return er;
            }
            set
            {
                er = value;
                if (resourceType != null)
                {
                    ERPerc = 0;
                    if (er > 0)
                        if (resourceType.erMax == resourceType.erMin && er == resourceType.erMax)
                            ERPerc = 100;
                        else
                            ERPerc = (((decimal)er - resourceType.erMin) / ((decimal)resourceType.erMax - resourceType.erMin)) * 100;
                }
            }
        }
        public int CR
        {
            get
            {
                return cr;
            }
            set
            {
                cr = value;
                if (resourceType != null)
                {
                    CRPerc = 0;
                    if (cr > 0)
                        if (resourceType.crMax == resourceType.crMin && cr == resourceType.crMax)
                            CRPerc = 100;
                        else
                            CRPerc = (((decimal)cr - resourceType.crMin) / ((decimal)resourceType.crMax - resourceType.crMin)) * 100;
                }
            }
        }
        public int CD
        {
            get
            {
                return cd;
            }
            set
            {
                cd = value;
                if (resourceType != null)
                {
                    CDPerc = 0;
                    if (cd > 0)
                        if (resourceType.cdMax == resourceType.cdMin && cd == resourceType.cdMax)
                            CDPerc = 100;
                        else
                            CDPerc = (((decimal)cd - resourceType.cdMin) / ((decimal)resourceType.cdMax - resourceType.cdMin)) * 100;
                }
            }
        }
        public int DR
        {
            get
            {
                return dr;
            }
            set
            {
                dr = value;
                if (resourceType != null)
                {
                    DRPerc = 0;
                    if (dr > 0)
                        if (resourceType.drMax == resourceType.drMin && dr == resourceType.drMax)
                            DRPerc = 100;
                        else
                            DRPerc = (((decimal)dr - resourceType.drMin) / ((decimal)resourceType.drMax - resourceType.drMin)) * 100;
                }
            }
        }
        public int FL
        {
            get
            {
                return fl;
            }
            set
            {
                fl = value;
                if (resourceType != null)
                {
                    FLPerc = 0;
                    if (fl > 0)
                        if (resourceType.flMax == resourceType.flMin && fl == resourceType.flMax)
                            FLPerc = 100;
                        else
                            FLPerc = (((decimal)fl - resourceType.flMin) / ((decimal)resourceType.flMax - resourceType.flMin)) * 100;
                }
            }
        }
        public int HR
        {
            get
            {
                return hr;
            }
            set
            {
                hr = value;
                if (resourceType != null)
                {
                    HRPerc = 0;
                    if (hr > 0)
                        if (resourceType.hrMax == resourceType.hrMin && hr == resourceType.hrMax)
                            HRPerc = 100;
                        else
                            HRPerc = (((decimal)hr - resourceType.hrMin) / ((decimal)resourceType.hrMax - resourceType.hrMin)) * 100;
                }
            }
        }
        public int MA
        {
            get
            {
                return ma;
            }
            set
            {
                ma = value;
                if (resourceType != null)
                {
                    MAPerc = 0;
                    if (ma > 0)
                        if (resourceType.maMax == resourceType.maMin && ma == resourceType.maMax)
                            MAPerc = 100;
                        else
                            MAPerc = (((decimal)ma - resourceType.maMin) / ((decimal)resourceType.maMax - resourceType.maMin)) * 100;
                }
            }
        }
        public int PE
        {
            get
            {
                return pe;
            }
            set
            {
                pe = value;
                if (resourceType != null)
                {
                    PEPerc = 0;
                    if (pe > 0)
                        if (resourceType.peMax == resourceType.peMin && pe == resourceType.peMax)
                            PEPerc = 100;
                        else
                            PEPerc = (((decimal)pe - resourceType.peMin) / ((decimal)resourceType.peMax - resourceType.peMin)) * 100;
                }
            }
        }
        public int OQ
        {
            get
            {
                return oq;
            }
            set
            {
                oq = value;
                if (resourceType != null)
                {
                    OQPerc = 0;
                    if (oq > 0)
                    {
                        if (resourceType.oqMax == resourceType.oqMin && oq == resourceType.oqMax)
                            OQPerc = 100;
                        else
                            OQPerc = (((decimal)oq - resourceType.oqMin) / ((decimal)resourceType.oqMax - resourceType.oqMin)) * 100;
                    }
                }
            }
        }
        public int SR
        {
            get
            {
                return sr;
            }
            set
            {
                sr = value;
                if (resourceType != null)
                {
                    SRPerc = 0;
                    if (sr > 0)
                        if (resourceType.srMax == resourceType.srMin && sr == resourceType.srMax)
                            SRPerc = 100;
                        else
                            SRPerc = (((decimal)sr - resourceType.srMin) / ((decimal)resourceType.srMax - resourceType.srMin)) * 100;
                }
            }
        }
        public int UT
        {
            get
            {
                return ut;
            }
            set
            {
                ut = value;
                if (resourceType != null)
                {
                    UTPerc = 0;
                    if (ut > 0)
                        if (resourceType.utMax == resourceType.utMin && ut == resourceType.utMax)
                            UTPerc = 100;
                        else
                            UTPerc = (((decimal)ut - resourceType.utMin) / ((decimal)resourceType.utMax - resourceType.utMin)) * 100;
                }
            }
        }
        public List<string> Planets { get; set; } = new List<string>();

        // Field Support
        private string spawnName;
        private ResourceType resourceType = null;
        private int er = 0;
        private int cr = 0;
        private int cd = 0;
        private int dr = 0;
        private int fl = 0;
        private int hr = 0;
        private int ma = 0;
        private int pe = 0;
        private int oq = 0;
        private int sr = 0;
        private int ut = 0;

        // Internal Fields
        [XmlIgnore]
        public string ResourceTypeName { get => resourceType.name;  }
        [XmlIgnore]
        public decimal ERPerc { get; private set; }
        [XmlIgnore]
        public decimal CRPerc { get; private set; }
        [XmlIgnore]
        public decimal CDPerc { get; private set; }
        [XmlIgnore]
        public decimal DRPerc { get; private set; }
        [XmlIgnore]
        public decimal FLPerc { get; private set; }
        [XmlIgnore]
        public decimal HRPerc { get; private set; }
        [XmlIgnore]
        public decimal MAPerc { get; private set; }
        [XmlIgnore]
        public decimal PEPerc { get; private set; }
        [XmlIgnore]
        public decimal OQPerc { get; private set; }
        [XmlIgnore]
        public decimal SRPerc { get; private set; }
        [XmlIgnore]
        public decimal UTPerc { get; private set; }

        // Overrides
        public override string ToString()
        {
            return SpawnName;
        }
    }

    public class GHResource
    {
        public string name { get; set; }
        public int galaxy { get; set; }
        public DateTime entered { get; set; }
        public int resourceType { get; set; }
        public string ghtype { get; set; }
        public int er { get; set; } = 0;
        public int cr { get; set; } = 0;
        public int cd { get; set; } = 0;
        public int dr { get; set; } = 0;
        public int fl { get; set; } = 0;
        public int hr { get; set; } = 0;
        public int ma { get; set; } = 0;
        public int pe { get; set; } = 0;
        public int oq { get; set; } = 0;
        public int sr { get; set; } = 0;
        public int ut { get; set; } = 0;
        public List<string> planets { get; set; } = new List<string>();

        public GHResource(XmlNode node)
        {
            foreach (XmlNode n in node.ChildNodes)
            {
                switch (n.Name)
                {
                    case "name":
                        name = n.InnerText;
                        break;
                    case "galaxy":
                        galaxy = int.Parse(n.Attributes["id"].Value);
                        break;
                    case "enter_date":
                        entered = DateTime.Parse(n.InnerText);
                        break;
                    case "resource_type":
                        ResourceType type = null;
                        type = Form1.ResourceTypes.GetResourceTypeByGHID(n.Attributes["id"].Value);
                        resourceType = type.typeID;
                        ghtype = n.Attributes["id"].Value;
                        break;
                    case "stats":
                        ParseStats(n);
                        break;
                    case "planets":
                        ParsePlanets(n);
                        break;
                }
            }
        }

        private void ParseStats(XmlNode node)
        {
            foreach (XmlNode n in node.ChildNodes)
            {
                switch (n.Name)
                {
                    case "ER":
                        er = int.Parse(n.InnerText);
                        break;
                    case "CR":
                        cr = int.Parse(n.InnerText);
                        break;
                    case "CD":
                        cd = int.Parse(n.InnerText);
                        break;
                    case "DR":
                        dr = int.Parse(n.InnerText);
                        break;
                    case "FL":
                        fl = int.Parse(n.InnerText);
                        break;
                    case "HR":
                        hr = int.Parse(n.InnerText);
                        break;
                    case "MA":
                        ma = int.Parse(n.InnerText);
                        break;
                    case "OQ":
                        oq = int.Parse(n.InnerText);
                        break;
                    case "SR":
                        sr = int.Parse(n.InnerText);
                        break;
                    case "UT":
                        ut = int.Parse(n.InnerText);
                        break;
                }
            }
        }

        private void ParsePlanets(XmlNode node)
        {
            foreach (XmlNode n in node.ChildNodes)
            {
                planets.Add(n.InnerText);
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
