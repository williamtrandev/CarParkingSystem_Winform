namespace GUI
{
    partial class FEditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEditCustomer));
            this.pb_background = new System.Windows.Forms.PictureBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_point = new System.Windows.Forms.TextBox();
            this.pb_update = new System.Windows.Forms.PictureBox();
            this.lb_validate_phone = new System.Windows.Forms.Label();
            this.lb_validate_name = new System.Windows.Forms.Label();
            this.lb_validate_pass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_update)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_background
            // 
            this.pb_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_background.Image = ((System.Drawing.Image)(resources.GetObject("pb_background.Image")));
            this.pb_background.Location = new System.Drawing.Point(0, 0);
            this.pb_background.Name = "pb_background";
            this.pb_background.Size = new System.Drawing.Size(963, 553);
            this.pb_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_background.TabIndex = 0;
            this.pb_background.TabStop = false;
            // 
            // tb_phone
            // 
            this.tb_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_phone.Location = new System.Drawing.Point(112, 185);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(251, 32);
            this.tb_phone.TabIndex = 1;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_name.Location = new System.Drawing.Point(622, 185);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(251, 32);
            this.tb_name.TabIndex = 2;
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_pass.Location = new System.Drawing.Point(112, 372);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(251, 32);
            this.tb_pass.TabIndex = 3;
            // 
            // tb_point
            // 
            this.tb_point.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tb_point.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_point.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_point.Location = new System.Drawing.Point(622, 372);
            this.tb_point.Name = "tb_point";
            this.tb_point.Size = new System.Drawing.Size(251, 32);
            this.tb_point.TabIndex = 4;
            // 
            // pb_update
            // 
            this.pb_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_update.Image = ((System.Drawing.Image)(resources.GetObject("pb_update.Image")));
            this.pb_update.Location = new System.Drawing.Point(399, 467);
            this.pb_update.Name = "pb_update";
            this.pb_update.Size = new System.Drawing.Size(181, 60);
            this.pb_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_update.TabIndex = 5;
            this.pb_update.TabStop = false;
            this.pb_update.Click += new System.EventHandler(this.pb_update_Click);
            // 
            // lb_validate_phone
            // 
            this.lb_validate_phone.AutoSize = true;
            this.lb_validate_phone.BackColor = System.Drawing.Color.Transparent;
            this.lb_validate_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_validate_phone.Location = new System.Drawing.Point(97, 232);
            this.lb_validate_phone.Name = "lb_validate_phone";
            this.lb_validate_phone.Size = new System.Drawing.Size(0, 28);
            this.lb_validate_phone.TabIndex = 6;
            // 
            // lb_validate_name
            // 
            this.lb_validate_name.AutoSize = true;
            this.lb_validate_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_validate_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_validate_name.Location = new System.Drawing.Point(617, 235);
            this.lb_validate_name.Name = "lb_validate_name";
            this.lb_validate_name.Size = new System.Drawing.Size(0, 28);
            this.lb_validate_name.TabIndex = 7;
            // 
            // lb_validate_pass
            // 
            this.lb_validate_pass.AutoSize = true;
            this.lb_validate_pass.BackColor = System.Drawing.Color.Transparent;
            this.lb_validate_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_validate_pass.Location = new System.Drawing.Point(91, 421);
            this.lb_validate_pass.Name = "lb_validate_pass";
            this.lb_validate_pass.Size = new System.Drawing.Size(0, 28);
            this.lb_validate_pass.TabIndex = 8;
            // 
            // FEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 553);
            this.Controls.Add(this.lb_validate_pass);
            this.Controls.Add(this.lb_validate_name);
            this.Controls.Add(this.lb_validate_phone);
            this.Controls.Add(this.pb_update);
            this.Controls.Add(this.tb_point);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.pb_background);
            this.Name = "FEditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi thông tin khách hàng";
            this.Load += new System.EventHandler(this.FEditCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_background;
        private TextBox tb_phone;
        private TextBox tb_name;
        private TextBox tb_pass;
        private TextBox tb_point;
        private PictureBox pb_update;
        private Label lb_validate_phone;
        private Label lb_validate_name;
        private Label lb_validate_pass;
    }
}