namespace Post
{
    partial class AssetsGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetsGrid));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.assetsgrid1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postDataSet = new Post.PostDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.srchstrip = new System.Windows.Forms.ToolStripButton();
            this.allstrip = new System.Windows.Forms.ToolStripButton();
            this.exitstrip = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assettxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchgrpbox = new System.Windows.Forms.GroupBox();
            this.assetsgrid1TableAdapter = new Post.PostDataSetTableAdapters.assetsgrid1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsgrid1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.searchgrpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 242);
            this.dataGridView1.TabIndex = 15;
            // 
            // assetsgrid1BindingSource
            // 
            this.assetsgrid1BindingSource.DataMember = "assetsgrid1";
            this.assetsgrid1BindingSource.DataSource = this.postDataSet;
            // 
            // postDataSet
            // 
            this.postDataSet.DataSetName = "PostDataSet";
            this.postDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(292, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "General Post Office(GPO)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.srchstrip,
            this.allstrip,
            this.exitstrip});
            this.toolStrip1.Location = new System.Drawing.Point(199, 557);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(192, 49);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // srchstrip
            // 
            this.srchstrip.Image = ((System.Drawing.Image)(resources.GetObject("srchstrip.Image")));
            this.srchstrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.srchstrip.Name = "srchstrip";
            this.srchstrip.Size = new System.Drawing.Size(68, 46);
            this.srchstrip.Text = "Search";
            this.srchstrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.srchstrip.Click += new System.EventHandler(this.srchstrip_Click);
            // 
            // allstrip
            // 
            this.allstrip.Image = ((System.Drawing.Image)(resources.GetObject("allstrip.Image")));
            this.allstrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.allstrip.Name = "allstrip";
            this.allstrip.Size = new System.Drawing.Size(36, 46);
            this.allstrip.Text = "All";
            this.allstrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.allstrip.Click += new System.EventHandler(this.allstrip_Click);
            // 
            // exitstrip
            // 
            this.exitstrip.Image = ((System.Drawing.Image)(resources.GetObject("exitstrip.Image")));
            this.exitstrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitstrip.Name = "exitstrip";
            this.exitstrip.Size = new System.Drawing.Size(45, 46);
            this.exitstrip.Text = "Exit";
            this.exitstrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitstrip.Click += new System.EventHandler(this.exitstrip_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assettxtbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 52);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // assettxtbx
            // 
            this.assettxtbx.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assettxtbx.Location = new System.Drawing.Point(186, 12);
            this.assettxtbx.Name = "assettxtbx";
            this.assettxtbx.Size = new System.Drawing.Size(215, 34);
            this.assettxtbx.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter AssetNo. : ";
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
            // searchgrpbox
            // 
            this.searchgrpbox.Controls.Add(this.label3);
            this.searchgrpbox.Controls.Add(this.pictureBox2);
            this.searchgrpbox.Controls.Add(this.groupBox1);
            this.searchgrpbox.Location = new System.Drawing.Point(147, 394);
            this.searchgrpbox.Name = "searchgrpbox";
            this.searchgrpbox.Size = new System.Drawing.Size(430, 160);
            this.searchgrpbox.TabIndex = 14;
            this.searchgrpbox.TabStop = false;
            // 
            // assetsgrid1TableAdapter
            // 
            this.assetsgrid1TableAdapter.ClearBeforeFill = true;
            // 
            // AssetsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(697, 614);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchgrpbox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssetsGrid";
            this.Text = "AssetsGrid";
            this.Load += new System.EventHandler(this.AssetsGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsgrid1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.searchgrpbox.ResumeLayout(false);
            this.searchgrpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton exitstrip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton srchstrip;
        private System.Windows.Forms.ToolStripButton allstrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox assettxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox searchgrpbox;
        private PostDataSet postDataSet;
        private System.Windows.Forms.BindingSource assetsgrid1BindingSource;
        private PostDataSetTableAdapters.assetsgrid1TableAdapter assetsgrid1TableAdapter;
    }
}