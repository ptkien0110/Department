using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChungCu
{
    public partial class DanhSachKH : UserControl
    {
        connect con = new connect();
        String query;
        public DanhSachKH()
        {
            InitializeComponent();
        }

        private void DanhSachKH_Load(object sender, EventArgs e)
        {
            query = " select * from KhachHang ";
            DataSet ds = con.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            query = " select * from KhachHang ";
            DataSet ds = con.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_ten.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này  ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from KhachHang where Id =" + txt_ten.Text + "";
                    con.setData(query, "Đã xóa thành công");
                    DanhSachKH_Load(this, null);
                }
            }
        }
    }
}
