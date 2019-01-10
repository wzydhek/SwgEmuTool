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
    public class LootItemCollection
    {
        public List<LootItem> LootItems { get; set; } = new List<LootItem>();

        public static void Initialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(LootItemCollection));
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SwgEmuTool.xml.LootItemData.xml"))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    Form1.LootItems = (LootItemCollection)serializer.Deserialize(sr);
                }
            }
        }

        public List<LootItem> GetList()
        {
            return LootItems;
        }

        public LootItem GetItemByID(string id)
        {
            return LootItems.FirstOrDefault(l => l.LootItemID == id);
        }

        public LootItem GetLootItemByName(string name)
        {
            return LootItems.FirstOrDefault(l => l.LootItemName.ToLower() == name.ToLower());
        }
    }

    [Serializable]
    public class LootItem
    {
        // XML Fields
        public string LootItemID { get; set; }
        public string LootItemName { get; set; }

        // Overrides
        public override string ToString()
        {
            return LootItemName;
        }
    }
}
