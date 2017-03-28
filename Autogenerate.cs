using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Post
{
    class Autogenerate
    {
        public static String autogen(String tablename, String colname)
        {
            int count = 0,c;
            String sid = "S";
            SqlConnection con = new SqlConnection("server= WIN-7-PC; database= post ; uid=sa ; pwd=1234");

            con.Open();
            SqlCommand cmd = new SqlCommand("select isnull(max(substring("+colname+",2,4)),0) from "+tablename,con);
            String str = cmd.ExecuteScalar().ToString();
            //if (dr.Read())
            {
                count=Convert.ToInt16(str);
                //count = int(dr.GetInt16(0));
                count++;
            }
            c=count.ToString().Length;
            while(c<3)
            {
                sid+="0";
                c++;
            }
            sid+=count;
            return sid;
        }

        
    }
}
