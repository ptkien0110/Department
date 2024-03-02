using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChungCu
{
    class connect
    {
        protected SqlConnection getConnection()
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = "data source = LAPTOP-CIMCTMTJ; database=apartment1;integrated security= True";
            return connect;
        }
        public DataSet getData(String query)
        {
            SqlConnection connect = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData (String query, String message)
        {
            SqlConnection connect = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            connect.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("'" + message + "'","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public SqlDataReader getForCombo(String query)
        {
            SqlConnection connect = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            connect.Open();
            cmd = new SqlCommand(query, connect);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
