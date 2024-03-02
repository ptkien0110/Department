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
    public partial class KhachHang : UserControl
    {
        connect con = new connect();
        String query;
        public KhachHang()
        {
            InitializeComponent();
        }
        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = con.getForCombo(query);
            while (sdr.Read())
            {
                for(int i = 0; i< sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }


        private void txt_loaiCH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_soCH.Items.Clear();
            txt_gia.Clear();
            query = "select SoCanHo from canHo where LoaiGiuong='" + txt_loaiGiuong.Text + "' and LoaiCanHo = '" + txt_loaiCH.Text + "' and TrangThai ='Chua dat' ";
            setComboBox(query, txt_soCH);
        }

        private void txt_loaiGiuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_loaiCH.SelectedIndex = -1;
            txt_soCH.Items.Clear();
            txt_gia.Clear();
        }
        int ChId;
        private void txt_soCH_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select Gia, IdCh from canHo where SoCanHo ='"+txt_soCH.Text+"' ";
            DataSet ds = con.getData(query);
            txt_gia.Text = ds.Tables[0].Rows[0][0].ToString();
            ChId = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btn_DK_Click(object sender, EventArgs e)
        {
            if (txt_hoTen.Text != "" && txt_soDT.Text != "" && txt_gender.Text != "" && txt_birth.Text != "" && txt_cmnd.Text != "" && txt_quequan.Text != "" && txt_Ngaydk.Text != "")
            {
                String name = txt_hoTen.Text;
                Int64 mobile = Int64.Parse(txt_soDT.Text);
                String gender = txt_gender.Text;
                String birth = txt_birth.Text;
                String cmnd = txt_cmnd.Text;
                String quequan = txt_quequan.Text;
                String dk = txt_Ngaydk.Text;

                query = "insert into KhachHang (HoTen, SDT, GioiTinh, NgayThangNamSinh, Cmnd, QueQuan, NgayDangKi, IdCh) values ('" + name + "','" + mobile + "','" + gender + "','" + birth + "','" + cmnd + "','" + quequan + "','" + dk + "','"+ChId+"') update canHo set TrangThai = 'Da dat' where SoCanHo='"+txt_soCH.Text+"'";
                con.setData(query, " Can ho so " + txt_soCH.Text + " da duoc dang ki thanh cong !!");
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
            txt_gender.SelectedIndex = -1;
            txt_birth.ResetText();
            txt_cmnd.Clear();
            txt_quequan.Clear();
            txt_Ngaydk.ResetText();
            txt_loaiCH.SelectedIndex = -1;
            txt_loaiGiuong.SelectedIndex = -1;
            txt_soCH.Items.Clear();
            txt_gia.Clear();

        }

        private void btn_DK_Leave(object sender, EventArgs e)
        {
            clearAll();
        }


    }
}
