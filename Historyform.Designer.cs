namespace Post
{
    partial class Historyform
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
            this.label1 = new System.Windows.Forms.Label();
            this.combo_dept = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_mctype = new System.Windows.Forms.ComboBox();
            this.button_show = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // combo_dept
            // 
            this.combo_dept.FormattingEnabled = true;
            this.combo_dept.Location = new System.Drawing.Point(84, 18);
            this.combo_dept.Name = "combo_dept";
            this.combo_dept.Size = new System.Drawing.Size(109, 21);
            this.combo_dept.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asset Type";
            // 
            // combo_type
            // 
            this.combo_type.FormattingEnabled = true;
            this.combo_type.Location = new System.Drawing.Point(281, 20);
            this.combo_type.Name = "combo_type";
            this.combo_type.Size = new System.Drawing.Size(121, 21);
            this.combo_type.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Machine No.";
            // 
            // combo_mctype
            // 
            this.combo_mctype.FormattingEnabled = true;
            this.combo_mctype.Location = new System.Drawing.Point(518, 21);
            this.combo_mctype.Name = "combo_mctype";
            this.combo_mctype.Size = new System.Drawing.Size(107, 21);
            this.combo_mctype.TabIndex = 5;
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(672, 20);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(118, 21);
            this.button_show.TabIndex = 6;
            this.button_show.Text = "Show";
            this.button_show.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(20, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 555);
            this.panel1.TabIndex = 7;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(810, 555);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // Historyform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.combo_mctype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_dept);
            this.Controls.Add(this.label1);
            this.Name = "Historyform";
            this.Text = "Historyform";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_dept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_mctype;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}