using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwgEmuTool
{
    public partial class InventoryForm : Form, IForm
    {
        private bool initializing = false;
        private int galaxy = -1;
        List<InventoryItem> dataCache = new List<InventoryItem>();
        private int sortColumn = 0;
        private SortMode sortMode = SortMode.None;

        public int Galaxy
        {
            set
            {
                galaxy = value;
                dataCache = Form1.Inventory.GetInventoryByGalaxy(galaxy).OrderBy(r => r.Name).ToList();
                UpdateGridView();
            }
        }

        public InventoryForm()
        {
            initializing = true;

            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            cboType.SelectedIndex = 0;
            cboTypeFilter.SelectedIndex = 0;

            initializing = false;
        }

        private void UpdateGridView()
        {
            initializing = true;

            dataGridView1.DataSource = dataCache;

            initializing = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Form1.Inventory.RemoveItem(dataCache[e.RowIndex]);
                dataCache = Form1.Inventory.GetInventoryByGalaxy(galaxy).OrderBy(r => r.Name).ToList();
                UpdateGridView();
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboType.SelectedIndex)
            {
                case 0:
                    {
                        AutoCompleteStringCollection list = new AutoCompleteStringCollection();
                        List<Schematic> items = Form1.Professions.GetComponents();
                        List<string> itemnames = new List<string>();
                        foreach (Schematic s in items)
                            itemnames.Add(s.Name);
                        list.AddRange(itemnames.ToArray());
                        txtItem.AutoCompleteCustomSource = list;
                        txtItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        txtItem.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    }
                    break;
                case 1:
                    {
                        AutoCompleteStringCollection list = new AutoCompleteStringCollection();
                        List<LootItem> items = Form1.LootItems.GetList();
                        List<string> itemnames = new List<string>();
                        foreach (LootItem s in items)
                            itemnames.Add(s.LootItemName);
                        list.AddRange(itemnames.ToArray());
                        txtItem.AutoCompleteCustomSource = list;
                        txtItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        txtItem.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    }
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1.Inventory.AddItem(txtItem.Text, txtSerial.Text, int.Parse(txtQuantity.Text), txtAttr.Text, galaxy);
            dataCache = Form1.Inventory.GetInventoryByGalaxy(galaxy).OrderBy(r => r.Name).ToList();
            UpdateGridView();
        }

        private void DoSort()
        {
            switch (sortColumn)
            {
                case 0:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Name).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Name).ToList();
                    break;
                case 1:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Serial).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Serial).ToList();
                    break;
                case 2:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Quantity).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Quantity).ToList();
                    break;
                case 3:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Attributes).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Attributes).ToList();
                    break;
            }

            UpdateGridView();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == sortColumn)
            {
                if (sortMode == SortMode.Asc)
                {
                    sortMode = SortMode.Desc;
                }
                else
                {
                    sortMode = SortMode.Asc;
                }
            }
            else
            {
                sortColumn = e.ColumnIndex;
                sortMode = SortMode.Asc;
            }

            DoSort();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!initializing)
            {
                if (e.ColumnIndex == 1)
                {
                    InventoryItem item = dataCache[e.RowIndex];
                    item.Serial = dataGridView1.Rows[e.RowIndex].Cells["Serial"].Value.ToString();
                    Form1.Inventory.isDirty = true;
                }
                else if (e.ColumnIndex == 2)
                {
                    InventoryItem item = dataCache[e.RowIndex];
                    item.Quantity = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString());
                    Form1.Inventory.isDirty = true;
                }
            }
        }

        private void SelectAll(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void cboTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!initializing)
            {
                switch (cboTypeFilter.SelectedIndex)
                {
                    case 0:
                        dataCache = Form1.Inventory.GetInventoryByGalaxy(galaxy).OrderBy(r => r.Name).ToList();
                        break;
                    case 1:
                        dataCache = Form1.Inventory.GetComponentItems(galaxy).OrderBy(r => r.Name).ToList();
                        break;
                    case 2:
                        dataCache = Form1.Inventory.GetLootItems(galaxy).OrderBy(r => r.Name).ToList();
                        break;
                }

                DoSort();
            }
        }
    }
}
