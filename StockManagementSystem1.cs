using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Post
{
    public partial class StockManagementSystem1 : Form
    {
        String unm = "";
        String contact = "";
        String email = "";
        String addr = "";
        String type = "";
        String dept = "";
        public StockManagementSystem1()
        {
            InitializeComponent();
        }
        public StockManagementSystem1(String n, String c, String em, String add, String t, String d)
        {
            InitializeComponent();
            unm = n;
            contact = c;
            email = em;
            addr = add;
            type = t;
            dept = d;
            linkLabel1.Text = "Welcome " + unm;
        }

        private void historyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History his = new History();
            his.Show();
        }

        private void repairReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportwin rep = new Reportwin();
            rep.Show();
        }

        private void aMCReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            amcreportwin amc = new amcreportwin();
            amc.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            details d = new details(unm, contact, email, addr, type, dept);
            d.Show();

        }
    }
}
