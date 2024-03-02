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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_dsClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            add1.Visible = true;
            add1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            employee1.Visible = false;
            qlKhachHang1.Visible = false;
            add1.Visible = false;
            khachHang1.Visible = false;
            btn_addCh.PerformClick();
        }

        private void add1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Dk_Click(object sender, EventArgs e)
        {
            khachHang1.Visible = true;
            khachHang1.BringToFront();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            qlKhachHang1.Visible = true;
            qlKhachHang1.BringToFront();
        }

        private void btn_infor_Click(object sender, EventArgs e)
        {
            danhSachKH1.Visible = true;
            danhSachKH1.BringToFront();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            employee1.Visible = true;
            employee1.BringToFront();
        }
    }
}
