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
    public class SchematicTemplateCollection
    {
        public List<SchematicTemplate> Templates { get; set; } = new List<SchematicTemplate>();

        public static void Initialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SchematicTemplateCollection));
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SwgEmuTool.xml.SchematicTemplateData.xml"))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    Form1.Templates = (SchematicTemplateCollection)serializer.Deserialize(sr);
                }
            }
        }

        public SchematicTemplate GetTemplateByID(string id)
        {
            return Templates.FirstOrDefault(s => s.TemplateName == id);
        }

        public SchematicTemplate GetTemplateByItem(string id)
        {
            return Templates.FirstOrDefault(s => s.ItemID == id);
        }

        //public List<SchematicTemplate> GetTemplateItems(string id)
        //{
        //    List<SchematicTemplate> result = new List<SchematicTemplate>();

        //    foreach (SchematicTemplate t in Templates)
        //    {
        //        if (t.TemplateName == id)
        //            result.Add(t);
        //    }

        //    return result;
        //}
    }

    [Serializable]
    public class SchematicTemplate
    {
        // XML Fields
        public string TemplateName { get; set; }
        public string ItemID { get; set; }

        // Overrides
        public override string ToString()
        {
            return string.Format("{0}:{1}", TemplateName, ItemID);
        }
    }
}
