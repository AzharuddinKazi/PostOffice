using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Post
{
    public partial class ContractorGrid : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        public ContractorGrid()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            idbox.Clear();
            namebox.Clear();
        }

        

        private void ContractorGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postDataSet.contractorgrid1' table. You can move, or remove it, as needed.
            //this.contractorgrid1TableAdapter.Fill(this.postDataSet.contractorgrid1);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection("server= WIN-7-PC; database= post ; uid=sa ; pwd=1234");
                con.Open();
                da = new SqlDataAdapter("select * from contractor where contractor id is ='" + idbox.Text + "'", con);
                ds = new System.Data.DataSet();
                da.Fill(ds, "example_details");
                cgridview.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
