namespace Post
{
    partial class AMCContractorGrid
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMCContractorGrid));
            this.amcGridView1 = new System.Windows.Forms.DataGridView();
            this.machineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfExpiryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMCAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amccontractor1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postDataSet = new Post.PostDataSet();
            this.searchgrpbox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.amcgridtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.amccontractor1TableAdapter = new Post.PostDataSetTableAdapters.amccontractor1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.amcGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amccontractor1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataSet)).BeginInit();
            this.searchgrpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // amcGridView1
            // 
            this.amcGridView1.AllowUserToOrderColumns = true;
            this.amcGridView1.AutoGenerateColumns = false;
            this.amcGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.amcGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.amcGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machineIDDataGridViewTextBoxColumn,
            this.machineNameDataGridViewTextBoxColumn,
            this.dateOfExpiryDataGridViewTextBoxColumn,
            this.aMCAmountDataGridViewTextBoxColumn,
            this.contractorIDDataGridViewTextBoxColumn,
            this.contractorNameDataGridViewTextBoxColumn});
            this.amcGridView1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.amcGridView1.DataSource = this.amccontractor1BindingSource;
            this.amcGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.amcGridView1.Location = new System.Drawing.Point(0, 147);
            this.amcGridView1.Name = "amcGridView1";
            this.amcGridView1.Size = new System.Drawing.Size(644, 242);
            this.amcGridView1.TabIndex = 20;
            // 
            // machineIDDataGridViewTextBoxColumn
            // 
            this.machineIDDataGridViewTextBoxColumn.DataPropertyName = "MachineID";
            this.machineIDDataGridViewTextBoxColumn.HeaderText = "MachineID";
            this.machineIDDataGridViewTextBoxColumn.Name = "machineIDDataGridViewTextBoxColumn";
            // 
            // machineNameDataGridViewTextBoxColumn
            // 
            this.machineNameDataGridViewTextBoxColumn.DataPropertyName = "MachineName";
            this.machineNameDataGridViewTextBoxColumn.HeaderText = "MachineName";
            this.machineNameDataGridViewTextBoxColumn.Name = "machineNameDataGridViewTextBoxColumn";
            // 
            // dateOfExpiryDataGridViewTextBoxColumn
            // 
            this.dateOfExpiryDataGridViewTextBoxColumn.DataPropertyName = "DateOfExpiry";
            this.dateOfExpiryDataGridViewTextBoxColumn.HeaderText = "DateOfExpiry";
            this.dateOfExpiryDataGridViewTextBoxColumn.Name = "dateOfExpiryDataGridViewTextBoxColumn";
            // 
            // aMCAmountDataGridViewTextBoxColumn
            // 
            this.aMCAmountDataGridViewTextBoxColumn.DataPropertyName = "AMCAmount";
            this.aMCAmountDataGridViewTextBoxColumn.HeaderText = "AMCAmount";
            this.aMCAmountDataGridViewTextBoxColumn.Name = "aMCAmountDataGridViewTextBoxColumn";
            // 
            // contractorIDDataGridViewTextBoxColumn
            // 
            this.contractorIDDataGridViewTextBoxColumn.DataPropertyName = "ContractorID";
            this.contractorIDDataGridViewTextBoxColumn.HeaderText = "ContractorID";
            this.contractorIDDataGridViewTextBoxColumn.Name = "contractorIDDataGridViewTextBoxColumn";
            // 
            // contractorNameDataGridViewTextBoxColumn
            // 
            this.contractorNameDataGridViewTextBoxColumn.DataPropertyName = "ContractorName";
            this.contractorNameDataGridViewTextBoxColumn.HeaderText = "ContractorName";
            this.contractorNameDataGridViewTextBoxColumn.Name = "contractorNameDataGridViewTextBoxColumn";
            // 
            // amccontractor1BindingSource
            // 
            this.amccontractor1BindingSource.DataMember = "amccontractor1";
            this.amccontractor1BindingSource.DataSource = this.postDataSet;
            // 
            // postDataSet
            // 
            this.postDataSet.DataSetName = "PostDataSet";
            this.postDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchgrpbox
            // 
            this.searchgrpbox.Controls.Add(this.label3);
            this.searchgrpbox.Controls.Add(this.pictureBox2);
            this.searchgrpbox.Controls.Add(this.groupBox1);
            this.searchgrpbox.Location = new System.Drawing.Point(147, 395);
            this.searchgrpbox.Name = "searchgrpbox";
            this.searchgrpbox.Size = new System.Drawing.Size(430, 152);
            this.searchgrpbox.TabIndex = 19;
            this.searchgrpbox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "By AssetNo.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.amcgridtxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 58);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // amcgridtxt
            // 
            this.amcgridtxt.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amcgridtxt.Location = new System.Drawing.Point(185, 16);
            this.amcgridtxt.Name = "amcgridtxt";
            this.amcgridtxt.Size = new System.Drawing.Size(215, 34);
            this.amcgridtxt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter AssetNo. : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(244, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 43);
            this.label4.TabIndex = 22;
            this.label4.Text = "General Post Office(GPO)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(241, 553);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(216, 49);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 46);
            this.toolStripButton1.Text = "Search";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(55, 46);
            this.toolStripButton2.Text = "Clear";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 46);
            this.toolStripButton3.Text = "All";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(45, 46);
            this.toolStripButton4.Text = "Exit";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click_1);
            // 
            // amccontractor1TableAdapter
            // 
            this.amccontractor1TableAdapter.ClearBeforeFill = true;
            // 
            // AMCContractorGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(645, 611);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amcGridView1);
            this.Controls.Add(this.searchgrpbox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AMCContractorGrid";
            this.Text = "AMCContractorGrid";
            this.Load += new System.EventHandler(this.AMCContractorGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amcGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amccontractor1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataSet)).EndInit();
            this.searchgrpbox.ResumeLayout(false);
            this.searchgrpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView amcGridView1;
        private System.Windows.Forms.GroupBox searchgrpbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox amcgridtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private PostDataSet postDataSet;
        private System.Windows.Forms.BindingSource amccontractor1BindingSource;
        private PostDataSetTableAdapters.amccontractor1TableAdapter amccontractor1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfExpiryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMCAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractorNameDataGridViewTextBoxColumn;
    }
}