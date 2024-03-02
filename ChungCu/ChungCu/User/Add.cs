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
    public partial class Add : UserControl
    {
        connect con = new connect();
        String query;

        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            query = " select * from canHo ";
            DataSet ds = con.getData(query);
            DataGridView2.DataSource = ds.Tables[0];
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_SoCH.Text != "" && txt_loaiCH.Text != "" && txt_loaiGiuong.Text != "" && txt_gia.Text != "")
            {
                String number = txt_SoCH.Text;
                String type = txt_loaiCH.Text;
                String bed = txt_loaiGiuong.Text;
                Int64 price = Int64.Parse(txt_gia.Text);

                query = "insert into canHo (SoCanHo, LoaiCanHo, LoaiGiuong, Gia) values('" + number + "','" + type + "','" + bed + "','" + price + "')";
                con.setData(query, "Đã thêm phòng");

                Add_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin","Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        public void clearAll()
        {
            txt_gia.Clear();
            txt_loaiCH.SelectedIndex = -1;
            txt_loaiGiuong.SelectedIndex = -1;
            txt_SoCH.Clear();
        }


    }
}
