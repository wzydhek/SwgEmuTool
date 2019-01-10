using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Reflection;

namespace SwgEmuTool
{
    public partial class Form1 : Form
    {
        public static GalaxyCollection Galaxies { get; set; } = new GalaxyCollection();
        public static PlanetCollection Planets { get; set; } = new PlanetCollection();
        public static ResourceTypeCollection ResourceTypes { get; set; } = new ResourceTypeCollection();
        public static ProfessionCollection Professions { get; set; } = new ProfessionCollection();
        public static LootItemCollection LootItems { get; set; } = new LootItemCollection();
        public static SchematicTemplateCollection Templates { get; set; } = new SchematicTemplateCollection();
        public static ResourceCollection Resources { get; set; } = new ResourceCollection();
        public static MyResourcesCollection MyResources { get; set; } = new MyResourcesCollection();
        public static InventoryCollection Inventory { get; set; } = new InventoryCollection();

        public Form1()
        {
            InitializeComponent();

            //SchematicTemplateCollection.Initialize();

            cboGalaxy.ComboBox.DataSource = Galaxies.Galaxies;
            cboGalaxy.ComboBox.ValueMember = "ID";
            cboGalaxy.ComboBox.DisplayMember = "Name";
            cboGalaxy.ComboBox.SelectedIndex = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                foreach (Form form in this.MdiChildren)
                {
                    form.Dispose();
                }
            }

            Resources.Dispose();
            MyResources.Dispose();
            Inventory.Dispose();

            Environment.Exit(0);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MyResources m = new MyResources();
            //m.Initialize();
        }

        private void updateResourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Galaxy g in Galaxies.Galaxies)
            {
                List<GHResource> ghresources = new List<GHResource>();
                if (g.GHID == 0)
                    continue;
                string text = util.GetWebString(string.Format("http://galaxyharvester.net/exports/current{0}.xml", g.GHID));
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(text);
                XmlNodeList nodes = doc.ChildNodes[1].ChildNodes;
                foreach (XmlNode node in nodes)
                {
                    ghresources.Add(new GHResource(node));
                }

                List<string> resnames = Resources.GetActiveResourceNamesByGalaxy(g.ID);
                List<string> ghresnames = new List<string>();
                foreach (GHResource res in ghresources)
                {
                    ghresnames.Add(res.name.ToLower());
                }

                foreach (string resname in resnames)
                {
                    if (!ghresnames.Contains(resname.ToLower()))
                    {
                        Resource row = Resources.GetResourceByName(resname, g.ID);
                        row.Unavailable = DateTime.Now;
                    }
                }

                resnames = Resources.GetResourceNamesByGalaxy(g.ID);
                foreach (GHResource ghres in ghresources)
                {
                    if (resnames.Contains(ghres.name.ToLower()))
                    {
                        Resource row = Resources.GetResourceByName(ghres.name, g.ID);
                        row.Entered = ghres.entered;
                        if (row.ResourceType != ghres.resourceType)
                            row.ResourceType = ghres.resourceType;
                        row.ER = ghres.er;
                        row.CR = ghres.cr;
                        row.CD = ghres.cd;
                        row.DR = ghres.dr;
                        row.FL = ghres.fl;
                        row.HR = ghres.hr;
                        row.MA = ghres.ma;
                        row.PE = ghres.pe;
                        row.OQ = ghres.oq;
                        row.SR = ghres.sr;
                        row.UT = ghres.ut;

                        foreach (string planet in ghres.planets)
                        {
                            if (!row.Planets.Contains(planet))
                            {
                                row.Planets.Add(planet);
                            }
                        }
                    }
                    else
                    {
                        Resource row = new Resource();
                        row.SpawnName = ghres.name;
                        row.Galaxy = g.ID;
                        row.Entered = ghres.entered;
                        row.Unavailable = null;
                        row.ResourceType = ghres.resourceType;
                        row.ER = ghres.er;
                        row.CR = ghres.cr;
                        row.CD = ghres.cd;
                        row.DR = ghres.dr;
                        row.FL = ghres.fl;
                        row.HR = ghres.hr;
                        row.MA = ghres.ma;
                        row.PE = ghres.pe;
                        row.OQ = ghres.oq;
                        row.SR = ghres.sr;
                        row.UT = ghres.ut;

                        foreach (string planet in ghres.planets)
                        {
                            row.Planets.Add(planet);
                        }
                        Resources.Resources.Add(row);
                    }
                }
            }
            Resources.isDirty = true;

            cboGalaxy_SelectedIndexChanged(this, null);

            //Resources.SaveResources();
        }

        public void cboGalaxy_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (IForm form in MdiChildren)
            {
                form.Galaxy = (int)cboGalaxy.ComboBox.SelectedValue;
            }
        }

        private void allResourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is ResourcesForm)
                {
                    frm.Activate();
                    return;
                }
            }
            ResourcesForm form = new ResourcesForm();
            form.MdiParent = this;
            form.Show();
            form.Galaxy = (int)cboGalaxy.ComboBox.SelectedValue;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            exitToolStripMenuItem_Click(this, null);
        }

        private void myResourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is MyResourcesForm)
                {
                    frm.Activate();
                    return;
                }
            }
            MyResourcesForm form = new MyResourcesForm();
            form.MdiParent = this;
            form.Show();
            form.Galaxy = (int)cboGalaxy.ComboBox.SelectedValue;
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is InventoryForm)
                {
                    frm.Activate();
                    return;
                }
            }
            InventoryForm form = new InventoryForm();
            form.MdiParent = this;
            form.Show();
            form.Galaxy = (int)cboGalaxy.ComboBox.SelectedValue;
        }
    }
}
