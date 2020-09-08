using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainGame
{
    class BrainGameDatabaseConnection
    {
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-J047RQPF\SQLEXPRESS;Initial Catalog=BrainGame;Integrated Security=True");
        // SqlConnection cn = new SqlConnection(myconnString);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public void manipulate(string query)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc);
                return;
            }
        }
        public DataTable retrieve(string query)
        {
            try
            {
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(query, cn);
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc);
                return null;
            }

        }
    }
}
