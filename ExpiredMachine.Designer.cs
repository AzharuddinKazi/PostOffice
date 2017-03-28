namespace Post
{
    partial class ExpiredMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpiredMachine));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.exitstrip = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.postDataSet = new Post.PostDataSet();
            this.expiredmachine1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expiredmachine1TableAdapter = new Post.PostDataSetTableAdapters.expiredmachine1TableAdapter();
            this.assetNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warrantyUptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expiredmachine1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitstrip});
            this.toolStrip1.Location = new System.Drawing.Point(290, 391);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(57, 49);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // exitstrip
            // 
            this.exitstrip.Image = ((System.Drawing.Image)(resources.GetObject("exitstrip.Image")));
            this.exitstrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitstrip.Name = "exitstrip";
            this.exitstrip.Size = new System.Drawing.Size(45, 46);
            this.exitstrip.Text = "Exit";
            this.exitstrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assetNoDataGridViewTextBoxColumn,
            this.assetNameDataGridViewTextBoxColumn,
            this.warrantyUptoDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.deptNoDataGridViewTextBoxColumn,
            this.installationDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expiredmachine1BindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(27, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 242);
            this.dataGridView1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(264, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 43);
            this.label1.TabIndex = 18;
            this.label1.Text = "General Post Office(GPO)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // postDataSet
            // 
            this.postDataSet.DataSetName = "PostDataSet";
            this.postDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expiredmachine1BindingSource
            // 
            this.expiredmachine1BindingSource.DataMember = "expiredmachine1";
            this.expiredmachine1BindingSource.DataSource = this.postDataSet;
            // 
            // expiredmachine1TableAdapter
            // 
            this.expiredmachine1TableAdapter.ClearBeforeFill = true;
            // 
            // assetNoDataGridViewTextBoxColumn
            // 
            this.assetNoDataGridViewTextBoxColumn.DataPropertyName = "AssetNo";
            this.assetNoDataGridViewTextBoxColumn.HeaderText = "AssetNo";
            this.assetNoDataGridViewTextBoxColumn.Name = "assetNoDataGridViewTextBoxColumn";
            // 
            // assetNameDataGridViewTextBoxColumn
            // 
            this.assetNameDataGridViewTextBoxColumn.DataPropertyName = "AssetName";
            this.assetNameDataGridViewTextBoxColumn.HeaderText = "AssetName";
            this.assetNameDataGridViewTextBoxColumn.Name = "assetNameDataGridViewTextBoxColumn";
            // 
            // warrantyUptoDataGridViewTextBoxColumn
            // 
            this.warrantyUptoDataGridViewTextBoxColumn.DataPropertyName = "WarrantyUpto";
            this.warrantyUptoDataGridViewTextBoxColumn.HeaderText = "WarrantyUpto";
            this.warrantyUptoDataGridViewTextBoxColumn.Name = "warrantyUptoDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // deptNoDataGridViewTextBoxColumn
            // 
            this.deptNoDataGridViewTextBoxColumn.DataPropertyName = "DeptNo";
            this.deptNoDataGridViewTextBoxColumn.HeaderText = "DeptNo";
            this.deptNoDataGridViewTextBoxColumn.Name = "deptNoDataGridViewTextBoxColumn";
            // 
            // installationDateDataGridViewTextBoxColumn
            // 
            this.installationDateDataGridViewTextBoxColumn.DataPropertyName = "InstallationDate";
            this.installationDateDataGridViewTextBoxColumn.HeaderText = "InstallationDate";
            this.installationDateDataGridViewTextBoxColumn.Name = "installationDateDataGridViewTextBoxColumn";
            // 
            // ExpiredMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(693, 447);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ExpiredMachine";
            this.Text = "ExpiredMachine";
            this.Load += new System.EventHandler(this.ExpiredMachine_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expiredmachine1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton exitstrip;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PostDataSet postDataSet;
        private System.Windows.Forms.BindingSource expiredmachine1BindingSource;
        private PostDataSetTableAdapters.expiredmachine1TableAdapter expiredmachine1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyUptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationDateDataGridViewTextBoxColumn;
    }
}