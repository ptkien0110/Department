using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChungCu
{
    public partial class Form1 : Form
    {
        connect con = new connect();
        String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            query = "select TenDN, MatKhau from employee where TenDn ='"+txt_tenDN.Text+"' and MatKhau = '"+txt_mkDN.Text+"' ";
            DataSet ds = con.getData(query);
            if(ds.Tables[0].Rows.Count != 0)
            {
                label_Error.Visible = false;
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
            }
            else
            {
                label_Error.Visible = true;
                txt_tenDN.Clear();
                txt_mkDN.Clear();
            }
        }
    }
}
