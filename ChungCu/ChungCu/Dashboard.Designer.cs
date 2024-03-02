
namespace ChungCu
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_employee = new Guna.UI2.WinForms.Guna2Button();
            this.btn_infor = new Guna.UI2.WinForms.Guna2Button();
            this.btn_check = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Dk = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addCh = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_dsClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_minimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.danhSachKH1 = new ChungCu.DanhSachKH();
            this.qlKhachHang1 = new ChungCu.User.QLKhachHang();
            this.khachHang1 = new ChungCu.User.KhachHang();
            this.add1 = new ChungCu.User.Add();
            this.employee1 = new ChungCu.User.Employee();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_employee);
            this.panel1.Controls.Add(this.btn_infor);
            this.panel1.Controls.Add(this.btn_check);
            this.panel1.Controls.Add(this.btn_Dk);
            this.panel1.Controls.Add(this.btn_addCh);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 130);
            this.panel1.TabIndex = 0;
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_employee.BorderRadius = 26;
            this.btn_employee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_employee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_employee.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_employee.CheckedState.Parent = this.btn_employee;
            this.btn_employee.CustomImages.Parent = this.btn_employee;
            this.btn_employee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_employee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_employee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_employee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_employee.DisabledState.Parent = this.btn_employee;
            this.btn_employee.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btn_employee.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.ForeColor = System.Drawing.Color.White;
            this.btn_employee.HoverState.Parent = this.btn_employee;
            this.btn_employee.Location = new System.Drawing.Point(990, 20);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.ShadowDecoration.Parent = this.btn_employee;
            this.btn_employee.Size = new System.Drawing.Size(236, 85);
            this.btn_employee.TabIndex = 4;
            this.btn_employee.Text = "Nhân viên";
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // btn_infor
            // 
            this.btn_infor.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_infor.BorderRadius = 26;
            this.btn_infor.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_infor.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_infor.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_infor.CheckedState.Parent = this.btn_infor;
            this.btn_infor.CustomImages.Parent = this.btn_infor;
            this.btn_infor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_infor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_infor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_infor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_infor.DisabledState.Parent = this.btn_infor;
            this.btn_infor.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btn_infor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_infor.ForeColor = System.Drawing.Color.White;
            this.btn_infor.HoverState.Parent = this.btn_infor;
            this.btn_infor.Location = new System.Drawing.Point(748, 20);
            this.btn_infor.Name = "btn_infor";
            this.btn_infor.ShadowDecoration.Parent = this.btn_infor;
            this.btn_infor.Size = new System.Drawing.Size(236, 85);
            this.btn_infor.TabIndex = 3;
            this.btn_infor.Text = "Danh sách chủ hộ";
            this.btn_infor.Click += new System.EventHandler(this.btn_infor_Click);
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_check.BorderRadius = 26;
            this.btn_check.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_check.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_check.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_check.CheckedState.Parent = this.btn_check;
            this.btn_check.CustomImages.Parent = this.btn_check;
            this.btn_check.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_check.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_check.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_check.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_check.DisabledState.Parent = this.btn_check;
            this.btn_check.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btn_check.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.Color.White;
            this.btn_check.HoverState.Parent = this.btn_check;
            this.btn_check.Location = new System.Drawing.Point(506, 20);
            this.btn_check.Name = "btn_check";
            this.btn_check.ShadowDecoration.Parent = this.btn_check;
            this.btn_check.Size = new System.Drawing.Size(236, 85);
            this.btn_check.TabIndex = 2;
            this.btn_check.Text = "Kiểm tra";
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_Dk
            // 
            this.btn_Dk.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Dk.BorderRadius = 26;
            this.btn_Dk.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Dk.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_Dk.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_Dk.CheckedState.Parent = this.btn_Dk;
            this.btn_Dk.CustomImages.Parent = this.btn_Dk;
            this.btn_Dk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Dk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Dk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Dk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Dk.DisabledState.Parent = this.btn_Dk;
            this.btn_Dk.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Dk.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dk.ForeColor = System.Drawing.Color.White;
            this.btn_Dk.HoverState.Parent = this.btn_Dk;
            this.btn_Dk.Location = new System.Drawing.Point(263, 20);
            this.btn_Dk.Name = "btn_Dk";
            this.btn_Dk.ShadowDecoration.Parent = this.btn_Dk;
            this.btn_Dk.Size = new System.Drawing.Size(236, 85);
            this.btn_Dk.TabIndex = 1;
            this.btn_Dk.Text = "Đăng kí chủ hộ";
            this.btn_Dk.Click += new System.EventHandler(this.btn_Dk_Click);
            // 
            // btn_addCh
            // 
            this.btn_addCh.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_addCh.BorderRadius = 26;
            this.btn_addCh.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_addCh.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_addCh.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_addCh.CheckedState.Parent = this.btn_addCh;
            this.btn_addCh.CustomImages.Parent = this.btn_addCh;
            this.btn_addCh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addCh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addCh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addCh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addCh.DisabledState.Parent = this.btn_addCh;
            this.btn_addCh.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btn_addCh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCh.ForeColor = System.Drawing.Color.White;
            this.btn_addCh.HoverState.Parent = this.btn_addCh;
            this.btn_addCh.Location = new System.Drawing.Point(21, 20);
            this.btn_addCh.Name = "btn_addCh";
            this.btn_addCh.ShadowDecoration.Parent = this.btn_addCh;
            this.btn_addCh.Size = new System.Drawing.Size(236, 85);
            this.btn_addCh.TabIndex = 0;
            this.btn_addCh.Text = "Thêm căn hộ";
            this.btn_addCh.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.employee1);
            this.panel2.Controls.Add(this.danhSachKH1);
            this.panel2.Controls.Add(this.qlKhachHang1);
            this.panel2.Controls.Add(this.khachHang1);
            this.panel2.Controls.Add(this.add1);
            this.panel2.Location = new System.Drawing.Point(24, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1279, 505);
            this.panel2.TabIndex = 1;
            // 
            // btn_dsClose
            // 
            this.btn_dsClose.CheckedState.Parent = this.btn_dsClose;
            this.btn_dsClose.CustomImages.Parent = this.btn_dsClose;
            this.btn_dsClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dsClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dsClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dsClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dsClose.DisabledState.Parent = this.btn_dsClose;
            this.btn_dsClose.FillColor = System.Drawing.Color.Empty;
            this.btn_dsClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_dsClose.ForeColor = System.Drawing.Color.White;
            this.btn_dsClose.HoverState.Parent = this.btn_dsClose;
            this.btn_dsClose.Image = ((System.Drawing.Image)(resources.GetObject("btn_dsClose.Image")));
            this.btn_dsClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_dsClose.Location = new System.Drawing.Point(1279, 1);
            this.btn_dsClose.Name = "btn_dsClose";
            this.btn_dsClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_dsClose.ShadowDecoration.Parent = this.btn_dsClose;
            this.btn_dsClose.Size = new System.Drawing.Size(52, 43);
            this.btn_dsClose.TabIndex = 2;
            this.btn_dsClose.Click += new System.EventHandler(this.btn_dsClose_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.CheckedState.Parent = this.btn_minimize;
            this.btn_minimize.CustomImages.Parent = this.btn_minimize;
            this.btn_minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_minimize.DisabledState.Parent = this.btn_minimize;
            this.btn_minimize.FillColor = System.Drawing.Color.Empty;
            this.btn_minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.HoverState.Parent = this.btn_minimize;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_minimize.Location = new System.Drawing.Point(1279, 50);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_minimize.ShadowDecoration.Parent = this.btn_minimize;
            this.btn_minimize.Size = new System.Drawing.Size(52, 43);
            this.btn_minimize.TabIndex = 3;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // danhSachKH1
            // 
            this.danhSachKH1.BackColor = System.Drawing.Color.White;
            this.danhSachKH1.Location = new System.Drawing.Point(0, 0);
            this.danhSachKH1.Name = "danhSachKH1";
            this.danhSachKH1.Size = new System.Drawing.Size(1279, 505);
            this.danhSachKH1.TabIndex = 3;
            // 
            // qlKhachHang1
            // 
            this.qlKhachHang1.BackColor = System.Drawing.Color.White;
            this.qlKhachHang1.Location = new System.Drawing.Point(0, 0);
            this.qlKhachHang1.Name = "qlKhachHang1";
            this.qlKhachHang1.Size = new System.Drawing.Size(1279, 505);
            this.qlKhachHang1.TabIndex = 2;
            // 
            // khachHang1
            // 
            this.khachHang1.BackColor = System.Drawing.Color.White;
            this.khachHang1.Location = new System.Drawing.Point(0, -1);
            this.khachHang1.Name = "khachHang1";
            this.khachHang1.Size = new System.Drawing.Size(1279, 505);
            this.khachHang1.TabIndex = 1;
            // 
            // add1
            // 
            this.add1.BackColor = System.Drawing.Color.White;
            this.add1.Location = new System.Drawing.Point(0, 0);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(1279, 505);
            this.add1.TabIndex = 0;
            this.add1.Load += new System.EventHandler(this.add1_Load);
            // 
            // employee1
            // 
            this.employee1.BackColor = System.Drawing.Color.White;
            this.employee1.Location = new System.Drawing.Point(0, -1);
            this.employee1.Name = "employee1";
            this.employee1.Size = new System.Drawing.Size(1279, 505);
            this.employee1.TabIndex = 4;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1329, 679);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_dsClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btn_dsClose;
        private Guna.UI2.WinForms.Guna2Button btn_employee;
        private Guna.UI2.WinForms.Guna2Button btn_infor;
        private Guna.UI2.WinForms.Guna2Button btn_check;
        private Guna.UI2.WinForms.Guna2Button btn_Dk;
        private Guna.UI2.WinForms.Guna2Button btn_addCh;
        private Guna.UI2.WinForms.Guna2CircleButton btn_minimize;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private User.Add add1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private User.KhachHang khachHang1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private User.QLKhachHang qlKhachHang1;
        private DanhSachKH danhSachKH1;
        private User.Employee employee1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
    }
}