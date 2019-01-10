using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SwgEmuTool
{
    public partial class MyResourcesForm : Form, IForm
    {
        private bool initializing = false;
        private int galaxy = -1;
        private List<MyResource> dataCache = null;
        private int sortColumn = 0;
        private SortMode sortMode = SortMode.None;

        public int Galaxy
        {
            set
            {
                galaxy = value;
                dataCache = Form1.MyResources.GetResourcesByGalaxy(galaxy).OrderBy(r => r.SpawnName).ToList();

                AutoCompleteStringCollection list = new AutoCompleteStringCollection();
                list.AddRange(Form1.Resources.GetResourceNamesByGalaxy(galaxy).ToArray());
                txtSpawn.AutoCompleteCustomSource = list;
                txtSpawn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtSpawn.AutoCompleteSource = AutoCompleteSource.CustomSource;

                UpdateGridView();
            }
        }

        public MyResourcesForm()
        {
            initializing = true;

            InitializeComponent();

            Type dgvType = dataGridView1.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dataGridView1, true, null);

            List<ResourceType> groups = Form1.ResourceTypes.GetResourceGroups();
            groups.Insert(0, new ResourceType());
            cboGroupFilter.ComboBox.DataSource = groups;
            cboGroupFilter.ComboBox.ValueMember = "typeID";
            cboGroupFilter.ComboBox.DisplayMember = "name";

            List<ResourceType> types = Form1.ResourceTypes.GetResourceTypes();
            types.Insert(0, new ResourceType());
            cboTypeFilter.ComboBox.DataSource = types;
            cboTypeFilter.ComboBox.ValueMember = "typeID";
            cboTypeFilter.ComboBox.DisplayMember = "name";

            dataGridView1.AutoGenerateColumns = false;

            initializing = false;

            txtSpawn.Focus();
        }

        private void UpdateGridView()
        {
            initializing = true;

            dataGridView1.DataSource = dataCache;

            initializing = false;
        }

        private void cboGroupFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!initializing)
            {
                if (cboGroupFilter.ComboBox.SelectedIndex != 0)
                {
                    if (cboGroupFilter.ComboBox.SelectedValue is ResourceType)
                        dataCache = Form1.MyResources.GetResourcesByGroup(((ResourceType)cboGroupFilter.ComboBox.SelectedValue).typeID, galaxy);
                    else
                        dataCache = Form1.MyResources.GetResourcesByGroup((int)cboGroupFilter.ComboBox.SelectedValue, galaxy);
                }
                UpdateGridView();
            }
        }

        private void cboTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!initializing)
            {
                if (cboTypeFilter.ComboBox.SelectedIndex != 0)
                {
                    if (cboTypeFilter.ComboBox.SelectedValue is ResourceType)
                        dataCache = Form1.MyResources.GetResourcesByType(((ResourceType)cboTypeFilter.ComboBox.SelectedValue).typeID, galaxy);
                    else
                        dataCache = Form1.MyResources.GetResourcesByType((int)cboTypeFilter.ComboBox.SelectedValue, galaxy);
                }
                UpdateGridView();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > dataCache.Count - 1)
                return;
            decimal perc = 0.0m;
            MyResource r = dataCache[e.RowIndex];
            if (Form1.ResourceTypes.GetResourceTypeByID(r.ResourceType).recycled)
                return;
            if (e.ColumnIndex > 2 && e.ColumnIndex < 14)
            {
                switch (e.ColumnIndex)
                {
                    case 3:
                        perc = r.Resource.ERPerc;
                        break;
                    case 4:
                        perc = r.Resource.CRPerc;
                        break;
                    case 5:
                        perc = r.Resource.CDPerc;
                        break;
                    case 6:
                        perc = r.Resource.DRPerc;
                        break;
                    case 7:
                        perc = r.Resource.FLPerc;
                        break;
                    case 8:
                        perc = r.Resource.HRPerc;
                        break;
                    case 9:
                        perc = r.Resource.MAPerc;
                        break;
                    case 10:
                        perc = r.Resource.PEPerc;
                        break;
                    case 11:
                        perc = r.Resource.OQPerc;
                        break;
                    case 12:
                        perc = r.Resource.SRPerc;
                        break;
                    case 13:
                        perc = r.Resource.UTPerc;
                        break;
                }
            }

            if (perc > 90)
                e.CellStyle.BackColor = Color.FromArgb(204, 255, 204);
            if (perc > 96)
            {
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.BackColor = Color.FromArgb(0, 128, 0);
            }
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

        private void DoSort()
        {
            switch (sortColumn)
            {
                case 0:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Resource.ResourceTypeName).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Resource.ResourceTypeName).ToList();
                    break;
                case 1:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.SpawnName).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.SpawnName).ToList();
                    break;
                case 2:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Filter).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Filter).ToList();
                    break;
                case 3:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Resource.ER).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Resource.ER).ToList();
                    break;
                case 4:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Resource.CR).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Resource.CR).ToList();
                    break;
                case 5:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Resource.CD).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Resource.CD).ToList();
                    break;
                case 6:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Resource.DR).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Resource.DR).ToList();
                    break;
                case 7:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Resource.FL).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Resource.FL).ToList();
                    break;
                case 8:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Resource.HR).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Resource.HR).ToList();
                    break;
                case 9:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Resource.MA).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Resource.MA).ToList();
                    break;
                case 10:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Resource.PE).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Resource.PE).ToList();
                    break;
                case 11:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Resource.OQ).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Resource.OQ).ToList();
                    break;
                case 12:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Resource.SR).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Resource.SR).ToList();
                    break;
                case 13:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Resource.UT).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Resource.UT).ToList();
                    break;
                case 14:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Units).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Units).ToList();
                    break;
                case 15:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Generic).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Generic).ToList();
                    break;
                case 16:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.CPU).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.CPU).ToList();
                    break;
            }

            UpdateGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!initializing)
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    Form1.MyResources.RemoveResource(dataCache[e.RowIndex].SpawnName, galaxy);
                    dataCache = Form1.MyResources.GetResourcesByGalaxy(galaxy).OrderByDescending(r => r.SpawnName).ToList();
                    DoSort();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSpawn.Text) && !string.IsNullOrEmpty(txtUnits.Text))
            {
                Resource res = Form1.Resources.GetResourceByName(txtSpawn.Text, galaxy);
                if (res != null)
                {
                    Form1.MyResources.AddResource(res, int.Parse(txtUnits.Text), chkFilter.Checked, chkGeneric.Checked, decimal.Parse(txtCPU.Text));

                    dataCache = Form1.MyResources.GetResourcesByGalaxy(galaxy).OrderBy(r => r.SpawnName).ToList();
                    DoSort();
                }
                else
                    MessageBox.Show("Unknown Resource", "Unknown Resource", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtSpawn.Focus();
        }

        private void SelectAll(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!initializing)
            {
                MyResource item = null;
                switch(e.ColumnIndex)
                {
                    case 2:
                        item = dataCache[e.RowIndex];
                        item.Filter = (bool)dataGridView1.Rows[e.RowIndex].Cells["Filter"].Value;
                        Form1.MyResources.isDirty = true;
                        break;
                    case 14:
                        item = dataCache[e.RowIndex];
                        item.Units = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Units"].Value.ToString());
                        Form1.MyResources.isDirty = true;
                        break;
                    case 15:
                        item = dataCache[e.RowIndex];
                        item.Generic = (bool)dataGridView1.Rows[e.RowIndex].Cells["Generic"].Value;
                        Form1.MyResources.isDirty = true;
                        break;
                    case 16:
                        item = dataCache[e.RowIndex];
                        item.CPU = decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells["CPU"].Value.ToString());
                        Form1.MyResources.isDirty = true;
                        break;
                }
            }
        }
    }
}
