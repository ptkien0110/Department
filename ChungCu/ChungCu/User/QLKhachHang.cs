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

namespace ChungCu.User
{
    public partial class QLKhachHang : UserControl
    {
        connect con = new connect();
        String query;
        public QLKhachHang()
        {
            InitializeComponent();
        }

        private void btn_lapHD_Click(object sender, EventArgs e)
        {
            if(txt_hoTen.Text != "" && txt_soDT.Text != "" && txt_cmnd.Text != "" && txt_water.Text != "" && txt_elec.Text != "" && txt_guixe.Text != "")
            {
                String name = txt_hoTen.Text;
                Int64 mobile = Int64.Parse(txt_soDT.Text);
                String cmnd = txt_cmnd.Text;
                String water = txt_water.Text;
                String elec = txt_elec.Text;
                String xe = txt_guixe.Text;

                query = "insert into hoaDon (HoTen, SDT, Cmnd, TienNuoc, TienDien, TienGuiXe) values ('"+name+ "','"+mobile+"','"+cmnd+"','"+water+"','"+elec+ "','"+xe+"')";
                con.setData(query, "Đã lập hóa đơn thành công");
                clearAll();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txt_hoTen.Clear();
            txt_soDT.Clear();
            txt_cmnd.Clear();
            txt_water.Clear();
            txt_guixe.Clear();
            txt_elec.Clear();
            txthoten.Clear();
            txtcmnd.Clear();
            txtsdt.Clear();
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                query = "select * from hoaDon where ThanhToan = ' Chua thanh toan '";
                DataSet ds = con.getData(query);
                DataGridView1.DataSource = ds.Tables[0];
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                query = "select * from hoaDon";
                DataSet ds = con.getData(query);
                DataGridView2.DataSource = ds.Tables[0];
            }
            

        }
      

        int id;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txthoten.Text = DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtsdt.Text = DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtcmnd.Text = DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btn_tt_Click(object sender, EventArgs e)
        {
            if(txthoten.Text != "")
            {
                if(MessageBox.Show("Xác nhận thanh toán ?","Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    query= "update hoaDon set ThanhToan =' Da thanh toan ' where HoTen ='"+txthoten.Text+"'";
                    con.setData(query, "Thanh toán thành công");
                    QLKhachHang_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Chọn khách hàng cần thanh toán", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            clearAll();
        }

        private void b_Click(object sender, EventArgs e)
        {
            query = "select * from hoaDon where ThanhToan = ' Chua thanh toan '";
            DataSet ds = con.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_re_Click(object sender, EventArgs e)
        {
            query = "select * from hoaDon";
            DataSet ds = con.getData(query);
            DataGridView2.DataSource = ds.Tables[0];
        }
    }
}
