using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwgEmuTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashScreen splash = new SplashScreen();
            splash.Show();

            splash.UpdateProgess("Loading Galaxies", 1);
            Application.DoEvents();
            GalaxyCollection.Initialize();

            splash.UpdateProgess("Loading Planets", 2);
            Application.DoEvents();
            PlanetCollection.Initialize();

            splash.UpdateProgess("Loading ResourceTypes", 3);
            Application.DoEvents();
            ResourceTypeCollection.Initialize();

            splash.UpdateProgess("Loading Schematic Templates", 4);
            Application.DoEvents();
            SchematicTemplateCollection.Initialize();

            splash.UpdateProgess("Loading Schematics", 5);
            Application.DoEvents();
            ProfessionCollection.Initialize();

            splash.UpdateProgess("Loading Loot Items", 6);
            Application.DoEvents();
            LootItemCollection.Initialize();

            splash.UpdateProgess("Loading Resources", 7);
            Application.DoEvents();
            ResourceCollection.Initialize();

            splash.UpdateProgess("Loading My Resources", 8);
            Application.DoEvents();
            MyResourcesCollection.Initialize();

            splash.UpdateProgess("Loading Inventory", 8);
            Application.DoEvents();
            InventoryCollection.Initialize();

            splash.Hide();
            splash.Dispose();

            Application.Run(new Form1());
        }
    }
}
