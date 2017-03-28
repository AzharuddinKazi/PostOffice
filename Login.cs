using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Post
{
    public partial class Login : Form
    {
        String name = "";
        String contact = "";
        String email = "";
        String addr = "";
        String type = "";
        String dept = "";
        public Login()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con = new SqlConnection("server=SHREYAS-PC ; database=post ; uid=sa ; pwd=1234");
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from login where Username='" + uid.Text + "' and Pwd='" + passwd.Text + "' and Typ='" + cbotype.Text + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();
               

                if (dr.Read())
                {
                    name = dr["Name"].ToString();
                    contact = dr["contact"].ToString();
                    email = dr["EmailId"].ToString();
                    addr = dr["Adress"].ToString();
                    type = dr["Typ"].ToString();
                    dept = dr["department"].ToString();

                    if (cbotype.Text.Equals("Admin"))
                    {
                        StockManagementSystem sms = new StockManagementSystem(name,contact,email,addr,type,dept);
                        sms.Show();
                    }

                    else if (cbotype.Text.Equals("Other"))
                    {
                        StockManagementSystem1 sms1 = new StockManagementSystem1(name, contact, email, addr, type, dept);
                        sms1.Show();
                    }

                }


                else
                {
                    
                    MessageBox.Show("Invalid username or password");
                    return;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            uid.Clear();
            passwd.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            

        }

        private void cbotype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Close();
        }
    }
}
