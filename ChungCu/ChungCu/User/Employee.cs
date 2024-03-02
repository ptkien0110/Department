using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChungCu.User
{
    public partial class Employee : UserControl
    {
        connect con = new connect();
        String query;
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
        public void getMaxID()
        {
            query = "select max(eID) from employee";
            DataSet ds = con.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelSTT.Text = (num + 1).ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_name.Text != "" && txt_mobile.Text != "" && txt_gender.Text != "" && txt_mail.Text != "" && txt_username.Text != "" && txt_password.Text != "")
            {
                String name = txt_name.Text;
                Int64 mobile = Int64.Parse(txt_mobile.Text);
                String gender = txt_gender.Text;
                String mail = txt_mail.Text;
                String user = txt_username.Text;
                String pass = txt_password.Text;

                query = "insert into employee (HoTenNV, SoDTNV, GioiTinh, Email, TenDN, MatKhau) values ('" + name + "','" + mobile + "','" + gender + "','" + mail + "','" + user + "','" + pass + "')";
                con.setData(query, "Thêm nhân viên thành công");
                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
        private void btn_sathai_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn sa thải nhân viên này ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eID =" + txtid.Text + "";
                    con.setData(query, "Đã sa thải thành công");
                    tab_employee_SelectedIndexChanged(this, null);
                }
            }
        }  

        private void tab_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tab_employee.SelectedIndex == 1)
            {
                setEmployee(DataGridView1);
            }
            else if(tab_employee.SelectedIndex ==2)
            {
                setEmployee(DataGridView2);
            }
        }
        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = con.getData(query);
            dgv.DataSource = ds.Tables[0];
        }
        public void clearAll()
        {
            txt_gender.SelectedIndex = -1;
            txt_mail.Clear();
            txt_mobile.Clear();
            txt_name.Clear();
            txt_password.Clear();
            txt_username.Clear();
        }

      
    }
}
