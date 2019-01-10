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
    public class ResourceTypeCollection
    {
        public List<ResourceType> ResourceTypes { get; set; } = new List<ResourceType>();

        public static void Initialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ResourceTypeCollection));
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SwgEmuTool.xml.ResourceTypeData.xml"))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    Form1.ResourceTypes = (ResourceTypeCollection)serializer.Deserialize(sr);
                }
            }
        }

        public ResourceType GetResourceTypeByID(int id)
        {
            return ResourceTypes.FirstOrDefault(r => r.typeID == id);
        }

        public ResourceType GetResourceTypeBySWGCID(string id)
        {
            return ResourceTypes.FirstOrDefault(r => r.swgcid == id);
        }

        public ResourceType GetResourceTypeByGHID(string id)
        {
            return ResourceTypes.FirstOrDefault(r => r.ghid == id);
        }

        public ResourceType GetResourceTypeBySWGID(string id)
        {
            return ResourceTypes.FirstOrDefault(r => r.swgid == id);
        }

        public ResourceType GetResourceTypeByName(string name)
        {
            return ResourceTypes.FirstOrDefault(r => r.name == name);
        }

        public string GetResourceTypeName(int id)
        {
            return GetResourceTypeByID(id).name;
        }

        public List<ResourceType> GetResourceGroups()
        {
            return ResourceTypes.Where(r => r.group).OrderBy(r => r.name).ToList();
        }

        public List<ResourceType> GetResourceTypes()
        {
            return ResourceTypes.Where(r => !r.group).OrderBy(r => r.name).ToList();
        }

        public List<ResourceType> GetResourceTypesByGroup(int groupid)
        {
            ResourceType group = GetResourceTypeByID(groupid);
            return ResourceTypes.Where(r => !r.group && r.key.StartsWith(group.key)).OrderBy(r => r.name).ToList();
        }
    }

    [Serializable]
    public class ResourceType
    {
        // XML Fields
        public int typeID { get; set; } = -1;
        public string swgcid { get; set; } = null;
        public string ghid { get; set; } = null;
        public string swgid { get; set; }
        public bool group { get; set; } = false;
        public string class1 { get; set; }
        public string class2 { get; set; } = null;
        public string class3 { get; set; } = null;
        public string class4 { get; set; } = null;
        public string class5 { get; set; } = null;
        public string class6 { get; set; } = null;
        public string class7 { get; set; } = null;
        public bool recycled { get; set; } = false;
        public int erMin { get; set; } = 0;
        public int erMax { get; set; } = 0;
        public int crMin { get; set; } = 0;
        public int crMax { get; set; } = 0;
        public int cdMin { get; set; } = 0;
        public int cdMax { get; set; } = 0;
        public int drMin { get; set; } = 0;
        public int drMax { get; set; } = 0;
        public int flMin { get; set; } = 0;
        public int flMax { get; set; } = 0;
        public int hrMin { get; set; } = 0;
        public int hrMax { get; set; } = 0;
        public int maMin { get; set; } = 0;
        public int maMax { get; set; } = 0;
        public int peMin { get; set; } = 0;
        public int peMax { get; set; } = 0;
        public int oqMin { get; set; } = 0;
        public int oqMax { get; set; } = 0;
        public int srMin { get; set; } = 0;
        public int srMax { get; set; } = 0;
        public int utMin { get; set; } = 0;
        public int utMax { get; set; } = 0;
        public string container { get; set; } = null;
        public string key { get; set; }

        // Calculated Fields
        public string name
        {
            get
            {
                if (typeID == -1)
                    return "Any";
                if (class7 != null)
                    return class7;
                if (class6 != null)
                    return class6;
                if (class5 != null)
                    return class5;
                if (class4 != null)
                    return class4;
                if (class3 != null)
                    return class3;
                if (class2 != null)
                    return class2;
                return class1;
            }
        }

        // Overrides
        public override string ToString()
        {
            return name;
        }
    }
}
