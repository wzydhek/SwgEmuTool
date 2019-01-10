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
    public enum SlotType
    {
        Resource = 0,
        Identical,
        Mixed,
        OptionalIdentical,
        OptionalMixed
    }

    public enum Stat
    {
        ER,
        CR,
        CD,
        DR,
        FL,
        HR,
        MA,
        PE,
        OQ,
        SR,
        UT
    }

    [Serializable]
    public class ProfessionCollection
    {
        public List<Profession> Professions { get; set; } = new List<Profession>();

        [XmlIgnore]
        public List<Schematic> Schematics { get; set; } = new List<Schematic>();

        public static void Initialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ProfessionCollection));
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SwgEmuTool.xml.SchematicData.xml"))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    Form1.Professions = (ProfessionCollection)serializer.Deserialize(sr);
                }
            }

            foreach (Profession p in Form1.Professions.Professions)
            {
                foreach (Skill s in p.Skills)
                {
                    foreach (Schematic sc in s.Schematics)
                    {
                        if (!Form1.Professions.Schematics.Contains(sc))
                            Form1.Professions.Schematics.Add(sc);
                    }
                }
            }


        }

        public Schematic GetSchematicByID(string id)
        {
            return Schematics.FirstOrDefault(s => s.ID == id);
        }

        public Schematic GetSchematicByName(string name)
        {
            return Schematics.FirstOrDefault(s => s.Name.ToLower() == name.ToLower());
        }

        public List<Schematic> GetComponents()
        {
            return Form1.Templates.Templates.Select(r => GetSchematicByID(r.ItemID)).Where(r => r != null).ToList();
        }

        public List<LootItem> GetLootItems()
        {
            return Form1.Templates.Templates.Select(r => Form1.LootItems.GetItemByID(r.ItemID)).ToList();
        }
    }

    [Serializable]
    public class Profession
    {
        // XML Fields
        public string ID { get; set; }
        public string Name { get; set; }
        public List<Skill> Skills { get; set; } = new List<Skill>();

        // Overrides
        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    public class Skill
    {
        // XML Fields
        public string ID { get; set; }
        public string Name { get; set; }
        public List<Schematic> Schematics { get; set; } = new List<Schematic>();

        // Overrides
        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    public class Schematic
    {
        // XML Fields
        public string ID { get; set; }
        public string Name { get; set; }
        //public long ToolTab { get; set; }
        //public int Complexity { get; set; }
        //public int Size { get; set; }
        //public int CrateSize { get; set; }
        //public string XPType { get; set; }
        //public int XP { get; set; }
        //public string AssemblySkill { get; set; }
        //public string CustomizationSkill { get; set; }
        //public string ExperimentingSkill { get; set; }
        //public string TargetTemplate { get; set; }
        //public List<SchematicCustomization> Customizations { get; set; } = new List<SchematicCustomization>();
        public List<SchematicIngredient> Ingredients { get; set; } = new List<SchematicIngredient>();
        public List<SchematicExpGroup> ExpGroups { get; set; } = new List<SchematicExpGroup>();

        // Overrides
        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    public class SchematicCustomization
    {
        // XML Fields
        public string Name { get; set; }
        public int Option { get; set; }
        public int Default { get; set; }

        // Overrides
        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    public class SchematicIngredient
    {
        // XML Fields
        public string Name { get; set; }
        //public string TemplateName { get; set; }
        public bool Identical { get; set; }
        public bool Optional { get; set; }
        public string ResourceType {
            get
            {
                return resourceTypeID;
            }
            set
            {
                resourceTypeID = value;
                resourceType = Form1.ResourceTypes.GetResourceTypeBySWGID(value);
            }
        }
        public int Quantity { get; set; }
        public int Contribution { get; set; }

        // Support Fields
        private string resourceTypeID;
        private ResourceType resourceType;

        // Internal Fields
        public bool IsResource
        {
            get
            {
                return resourceType != null;
            }
        }

        // Overrides
        public override string ToString()
        {
            return ResourceType;
        }
    }

    [Serializable]
    public class SchematicExpGroup
    {
        // XML Fields
        public string Name { get; set; }
        public List<SchematicExpProperty> Properties { get; set; } = new List<SchematicExpProperty>();

        // Overrides
        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    public class SchematicExpProperty
    {
        // XML Fields
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public int Precision { get; set; }
        public int Combine { get; set; }
        public List<SchematicExpStat> Stats { get; set; } = new List<SchematicExpStat>();

        // Overrides
        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    public class SchematicExpStat
    {
        // XML Fields
        public string ID { get; set; }
        public string Stat { get; set; }
        public int Weight { get; set; }

        //Overrides
        public override string ToString()
        {
            return Stat;
        }
    }
}
