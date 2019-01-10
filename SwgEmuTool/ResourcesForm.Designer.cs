namespace SwgEmuTool
{
    partial class ResourcesForm
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
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpawnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Entered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboResourceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpawnName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSR = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOQ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtER = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
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
            this.toolStrip1.Size = new System.Drawing.Size(942, 25);
            this.toolStrip1.TabIndex = 0;
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.SpawnName,
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
            this.Entered});
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(942, 381);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // Type
            // 
            this.Type.DataPropertyName = "ResourceTypeName";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 170;
            // 
            // SpawnName
            // 
            this.SpawnName.DataPropertyName = "SpawnName";
            this.SpawnName.HeaderText = "Name";
            this.SpawnName.Name = "SpawnName";
            this.SpawnName.ReadOnly = true;
            this.SpawnName.Width = 85;
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
            // Entered
            // 
            this.Entered.DataPropertyName = "Entered";
            this.Entered.HeaderText = "Entered";
            this.Entered.Name = "Entered";
            this.Entered.ReadOnly = true;
            this.Entered.Width = 130;
            // 
            // cboResourceType
            // 
            this.cboResourceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboResourceType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboResourceType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboResourceType.FormattingEnabled = true;
            this.cboResourceType.Location = new System.Drawing.Point(12, 428);
            this.cboResourceType.Name = "cboResourceType";
            this.cboResourceType.Size = new System.Drawing.Size(178, 21);
            this.cboResourceType.TabIndex = 1;
            this.cboResourceType.SelectedIndexChanged += new System.EventHandler(this.cboResourceType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resource Type";
            // 
            // txtSpawnName
            // 
            this.txtSpawnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSpawnName.Location = new System.Drawing.Point(196, 428);
            this.txtSpawnName.Name = "txtSpawnName";
            this.txtSpawnName.Size = new System.Drawing.Size(150, 20);
            this.txtSpawnName.TabIndex = 2;
            this.txtSpawnName.Enter += new System.EventHandler(this.SelectAll);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Spawn Name";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(721, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "UT";
            // 
            // txtUT
            // 
            this.txtUT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUT.Location = new System.Drawing.Point(724, 428);
            this.txtUT.Name = "txtUT";
            this.txtUT.Size = new System.Drawing.Size(31, 20);
            this.txtUT.TabIndex = 13;
            this.txtUT.Enter += new System.EventHandler(this.SelectAll);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(684, 412);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "SR";
            // 
            // txtSR
            // 
            this.txtSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSR.Location = new System.Drawing.Point(687, 428);
            this.txtSR.Name = "txtSR";
            this.txtSR.Size = new System.Drawing.Size(31, 20);
            this.txtSR.TabIndex = 12;
            this.txtSR.Enter += new System.EventHandler(this.SelectAll);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(647, 412);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "OQ";
            // 
            // txtOQ
            // 
            this.txtOQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOQ.Location = new System.Drawing.Point(650, 428);
            this.txtOQ.Name = "txtOQ";
            this.txtOQ.Size = new System.Drawing.Size(31, 20);
            this.txtOQ.TabIndex = 11;
            this.txtOQ.Enter += new System.EventHandler(this.SelectAll);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(610, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "PE";
            // 
            // txtPE
            // 
            this.txtPE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPE.Location = new System.Drawing.Point(613, 428);
            this.txtPE.Name = "txtPE";
            this.txtPE.Size = new System.Drawing.Size(31, 20);
            this.txtPE.TabIndex = 10;
            this.txtPE.Enter += new System.EventHandler(this.SelectAll);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(573, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "MA";
            // 
            // txtMA
            // 
            this.txtMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMA.Location = new System.Drawing.Point(576, 428);
            this.txtMA.Name = "txtMA";
            this.txtMA.Size = new System.Drawing.Size(31, 20);
            this.txtMA.TabIndex = 9;
            this.txtMA.Enter += new System.EventHandler(this.SelectAll);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "HR";
            // 
            // txtHR
            // 
            this.txtHR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHR.Location = new System.Drawing.Point(539, 428);
            this.txtHR.Name = "txtHR";
            this.txtHR.Size = new System.Drawing.Size(31, 20);
            this.txtHR.TabIndex = 8;
            this.txtHR.Enter += new System.EventHandler(this.SelectAll);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "FL";
            // 
            // txtFL
            // 
            this.txtFL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFL.Location = new System.Drawing.Point(502, 428);
            this.txtFL.Name = "txtFL";
            this.txtFL.Size = new System.Drawing.Size(31, 20);
            this.txtFL.TabIndex = 7;
            this.txtFL.Enter += new System.EventHandler(this.SelectAll);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "DR";
            // 
            // txtDR
            // 
            this.txtDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDR.Location = new System.Drawing.Point(465, 428);
            this.txtDR.Name = "txtDR";
            this.txtDR.Size = new System.Drawing.Size(31, 20);
            this.txtDR.TabIndex = 6;
            this.txtDR.Enter += new System.EventHandler(this.SelectAll);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "CD";
            // 
            // txtCD
            // 
            this.txtCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCD.Location = new System.Drawing.Point(428, 428);
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(31, 20);
            this.txtCD.TabIndex = 5;
            this.txtCD.Enter += new System.EventHandler(this.SelectAll);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "CR";
            // 
            // txtCR
            // 
            this.txtCR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCR.Location = new System.Drawing.Point(391, 428);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(31, 20);
            this.txtCR.TabIndex = 4;
            this.txtCR.Enter += new System.EventHandler(this.SelectAll);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "ER";
            // 
            // txtER
            // 
            this.txtER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtER.Location = new System.Drawing.Point(354, 428);
            this.txtER.Name = "txtER";
            this.txtER.Size = new System.Drawing.Size(31, 20);
            this.txtER.TabIndex = 3;
            this.txtER.Enter += new System.EventHandler(this.SelectAll);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdAdd.Location = new System.Drawing.Point(761, 426);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 14;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // ResourcesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtUT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSR);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtOQ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpawnName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboResourceType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ResourcesForm";
            this.Text = "ResourcesForm";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpawnName;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Entered;
        private System.Windows.Forms.ComboBox cboResourceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpawnName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOQ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtER;
        private System.Windows.Forms.Button cmdAdd;
    }
}