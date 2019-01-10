namespace SwgEmuTool
{
    partial class MyResourcesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboGroupFilter = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cboTypeFilter = new System.Windows.Forms.ToolStripComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ResourceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpawnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Generic = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkGeneric = new System.Windows.Forms.CheckBox();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpawn = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cboGroupFilter,
            this.toolStripLabel2,
            this.cboTypeFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1003, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "Group:";
            // 
            // cboGroupFilter
            // 
            this.cboGroupFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboGroupFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboGroupFilter.Name = "cboGroupFilter";
            this.cboGroupFilter.Size = new System.Drawing.Size(121, 25);
            this.cboGroupFilter.SelectedIndexChanged += new System.EventHandler(this.cboGroupFilter_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "Type:";
            // 
            // cboTypeFilter
            // 
            this.cboTypeFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTypeFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTypeFilter.Name = "cboTypeFilter";
            this.cboTypeFilter.Size = new System.Drawing.Size(121, 25);
            this.cboTypeFilter.SelectedIndexChanged += new System.EventHandler(this.cboTypeFilter_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResourceType,
            this.SpawnName,
            this.Filter,
            this.ER,
            this.CR,
            this.CD,
            this.DR,
            this.FL,
            this.HR,
            this.MA,
            this.PE,
            this.OQ,
            this.SR,
            this.UT,
            this.Units,
            this.Generic,
            this.CPU,
            this.Del});
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 349);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // ResourceType
            // 
            this.ResourceType.DataPropertyName = "ResourceTypeName";
            this.ResourceType.Frozen = true;
            this.ResourceType.HeaderText = "Type";
            this.ResourceType.Name = "ResourceType";
            this.ResourceType.ReadOnly = true;
            this.ResourceType.Width = 170;
            // 
            // SpawnName
            // 
            this.SpawnName.DataPropertyName = "SpawnName";
            this.SpawnName.Frozen = true;
            this.SpawnName.HeaderText = "Name";
            this.SpawnName.Name = "SpawnName";
            this.SpawnName.ReadOnly = true;
            this.SpawnName.Width = 85;
            // 
            // Filter
            // 
            this.Filter.DataPropertyName = "Filter";
            this.Filter.HeaderText = "Flt";
            this.Filter.Name = "Filter";
            this.Filter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Filter.Width = 25;
            // 
            // ER
            // 
            this.ER.DataPropertyName = "ER";
            this.ER.HeaderText = "ER";
            this.ER.Name = "ER";
            this.ER.ReadOnly = true;
            this.ER.Width = 45;
            // 
            // CR
            // 
            this.CR.DataPropertyName = "CR";
            this.CR.HeaderText = "CR";
            this.CR.Name = "CR";
            this.CR.ReadOnly = true;
            this.CR.Width = 45;
            // 
            // CD
            // 
            this.CD.DataPropertyName = "CD";
            this.CD.HeaderText = "CD";
            this.CD.Name = "CD";
            this.CD.ReadOnly = true;
            this.CD.Width = 45;
            // 
            // DR
            // 
            this.DR.DataPropertyName = "DR";
            this.DR.HeaderText = "DR";
            this.DR.Name = "DR";
            this.DR.ReadOnly = true;
            this.DR.Width = 45;
            // 
            // FL
            // 
            this.FL.DataPropertyName = "FL";
            this.FL.HeaderText = "FL";
            this.FL.Name = "FL";
            this.FL.ReadOnly = true;
            this.FL.Width = 45;
            // 
            // HR
            // 
            this.HR.DataPropertyName = "HR";
            this.HR.HeaderText = "HR";
            this.HR.Name = "HR";
            this.HR.ReadOnly = true;
            this.HR.Width = 45;
            // 
            // MA
            // 
            this.MA.DataPropertyName = "MA";
            this.MA.HeaderText = "MA";
            this.MA.Name = "MA";
            this.MA.ReadOnly = true;
            this.MA.Width = 45;
            // 
            // PE
            // 
            this.PE.DataPropertyName = "PE";
            this.PE.HeaderText = "PE";
            this.PE.Name = "PE";
            this.PE.ReadOnly = true;
            this.PE.Width = 45;
            // 
            // OQ
            // 
            this.OQ.DataPropertyName = "OQ";
            this.OQ.HeaderText = "OQ";
            this.OQ.Name = "OQ";
            this.OQ.ReadOnly = true;
            this.OQ.Width = 45;
            // 
            // SR
            // 
            this.SR.DataPropertyName = "SR";
            this.SR.HeaderText = "SR";
            this.SR.Name = "SR";
            this.SR.ReadOnly = true;
            this.SR.Width = 45;
            // 
            // UT
            // 
            this.UT.DataPropertyName = "UT";
            this.UT.HeaderText = "UT";
            this.UT.Name = "UT";
            this.UT.ReadOnly = true;
            this.UT.Width = 45;
            // 
            // Units
            // 
            this.Units.DataPropertyName = "Units";
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            this.Units.Width = 55;
            // 
            // Generic
            // 
            this.Generic.DataPropertyName = "Generic";
            this.Generic.HeaderText = "Gen";
            this.Generic.Name = "Generic";
            this.Generic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Generic.Width = 25;
            // 
            // CPU
            // 
            this.CPU.DataPropertyName = "CPU";
            this.CPU.HeaderText = "CPU";
            this.CPU.Name = "CPU";
            this.CPU.Width = 55;
            // 
            // Del
            // 
            this.Del.HeaderText = "Del";
            this.Del.Name = "Del";
            this.Del.Text = "Del";
            this.Del.UseColumnTextForButtonValue = true;
            this.Del.Width = 30;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(505, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCPU
            // 
            this.txtCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCPU.Location = new System.Drawing.Point(453, 385);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(46, 20);
            this.txtCPU.TabIndex = 16;
            this.txtCPU.TabStop = false;
            this.txtCPU.Text = "1.00";
            this.txtCPU.Enter += new System.EventHandler(this.SelectAll);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "CPU: ";
            // 
            // chkGeneric
            // 
            this.chkGeneric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkGeneric.AutoSize = true;
            this.chkGeneric.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkGeneric.Checked = true;
            this.chkGeneric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGeneric.Location = new System.Drawing.Point(343, 387);
            this.chkGeneric.Name = "chkGeneric";
            this.chkGeneric.Size = new System.Drawing.Size(63, 17);
            this.chkGeneric.TabIndex = 14;
            this.chkGeneric.TabStop = false;
            this.chkGeneric.Text = "Generic";
            this.chkGeneric.UseVisualStyleBackColor = true;
            // 
            // chkFilter
            // 
            this.chkFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkFilter.AutoSize = true;
            this.chkFilter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFilter.Checked = true;
            this.chkFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFilter.Location = new System.Drawing.Point(289, 387);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(48, 17);
            this.chkFilter.TabIndex = 13;
            this.chkFilter.TabStop = false;
            this.chkFilter.Text = "Filter";
            this.chkFilter.UseVisualStyleBackColor = true;
            // 
            // txtUnits
            // 
            this.txtUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUnits.Location = new System.Drawing.Point(230, 385);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(53, 20);
            this.txtUnits.TabIndex = 12;
            this.txtUnits.Enter += new System.EventHandler(this.SelectAll);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Units: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name: ";
            // 
            // txtSpawn
            // 
            this.txtSpawn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSpawn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSpawn.Location = new System.Drawing.Point(59, 385);
            this.txtSpawn.Name = "txtSpawn";
            this.txtSpawn.Size = new System.Drawing.Size(122, 20);
            this.txtSpawn.TabIndex = 9;
            this.txtSpawn.Enter += new System.EventHandler(this.SelectAll);
            // 
            // MyResourcesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 410);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkGeneric);
            this.Controls.Add(this.chkFilter);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSpawn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MyResourcesForm";
            this.Text = "MyResourcesForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboGroupFilter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cboTypeFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkGeneric;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpawn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpawnName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Filter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FL;
        private System.Windows.Forms.DataGridViewTextBoxColumn HR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SR;
        private System.Windows.Forms.DataGridViewTextBoxColumn UT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Generic;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
    }
}