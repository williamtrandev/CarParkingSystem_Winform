namespace GUI
{
    partial class FLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.pb_form_background = new System.Windows.Forms.PictureBox();
            this.tb_phone_login = new System.Windows.Forms.TextBox();
            this.tb_pass_login = new System.Windows.Forms.TextBox();
            this.pb_login_login = new System.Windows.Forms.PictureBox();
            this.pb_register_login = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pb_minus = new System.Windows.Forms.PictureBox();
            this.lb_validate_pass = new System.Windows.Forms.Label();
            this.lb_validate_phone = new System.Windows.Forms.Label();
            this.lb_validate_msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_form_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_register_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minus)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_form_background
            // 
            this.pb_form_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_form_background.Image = ((System.Drawing.Image)(resources.GetObject("pb_form_background.Image")));
            this.pb_form_background.Location = new System.Drawing.Point(0, 0);
            this.pb_form_background.Name = "pb_form_background";
            this.pb_form_background.Size = new System.Drawing.Size(932, 603);
            this.pb_form_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_form_background.TabIndex = 0;
            this.pb_form_background.TabStop = false;
            // 
            // tb_phone_login
            // 
            this.tb_phone_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(248)))));
            this.tb_phone_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phone_login.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_phone_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.tb_phone_login.Location = new System.Drawing.Point(660, 235);
            this.tb_phone_login.Name = "tb_phone_login";
            this.tb_phone_login.PlaceholderText = "Số điện thoại";
            this.tb_phone_login.Size = new System.Drawing.Size(200, 34);
            this.tb_phone_login.TabIndex = 3;
            this.tb_phone_login.Click += new System.EventHandler(this.tb_phone_login_Click);
            this.tb_phone_login.TextChanged += new System.EventHandler(this.tb_phone_login_TextChanged);
            // 
            // tb_pass_login
            // 
            this.tb_pass_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(196)))), ((int)(((byte)(248)))));
            this.tb_pass_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pass_login.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_pass_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(132)))), ((int)(((byte)(174)))));
            this.tb_pass_login.Location = new System.Drawing.Point(660, 374);
            this.tb_pass_login.Name = "tb_pass_login";
            this.tb_pass_login.PlaceholderText = "Mật khẩu";
            this.tb_pass_login.Size = new System.Drawing.Size(200, 34);
            this.tb_pass_login.TabIndex = 4;
            this.tb_pass_login.UseSystemPasswordChar = true;
            this.tb_pass_login.Click += new System.EventHandler(this.tb_pass_login_Click);
            this.tb_pass_login.TextChanged += new System.EventHandler(this.tb_pass_login_TextChanged);
            // 
            // pb_login_login
            // 
            this.pb_login_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_login_login.Image = ((System.Drawing.Image)(resources.GetObject("pb_login_login.Image")));
            this.pb_login_login.Location = new System.Drawing.Point(536, 482);
            this.pb_login_login.Name = "pb_login_login";
            this.pb_login_login.Size = new System.Drawing.Size(181, 60);
            this.pb_login_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_login_login.TabIndex = 5;
            this.pb_login_login.TabStop = false;
            this.pb_login_login.Click += new System.EventHandler(this.pb_login_login_Click);
            // 
            // pb_register_login
            // 
            this.pb_register_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_register_login.Image = ((System.Drawing.Image)(resources.GetObject("pb_register_login.Image")));
            this.pb_register_login.Location = new System.Drawing.Point(741, 482);
            this.pb_register_login.Name = "pb_register_login";
            this.pb_register_login.Size = new System.Drawing.Size(181, 60);
            this.pb_register_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_register_login.TabIndex = 6;
            this.pb_register_login.TabStop = false;
            this.pb_register_login.Click += new System.EventHandler(this.pb_register_login_Click);
            // 
            // pb_close
            // 
            this.pb_close.BackColor = System.Drawing.Color.Transparent;
            this.pb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(892, 0);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(40, 40);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close.TabIndex = 7;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // pb_minus
            // 
            this.pb_minus.BackColor = System.Drawing.Color.Transparent;
            this.pb_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_minus.Image = ((System.Drawing.Image)(resources.GetObject("pb_minus.Image")));
            this.pb_minus.Location = new System.Drawing.Point(848, -5);
            this.pb_minus.Name = "pb_minus";
            this.pb_minus.Size = new System.Drawing.Size(30, 50);
            this.pb_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_minus.TabIndex = 8;
            this.pb_minus.TabStop = false;
            this.pb_minus.Click += new System.EventHandler(this.pb_minus_Click);
            // 
            // lb_validate_pass
            // 
            this.lb_validate_pass.AutoSize = true;
            this.lb_validate_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_validate_pass.Location = new System.Drawing.Point(639, 411);
            this.lb_validate_pass.Name = "lb_validate_pass";
            this.lb_validate_pass.Size = new System.Drawing.Size(0, 28);
            this.lb_validate_pass.TabIndex = 9;
            // 
            // lb_validate_phone
            // 
            this.lb_validate_phone.AutoSize = true;
            this.lb_validate_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_validate_phone.Location = new System.Drawing.Point(628, 272);
            this.lb_validate_phone.Name = "lb_validate_phone";
            this.lb_validate_phone.Size = new System.Drawing.Size(0, 28);
            this.lb_validate_phone.TabIndex = 10;
            // 
            // lb_validate_msg
            // 
            this.lb_validate_msg.AutoSize = true;
            this.lb_validate_msg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_msg.ForeColor = System.Drawing.Color.Fuchsia;
            this.lb_validate_msg.Location = new System.Drawing.Point(571, 311);
            this.lb_validate_msg.Name = "lb_validate_msg";
            this.lb_validate_msg.Size = new System.Drawing.Size(0, 28);
            this.lb_validate_msg.TabIndex = 11;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.lb_validate_msg);
            this.Controls.Add(this.lb_validate_phone);
            this.Controls.Add(this.lb_validate_pass);
            this.Controls.Add(this.pb_minus);
            this.Controls.Add(this.pb_close);
            this.Controls.Add(this.pb_register_login);
            this.Controls.Add(this.pb_login_login);
            this.Controls.Add(this.tb_pass_login);
            this.Controls.Add(this.tb_phone_login);
            this.Controls.Add(this.pb_form_background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_form_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_register_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_form_background;
        private TextBox tb_phone_login;
        private TextBox tb_pass_login;
        private PictureBox pb_login_login;
        private PictureBox pb_register_login;
        private PictureBox pb_close;
        private PictureBox pb_minus;
        private Label lb_validate_pass;
        private Label lb_validate_phone;
        private Label lb_validate_msg;
    }
}