namespace GUI
{
    partial class FAddEditStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddEditStaff));
            this.pb_background = new System.Windows.Forms.PictureBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.cb_loainv = new System.Windows.Forms.ComboBox();
            this.pb_add = new System.Windows.Forms.PictureBox();
            this.lb_validate_phone = new System.Windows.Forms.Label();
            this.lb_validate_name = new System.Windows.Forms.Label();
            this.lb_validate_diachi = new System.Windows.Forms.Label();
            this.lb_validate_pass = new System.Windows.Forms.Label();
            this.pb_update = new System.Windows.Forms.PictureBox();
            this.lb_validate_loainv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_update)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_background
            // 
            this.pb_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_background.Image = ((System.Drawing.Image)(resources.GetObject("pb_background.Image")));
            this.pb_background.Location = new System.Drawing.Point(0, 0);
            this.pb_background.Name = "pb_background";
            this.pb_background.Size = new System.Drawing.Size(982, 753);
            this.pb_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_background.TabIndex = 0;
            this.pb_background.TabStop = false;
            // 
            // tb_phone
            // 
            this.tb_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phone.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_phone.Location = new System.Drawing.Point(99, 193);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(283, 34);
            this.tb_phone.TabIndex = 1;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_name.Location = new System.Drawing.Point(617, 193);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(283, 34);
            this.tb_name.TabIndex = 2;
            // 
            // tb_diachi
            // 
            this.tb_diachi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tb_diachi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_diachi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_diachi.Location = new System.Drawing.Point(99, 387);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(283, 34);
            this.tb_diachi.TabIndex = 3;
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_pass.Location = new System.Drawing.Point(617, 387);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(283, 34);
            this.tb_pass.TabIndex = 4;
            // 
            // cb_loainv
            // 
            this.cb_loainv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.cb_loainv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loainv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_loainv.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_loainv.FormattingEnabled = true;
            this.cb_loainv.Location = new System.Drawing.Point(353, 568);
            this.cb_loainv.Name = "cb_loainv";
            this.cb_loainv.Size = new System.Drawing.Size(273, 43);
            this.cb_loainv.TabIndex = 5;
            // 
            // pb_add
            // 
            this.pb_add.BackColor = System.Drawing.Color.Transparent;
            this.pb_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_add.Image = ((System.Drawing.Image)(resources.GetObject("pb_add.Image")));
            this.pb_add.Location = new System.Drawing.Point(383, 667);
            this.pb_add.Name = "pb_add";
            this.pb_add.Size = new System.Drawing.Size(180, 60);
            this.pb_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_add.TabIndex = 6;
            this.pb_add.TabStop = false;
            this.pb_add.Click += new System.EventHandler(this.pb_add_Click);
            // 
            // lb_validate_phone
            // 
            this.lb_validate_phone.AutoSize = true;
            this.lb_validate_phone.BackColor = System.Drawing.Color.Transparent;
            this.lb_validate_phone.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_validate_phone.Location = new System.Drawing.Point(109, 244);
            this.lb_validate_phone.Name = "lb_validate_phone";
            this.lb_validate_phone.Size = new System.Drawing.Size(0, 30);
            this.lb_validate_phone.TabIndex = 7;
            // 
            // lb_validate_name
            // 
            this.lb_validate_name.AutoSize = true;
            this.lb_validate_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_validate_name.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_validate_name.Location = new System.Drawing.Point(655, 244);
            this.lb_validate_name.Name = "lb_validate_name";
            this.lb_validate_name.Size = new System.Drawing.Size(0, 30);
            this.lb_validate_name.TabIndex = 8;
            // 
            // lb_validate_diachi
            // 
            this.lb_validate_diachi.AutoSize = true;
            this.lb_validate_diachi.BackColor = System.Drawing.Color.Transparent;
            this.lb_validate_diachi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_diachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_validate_diachi.Location = new System.Drawing.Point(136, 442);
            this.lb_validate_diachi.Name = "lb_validate_diachi";
            this.lb_validate_diachi.Size = new System.Drawing.Size(0, 30);
            this.lb_validate_diachi.TabIndex = 9;
            // 
            // lb_validate_pass
            // 
            this.lb_validate_pass.AutoSize = true;
            this.lb_validate_pass.BackColor = System.Drawing.Color.Transparent;
            this.lb_validate_pass.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_validate_pass.Location = new System.Drawing.Point(655, 442);
            this.lb_validate_pass.Name = "lb_validate_pass";
            this.lb_validate_pass.Size = new System.Drawing.Size(0, 30);
            this.lb_validate_pass.TabIndex = 10;
            // 
            // pb_update
            // 
            this.pb_update.BackColor = System.Drawing.Color.Transparent;
            this.pb_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_update.Image = ((System.Drawing.Image)(resources.GetObject("pb_update.Image")));
            this.pb_update.Location = new System.Drawing.Point(383, 667);
            this.pb_update.Name = "pb_update";
            this.pb_update.Size = new System.Drawing.Size(180, 60);
            this.pb_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_update.TabIndex = 11;
            this.pb_update.TabStop = false;
            this.pb_update.Click += new System.EventHandler(this.pb_update_Click);
            // 
            // lb_validate_loainv
            // 
            this.lb_validate_loainv.AutoSize = true;
            this.lb_validate_loainv.BackColor = System.Drawing.Color.Transparent;
            this.lb_validate_loainv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_loainv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_validate_loainv.Location = new System.Drawing.Point(353, 625);
            this.lb_validate_loainv.Name = "lb_validate_loainv";
            this.lb_validate_loainv.Size = new System.Drawing.Size(259, 28);
            this.lb_validate_loainv.TabIndex = 12;
            this.lb_validate_loainv.Text = "Vui lòng chọn loại nhân viên";
            // 
            // FAddEditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.lb_validate_loainv);
            this.Controls.Add(this.pb_update);
            this.Controls.Add(this.lb_validate_pass);
            this.Controls.Add(this.lb_validate_diachi);
            this.Controls.Add(this.lb_validate_name);
            this.Controls.Add(this.lb_validate_phone);
            this.Controls.Add(this.pb_add);
            this.Controls.Add(this.cb_loainv);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.pb_background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "FAddEditStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi thông tin nhân viên";
            this.Load += new System.EventHandler(this.FAddEditStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_background;
        private TextBox tb_phone;
        private TextBox tb_name;
        private TextBox tb_diachi;
        private TextBox tb_pass;
        private ComboBox cb_loainv;
        private PictureBox pb_add;
        private Label lb_validate_phone;
        private Label lb_validate_name;
        private Label lb_validate_diachi;
        private Label lb_validate_pass;
        private PictureBox pb_update;
        private Label lb_validate_loainv;
    }
}