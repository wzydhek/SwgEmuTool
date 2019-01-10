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
    public class InventoryCollection : IDisposable
    {
        public List<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();

        [XmlIgnore]
        public bool isDirty = true;

        public static void Initialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(InventoryCollection));

            if (!File.Exists("InventoryData.xml"))
            {
                TextWriter writer = new StreamWriter("InventoryData.xml");
                serializer.Serialize(writer, Form1.Inventory);
                writer.Close();
            }

            using (Stream stream = new FileStream("InventoryData.xml", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    Form1.Inventory = (InventoryCollection)serializer.Deserialize(sr);
                }
            }
            Form1.Inventory.isDirty = false;
        }

        public List<InventoryItem> GetInventoryByGalaxy(int galaxy)
        {
            return InventoryItems.Where(i => i.Galaxy == galaxy).ToList();
        }

        public List<InventoryItem> GetComponentItems(int galaxy)
        {
            List<Schematic> items = Form1.Professions.GetComponents();

            return InventoryItems.Where(i => i.IsComponent).ToList();
        }

        public List<InventoryItem> GetLootItems(int galaxy)
        {
            List<LootItem> items = Form1.LootItems.GetList();

            return InventoryItems.Where(i => i.IsLoot).ToList();
        }

        public InventoryItem GetItemByName(string name, string serial, int galaxy)
        {
            return InventoryItems.FirstOrDefault(i => i.Galaxy == galaxy && i.Name.ToLower() == name.ToLower() && i.Serial.ToLower() == serial.ToLower());
        }

        public void RemoveItem(InventoryItem item)
        {
            InventoryItems.Remove(item);
            isDirty = true;
        }

        public void AddItem(string itemName, string serial, int quantity, string attr, int galaxy)
        {
            InventoryItem item = GetItemByName(itemName, serial, galaxy);
            if (item != null)
            {
                item.Serial = serial;
                item.Attributes = attr;
                item.Quantity += quantity;
                isDirty = true;
            }
            else
            {
                Schematic s = Form1.Professions.GetSchematicByName(itemName);
                if (s != null)
                {
                    InventoryItem i = new InventoryItem();
                    i.ID = s.ID.ToString();
                    i.Serial = serial;
                    i.Attributes = attr;
                    i.Quantity = quantity;
                    i.Galaxy = galaxy;
                    InventoryItems.Add(i);
                    isDirty = true;
                }
                else
                {
                    LootItem li = Form1.LootItems.GetLootItemByName(itemName.ToLower());
                    if (li != null)
                    {
                        InventoryItem i = new InventoryItem();
                        i.ID = li.LootItemID;
                        i.Serial = serial;
                        i.Attributes = attr;
                        i.Quantity = quantity;
                        i.Galaxy = galaxy;
                        InventoryItems.Add(i);
                        isDirty = true;
                    }
                }
            }
        }

        public void Dispose()
        {
            if (isDirty)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(InventoryCollection));
                TextWriter writer = new StreamWriter("InventoryData.xml");
                serializer.Serialize(writer, this);
                writer.Close();
            }
        }
    }

    [Serializable]
    public class InventoryItem
    {
        // XML Fields
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                Schematic s = Form1.Professions.GetSchematicByID(ID);
                {
                    if (s != null)
                    {
                        Name = s.Name;
                        IsComponent = true;
                    }
                    else
                    {
                        LootItem l = Form1.LootItems.GetItemByID(ID);
                        Name = l.LootItemName;
                        IsLoot = true;
                    }
                }

            }
        }
        public int Galaxy { get; set; }
        public int Quantity { get; set; } = 1;
        public string Serial { get; set; } = null;
        public string Attributes { get; set; } = null;

        // Field Support
        private string id = null;

        // Internal Fields
        [XmlIgnore]
        public bool IsComponent { get; private set; } = false;
        [XmlIgnore]
        public bool IsLoot { get; private set; } = false;
        [XmlIgnore]
        public string Name { get; private set; } = null;

        // Overrides
        public override string ToString()
        {
            return Name;
        }
    }

}
