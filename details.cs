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
    public partial class details : Form
    {
        String unm = "";
        String contact = "";
        String email = "";
        String addr = "";
        String type = "";
        String dept = "";
        public details()
        {
            InitializeComponent();
        }
        public details(String nm,String c,String em,String ad,String typ,String d)
        {
            InitializeComponent();
            unm=nm;
            contact=c;
            email=em;
            addr=ad;
            type=typ;
            dept=d;
            textBox1.Text = unm;
            textBox2.Text = contact;
            textBox3.Text = email;
            textBox4.Text = addr;
            textBox5.Text = type;
            textBox6.Text = dept;
        }
    }
}
