using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FRegister : Form
    {
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRegister));
            this.pb_background_register = new System.Windows.Forms.PictureBox();
            this.pb_close_register = new System.Windows.Forms.PictureBox();
            this.pb_minus_register = new System.Windows.Forms.PictureBox();
            this.tb_phone_register = new System.Windows.Forms.TextBox();
            this.lb_validate_phone_register = new System.Windows.Forms.Label();
            this.tb_name_register = new System.Windows.Forms.TextBox();
            this.lb_validate_name_register = new System.Windows.Forms.Label();
            this.tb_pass_register = new System.Windows.Forms.TextBox();
            this.lb_validate_pass_register = new System.Windows.Forms.Label();
            this.tb_confirm_register = new System.Windows.Forms.TextBox();
            this.lb_validate_confirm_register = new System.Windows.Forms.Label();
            this.pb_register_register = new System.Windows.Forms.PictureBox();
            this.pb_login_register = new System.Windows.Forms.PictureBox();
            this.lb_validate_pass_confirm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_background_register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close_register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minus_register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_register_register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login_register)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_background_register
            // 
            this.pb_background_register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_background_register.Image = ((System.Drawing.Image)(resources.GetObject("pb_background_register.Image")));
            this.pb_background_register.Location = new System.Drawing.Point(0, 0);
            this.pb_background_register.Name = "pb_background_register";
            this.pb_background_register.Size = new System.Drawing.Size(909, 845);
            this.pb_background_register.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_background_register.TabIndex = 0;
            this.pb_background_register.TabStop = false;
            // 
            // pb_close_register
            // 
            this.pb_close_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close_register.Image = ((System.Drawing.Image)(resources.GetObject("pb_close_register.Image")));
            this.pb_close_register.Location = new System.Drawing.Point(869, 0);
            this.pb_close_register.Name = "pb_close_register";
            this.pb_close_register.Size = new System.Drawing.Size(40, 40);
            this.pb_close_register.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close_register.TabIndex = 1;
            this.pb_close_register.TabStop = false;
            this.pb_close_register.Click += new System.EventHandler(this.pb_close_register_Click);
            // 
            // pb_minus_register
            // 
            this.pb_minus_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_minus_register.Image = ((System.Drawing.Image)(resources.GetObject("pb_minus_register.Image")));
            this.pb_minus_register.Location = new System.Drawing.Point(833, -5);
            this.pb_minus_register.Name = "pb_minus_register";
            this.pb_minus_register.Size = new System.Drawing.Size(30, 50);
            this.pb_minus_register.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_minus_register.TabIndex = 2;
            this.pb_minus_register.TabStop = false;
            this.pb_minus_register.Click += new System.EventHandler(this.pb_minus_register_Click);
            // 
            // tb_phone_register
            // 
            this.tb_phone_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(248)))));
            this.tb_phone_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phone_register.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_phone_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.tb_phone_register.Location = new System.Drawing.Point(641, 233);
            this.tb_phone_register.Name = "tb_phone_register";
            this.tb_phone_register.PlaceholderText = "Số điện thoại";
            this.tb_phone_register.Size = new System.Drawing.Size(222, 34);
            this.tb_phone_register.TabIndex = 3;
            this.tb_phone_register.Click += new System.EventHandler(this.tb_phone_register_Click);
            // 
            // lb_validate_phone_register
            // 
            this.lb_validate_phone_register.AutoSize = true;
            this.lb_validate_phone_register.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_phone_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_validate_phone_register.Location = new System.Drawing.Point(594, 265);
            this.lb_validate_phone_register.Name = "lb_validate_phone_register";
            this.lb_validate_phone_register.Size = new System.Drawing.Size(0, 28);
            this.lb_validate_phone_register.TabIndex = 4;
            // 
            // tb_name_register
            // 
            this.tb_name_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(248)))));
            this.tb_name_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name_register.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_name_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.tb_name_register.Location = new System.Drawing.Point(641, 363);
            this.tb_name_register.Name = "tb_name_register";
            this.tb_name_register.PlaceholderText = "Họ và tên";
            this.tb_name_register.Size = new System.Drawing.Size(222, 34);
            this.tb_name_register.TabIndex = 5;
            this.tb_name_register.Click += new System.EventHandler(this.tb_name_register_Click);
            // 
            // lb_validate_name_register
            // 
            this.lb_validate_name_register.AutoSize = true;
            this.lb_validate_name_register.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_name_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_validate_name_register.Location = new System.Drawing.Point(618, 394);
            this.lb_validate_name_register.Name = "lb_validate_name_register";
            this.lb_validate_name_register.Size = new System.Drawing.Size(0, 28);
            this.lb_validate_name_register.TabIndex = 6;
            // 
            // tb_pass_register
            // 
            this.tb_pass_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(248)))));
            this.tb_pass_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pass_register.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_pass_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.tb_pass_register.Location = new System.Drawing.Point(641, 492);
            this.tb_pass_register.Name = "tb_pass_register";
            this.tb_pass_register.PlaceholderText = "Mật khẩu";
            this.tb_pass_register.Size = new System.Drawing.Size(222, 34);
            this.tb_pass_register.TabIndex = 7;
            this.tb_pass_register.UseSystemPasswordChar = true;
            this.tb_pass_register.Click += new System.EventHandler(this.tb_pass_register_Click);
            // 
            // lb_validate_pass_register
            // 
            this.lb_validate_pass_register.AutoSize = true;
            this.lb_validate_pass_register.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_pass_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_validate_pass_register.Location = new System.Drawing.Point(618, 521);
            this.lb_validate_pass_register.Name = "lb_validate_pass_register";
            this.lb_validate_pass_register.Size = new System.Drawing.Size(0, 28);
            this.lb_validate_pass_register.TabIndex = 8;
            // 
            // tb_confirm_register
            // 
            this.tb_confirm_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(248)))));
            this.tb_confirm_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_confirm_register.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_confirm_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.tb_confirm_register.Location = new System.Drawing.Point(639, 619);
            this.tb_confirm_register.Name = "tb_confirm_register";
            this.tb_confirm_register.PlaceholderText = "Xác nhận mật khẩu";
            this.tb_confirm_register.Size = new System.Drawing.Size(222, 34);
            this.tb_confirm_register.TabIndex = 9;
            this.tb_confirm_register.UseSystemPasswordChar = true;
            this.tb_confirm_register.Click += new System.EventHandler(this.tb_confirm_register_Click);
            // 
            // lb_validate_confirm_register
            // 
            this.lb_validate_confirm_register.AutoSize = true;
            this.lb_validate_confirm_register.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_confirm_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_validate_confirm_register.Location = new System.Drawing.Point(548, 649);
            this.lb_validate_confirm_register.Name = "lb_validate_confirm_register";
            this.lb_validate_confirm_register.Size = new System.Drawing.Size(0, 28);
            this.lb_validate_confirm_register.TabIndex = 10;
            // 
            // pb_register_register
            // 
            this.pb_register_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_register_register.Image = ((System.Drawing.Image)(resources.GetObject("pb_register_register.Image")));
            this.pb_register_register.Location = new System.Drawing.Point(488, 740);
            this.pb_register_register.Name = "pb_register_register";
            this.pb_register_register.Size = new System.Drawing.Size(181, 60);
            this.pb_register_register.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_register_register.TabIndex = 11;
            this.pb_register_register.TabStop = false;
            this.pb_register_register.Click += new System.EventHandler(this.pb_register_register_Click);
            // 
            // pb_login_register
            // 
            this.pb_login_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_login_register.Image = ((System.Drawing.Image)(resources.GetObject("pb_login_register.Image")));
            this.pb_login_register.Location = new System.Drawing.Point(700, 740);
            this.pb_login_register.Name = "pb_login_register";
            this.pb_login_register.Size = new System.Drawing.Size(181, 60);
            this.pb_login_register.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_login_register.TabIndex = 12;
            this.pb_login_register.TabStop = false;
            this.pb_login_register.Click += new System.EventHandler(this.pb_login_register_Click);
            // 
            // lb_validate_pass_confirm
            // 
            this.lb_validate_pass_confirm.AutoSize = true;
            this.lb_validate_pass_confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_pass_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_validate_pass_confirm.Location = new System.Drawing.Point(510, 558);
            this.lb_validate_pass_confirm.Name = "lb_validate_pass_confirm";
            this.lb_validate_pass_confirm.Size = new System.Drawing.Size(0, 28);
            this.lb_validate_pass_confirm.TabIndex = 13;
            // 
            // FRegister
            // 
            this.ClientSize = new System.Drawing.Size(909, 845);
            this.Controls.Add(this.lb_validate_pass_confirm);
            this.Controls.Add(this.pb_login_register);
            this.Controls.Add(this.pb_register_register);
            this.Controls.Add(this.lb_validate_confirm_register);
            this.Controls.Add(this.tb_confirm_register);
            this.Controls.Add(this.lb_validate_pass_register);
            this.Controls.Add(this.tb_pass_register);
            this.Controls.Add(this.lb_validate_name_register);
            this.Controls.Add(this.tb_name_register);
            this.Controls.Add(this.lb_validate_phone_register);
            this.Controls.Add(this.tb_phone_register);
            this.Controls.Add(this.pb_minus_register);
            this.Controls.Add(this.pb_close_register);
            this.Controls.Add(this.pb_background_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRegister";
            this.Load += new System.EventHandler(this.FRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_background_register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close_register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minus_register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_register_register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login_register)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public FRegister()
        {
            InitializeComponent();
        }

        private void FRegister_Load(object sender, EventArgs e)
        {
            pb_close_register.Parent = pb_background_register;
            pb_minus_register.Parent = pb_background_register;
            pb_register_register.Parent = pb_background_register;
            pb_login_register.Parent = pb_background_register;
            lb_validate_phone_register.Parent = pb_background_register;
            lb_validate_name_register.Parent = pb_background_register;
            lb_validate_pass_register.Parent = pb_background_register;
            lb_validate_confirm_register.Parent = pb_background_register;
            lb_validate_pass_confirm.Parent = pb_background_register;
            // Change background of "Dang Nhap" and "Dang Ki" picturebox to remove white background
            pb_close_register.BackColor = Color.Transparent;
            pb_minus_register.BackColor = Color.Transparent;
            pb_register_register.BackColor = Color.Transparent;
            pb_login_register.BackColor = Color.Transparent;
            lb_validate_phone_register.BackColor = Color.Transparent;
            lb_validate_name_register.BackColor = Color.Transparent;
            lb_validate_pass_register.BackColor = Color.Transparent;
            lb_validate_confirm_register.BackColor = Color.Transparent;
            lb_validate_pass_confirm.BackColor = Color.Transparent;
        }

        private void pb_minus_register_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pb_close_register_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_register_register_Click(object sender, EventArgs e)
        {
            lb_validate_phone_register.Text = lb_validate_name_register.Text = lb_validate_pass_register.Text = lb_validate_confirm_register.Text = lb_validate_pass_confirm.Text = "";
            // validating when click on button "Dang Nhap"
            if (tb_phone_register.Text == "")   // Show message to user
            {
                lb_validate_phone_register.Text = "Số điện thoại chưa nhập!";
                tb_phone_register.Focus();     // Focus on input textbox for user
                return;
            }
            if (tb_name_register.Text == "")    // Show message to user
            {
                lb_validate_name_register.Text = "Họ và tên chưa nhập!";
                tb_name_register.Focus();
                return;
            }
            if (tb_pass_register.Text == "")    // Show message to user
            {
                lb_validate_pass_register.Text = "Mật khẩu chưa nhập!";
                tb_pass_register.Focus();
                return;
            }
            if (tb_confirm_register.Text == "")    // Show message to user
            {
                lb_validate_confirm_register.Text = "Xác nhận mật khẩu chưa nhập!";
                tb_confirm_register.Focus();
                return;
            }
            if (tb_confirm_register.Text != tb_pass_register.Text)
            {
                lb_validate_pass_confirm.Text = "Mật khẩu và xác nhận mật khẩu không khớp";
                tb_confirm_register.Focus();
                return;
            }
        
            // validating user account
            this.ActiveControl = null;
            String sdt = tb_phone_register.Text.ToString();
            String name = tb_name_register.Text.ToString();
            int diemtl = 0;
            String pass = tb_pass_register.Text.ToString();
            if (KhachHangBUS.Instance.checkExistAccount(sdt))
            {
                lb_validate_phone_register.Text = "Số điện thoại tồn tại!";
                return;
            }
            bool check = KhachHangBUS.Instance.insertAccountKhachHang(sdt, name, pass, diemtl);
            if (check)
            {
                MessageBox.Show("Đăng kí thành công");
                this.Hide();
                FLogin f = new FLogin();
                f.Show();
            }
            else
            {
                MessageBox.Show("Đăng kí không thành công");
            }
        }

        private void pb_login_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin f = new FLogin();
            f.Show();
        }

        private void tb_phone_register_Click(object sender, EventArgs e)
        {
            tb_phone_register.SelectAll();
            lb_validate_phone_register.Text = "";
        }

        private void tb_name_register_Click(object sender, EventArgs e)
        {
            tb_name_register.SelectAll();
            lb_validate_name_register.Text = "";
        }

        private void tb_pass_register_Click(object sender, EventArgs e)
        {
            tb_pass_register.SelectAll();
            lb_validate_pass_register.Text = "";
        }

        private void tb_confirm_register_Click(object sender, EventArgs e)
        {
            tb_confirm_register.SelectAll();
            lb_validate_confirm_register.Text = "";
        }
    }
}
