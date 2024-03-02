
namespace ChungCu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label_Error = new System.Windows.Forms.Label();
            this.btn_DN = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_mkDN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_tenDN = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label_Error);
            this.panel1.Controls.Add(this.btn_DN);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.txt_mkDN);
            this.panel1.Controls.Add(this.txt_tenDN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(596, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 492);
            this.panel1.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.CheckedState.Parent = this.btn_Close;
            this.btn_Close.CustomImages.Parent = this.btn_Close;
            this.btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Close.DisabledState.Parent = this.btn_Close;
            this.btn_Close.FillColor = System.Drawing.Color.Empty;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.HoverState.Parent = this.btn_Close;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Close.Location = new System.Drawing.Point(880, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Close.ShadowDecoration.Parent = this.btn_Close;
            this.btn_Close.Size = new System.Drawing.Size(52, 43);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(627, 370);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(227, 18);
            this.label_Error.TabIndex = 7;
            this.label_Error.Text = "Sai tên đăng nhập hoặc mật khẩu";
            this.label_Error.Visible = false;
            // 
            // btn_DN
            // 
            this.btn_DN.BorderRadius = 18;
            this.btn_DN.CheckedState.Parent = this.btn_DN;
            this.btn_DN.CustomImages.Parent = this.btn_DN;
            this.btn_DN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DN.DisabledState.Parent = this.btn_DN;
            this.btn_DN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_DN.ForeColor = System.Drawing.Color.White;
            this.btn_DN.HoverState.Parent = this.btn_DN;
            this.btn_DN.Location = new System.Drawing.Point(614, 281);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.ShadowDecoration.Parent = this.btn_DN;
            this.btn_DN.Size = new System.Drawing.Size(240, 49);
            this.btn_DN.TabIndex = 6;
            this.btn_DN.Text = "Đăng nhập";
            this.btn_DN.Click += new System.EventHandler(this.btn_DN_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(72, 53);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(410, 389);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // txt_mkDN
            // 
            this.txt_mkDN.BorderRadius = 18;
            this.txt_mkDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mkDN.DefaultText = "";
            this.txt_mkDN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mkDN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mkDN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mkDN.DisabledState.Parent = this.txt_mkDN;
            this.txt_mkDN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mkDN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.txt_mkDN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mkDN.FocusedState.Parent = this.txt_mkDN;
            this.txt_mkDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_mkDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mkDN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mkDN.HoverState.Parent = this.txt_mkDN;
            this.txt_mkDN.Location = new System.Drawing.Point(572, 213);
            this.txt_mkDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mkDN.Name = "txt_mkDN";
            this.txt_mkDN.PasswordChar = '*';
            this.txt_mkDN.PlaceholderText = "Mật khẩu";
            this.txt_mkDN.SelectedText = "";
            this.txt_mkDN.ShadowDecoration.Parent = this.txt_mkDN;
            this.txt_mkDN.Size = new System.Drawing.Size(315, 49);
            this.txt_mkDN.TabIndex = 4;
            this.txt_mkDN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_tenDN
            // 
            this.txt_tenDN.BorderRadius = 18;
            this.txt_tenDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenDN.DefaultText = "";
            this.txt_tenDN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenDN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenDN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenDN.DisabledState.Parent = this.txt_tenDN;
            this.txt_tenDN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenDN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.txt_tenDN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenDN.FocusedState.Parent = this.txt_tenDN;
            this.txt_tenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tenDN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenDN.HoverState.Parent = this.txt_tenDN;
            this.txt_tenDN.Location = new System.Drawing.Point(572, 143);
            this.txt_tenDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tenDN.Name = "txt_tenDN";
            this.txt_tenDN.PasswordChar = '\0';
            this.txt_tenDN.PlaceholderText = "Tên đăng nhập";
            this.txt_tenDN.SelectedText = "";
            this.txt_tenDN.ShadowDecoration.Parent = this.txt_tenDN;
            this.txt_tenDN.Size = new System.Drawing.Size(315, 49);
            this.txt_tenDN.TabIndex = 2;
            this.txt_tenDN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(624, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1269, 700);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_DN;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_mkDN;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenDN;
        private System.Windows.Forms.Label label_Error;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Close;
    }
}

