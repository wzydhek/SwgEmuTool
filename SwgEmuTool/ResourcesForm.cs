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
    public enum SortMode
    {
        None,
        Asc,
        Desc
    }

    public partial class ResourcesForm : Form, IForm
    {
        private bool initializing = false;
        private int galaxy = -1;
        private List<Resource> dataCache = null;
        private int sortColumn = 0;
        private SortMode sortMode = SortMode.None;

        public int Galaxy
        {
            set
            {
                galaxy = value;
                dataCache = Form1.Resources.GetResourcesByGalaxy(galaxy).OrderByDescending(r => r.Entered).ToList();
                UpdateGridView();
            }
        }

        public ResourcesForm()
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

            List<ResourceType> types2 = Form1.ResourceTypes.GetResourceTypes();
            cboResourceType.DataSource = types2;
            cboResourceType.ValueMember = "typeID";
            cboResourceType.DisplayMember = "name";

            dataGridView1.AutoGenerateColumns = false;

            initializing = false;
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
                        dataCache = Form1.Resources.GetResourcesByGroup(((ResourceType)cboGroupFilter.ComboBox.SelectedValue).typeID, galaxy);
                    else
                        dataCache = Form1.Resources.GetResourcesByGroup((int)cboGroupFilter.ComboBox.SelectedValue, galaxy);
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
                        dataCache = Form1.Resources.GetResourcesByType(((ResourceType)cboTypeFilter.ComboBox.SelectedValue).typeID, galaxy);
                    else
                        dataCache = Form1.Resources.GetResourcesByType((int)cboTypeFilter.ComboBox.SelectedValue, galaxy);
                }
                UpdateGridView();
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

            switch (sortColumn)
            {
                case 0:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.ResourceTypeName).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.ResourceTypeName).ToList();
                    break;
                case 1:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.SpawnName).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.SpawnName).ToList();
                    break;
                case 2:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.ER).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.ER).ToList();
                    break;
                case 3:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.CR).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.CR).ToList();
                    break;
                case 4:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.CD).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.CD).ToList();
                    break;
                case 5:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.DR).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.DR).ToList();
                    break;
                case 6:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.FL).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.FL).ToList();
                    break;
                case 7:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.HR).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.HR).ToList();
                    break;
                case 8:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.MA).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.MA).ToList();
                    break;
                case 9:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.PE).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.PE).ToList();
                    break;
                case 10:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.OQ).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.OQ).ToList();
                    break;
                case 11:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.SR).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.SR).ToList();
                    break;
                case 12:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.UT).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.UT).ToList();
                    break;
                case 13:
                    if (sortMode == SortMode.Asc)
                        dataCache = dataCache.OrderBy(r => r.Entered).ToList();
                    else if (sortMode == SortMode.Desc)
                        dataCache = dataCache.OrderByDescending(r => r.Entered).ToList();
                    break;
            }

            UpdateGridView();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            decimal perc = 0.0m;
            Resource r = dataCache[e.RowIndex];
            if (Form1.ResourceTypes.GetResourceTypeByID(r.ResourceType).recycled)
                return;
            if (e.ColumnIndex == 13)
            {
                if (r.Unavailable == null)
                    e.CellStyle.BackColor = Color.FromArgb(225, 225, 255);
            }
            else
            {
                if (e.ColumnIndex > 1 && e.ColumnIndex < 13)
                {
                    switch (e.ColumnIndex)
                    {
                        case 2:
                            perc = r.ERPerc;
                            break;
                        case 3:
                            perc = r.CRPerc;
                            break;
                        case 4:
                            perc = r.CDPerc;
                            break;
                        case 5:
                            perc = r.DRPerc;
                            break;
                        case 6:
                            perc = r.FLPerc;
                            break;
                        case 7:
                            perc = r.HRPerc;
                            break;
                        case 8:
                            perc = r.MAPerc;
                            break;
                        case 9:
                            perc = r.PEPerc;
                            break;
                        case 10:
                            perc = r.OQPerc;
                            break;
                        case 11:
                            perc = r.SRPerc;
                            break;
                        case 12:
                            perc = r.UTPerc;
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
        }

        private void cboResourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtER.Enabled = false;
            txtCR.Enabled = false;
            txtCD.Enabled = false;
            txtDR.Enabled = false;
            txtFL.Enabled = false;
            txtHR.Enabled = false;
            txtMA.Enabled = false;
            txtPE.Enabled = false;
            txtOQ.Enabled = false;
            txtSR.Enabled = false;
            txtUT.Enabled = false;

            ResourceType type = null;
            if (cboResourceType.SelectedValue is int)
                type = Form1.ResourceTypes.GetResourceTypeByID((int)cboResourceType.SelectedValue);
            else
                type = Form1.ResourceTypes.GetResourceTypeByID(((ResourceType)cboResourceType.SelectedValue).typeID);

            if (type.erMax > 0)
            {
                txtER.Enabled = true;
                txtER.Text = "0";
            }
            if (type.crMax > 0)
            {
                txtCR.Enabled = true;
                txtCR.Text = "0";
            }
            if (type.cdMax > 0)
            {
                txtCD.Enabled = true;
                txtCD.Text = "0";
            }
            if (type.drMax > 0)
            {
                txtDR.Enabled = true;
                txtDR.Text = "0";
            }
            if (type.flMax > 0)
            {
                txtFL.Enabled = true;
                txtFL.Text = "0";
            }
            if (type.hrMax > 0)
            {
                txtHR.Enabled = true;
                txtHR.Text = "0";
            }
            if (type.maMax > 0)
            {
                txtMA.Enabled = true;
                txtMA.Text = "0";
            }
            if (type.peMax > 0)
            {
                txtPE.Enabled = true;
                txtPE.Text = "0";
            }
            if (type.oqMax > 0)
            {
                txtOQ.Enabled = true;
                txtOQ.Text = "0";
            }
            if (type.srMax > 0)
            {
                txtSR.Enabled = true;
                txtSR.Text = "0";
            }
            if (type.utMax > 0)
            {
                txtUT.Enabled = true;
                txtUT.Text = "0";
            }
        }

        private void SelectAll(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSpawnName.Text))
            {
                ResourceType type = null;
                if (cboResourceType.SelectedValue is int)
                    type = Form1.ResourceTypes.GetResourceTypeByID((int)cboResourceType.SelectedValue);
                else
                    type = Form1.ResourceTypes.GetResourceTypeByID(((ResourceType)cboResourceType.SelectedValue).typeID);

                Resource res = new Resource();
                res.SpawnName = txtSpawnName.Text;
                res.Galaxy = galaxy;
                res.ResourceType = type.typeID;
                res.Entered = DateTime.Today;
                if (txtER.Enabled)
                    res.ER = int.Parse(txtER.Text);
                if (txtCR.Enabled)
                    res.CR = int.Parse(txtCR.Text);
                if (txtCD.Enabled)
                    res.CD = int.Parse(txtCD.Text);
                if (txtDR.Enabled)
                    res.DR = int.Parse(txtDR.Text);
                if (txtFL.Enabled)
                    res.FL = int.Parse(txtFL.Text);
                if (txtHR.Enabled)
                    res.HR = int.Parse(txtHR.Text);
                if (txtMA.Enabled)
                    res.MA = int.Parse(txtMA.Text);
                if (txtPE.Enabled)
                    res.PE = int.Parse(txtPE.Text);
                if (txtOQ.Enabled)
                    res.OQ = int.Parse(txtOQ.Text);
                if (txtSR.Enabled)
                    res.SR = int.Parse(txtSR.Text);
                if (txtUT.Enabled)
                    res.UT = int.Parse(txtUT.Text);

                Form1.Resources.Add(res);
                dataCache = Form1.Resources.Resources.OrderByDescending(r => r.Entered).ToList();

                UpdateGridView();
            }
        }
    }
}
