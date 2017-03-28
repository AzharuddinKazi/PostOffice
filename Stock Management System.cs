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
    public partial class StockManagementSystem : Form
    {
        String unm="";
        String contact = "";
        String email = "";
        String addr = "";
        String type = "";
        String dept = "";
        public StockManagementSystem()
        {
            InitializeComponent();
        }

        public StockManagementSystem(String n,String c,String em,String add,String t,String d)
        {
            InitializeComponent();
            unm = n;
            contact = c;
            email = em;
            addr = add;
            type = t;
            dept = d;
            linkLabel1.Text ="Welcome "+ unm;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to exit..?");
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to logout");
            Login l = new Login();
            l.Show();
            
        }

        private void assetsCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssetsCategory ac = new AssetsCategory();
            ac.Show();
            
        }

        

        private void assetsDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssetsDetails ad = new AssetsDetails();
            ad.Show();
            
        }

        private void assetsRepairngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssetsRepairing ar = new AssetsRepairing();
            ar.Show();
            
        }

       

        private void AMCContractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AMCContractor amcc = new AMCContractor();
            amcc.Show();
            
        }

        private void adminsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminView av = new AdminView();
            av.Show();
            
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers s = new Suppliers();
            s.Show();
            
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departments depart = new Departments();
            depart.Show();
        }

        private void AMCContractorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AMCContractor ac = new AMCContractor();
            ac.Show();
        }

        private void historyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History his = new History();
            his.Show();
        }

        private void repairReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportwin rw = new Reportwin();
            rw.Show();
        }

        private void aMCReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
                amcreportwin am = new amcreportwin();
            am.Show();
        }

        private void StockManagementSystem_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            details d = new details(unm, contact, email, addr, type, dept);
            d.Show();

        }

        
    }
}
