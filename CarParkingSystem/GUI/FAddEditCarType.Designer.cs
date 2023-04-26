namespace GUI
{
    partial class FAddEditCarType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddEditCarType));
            this.pb_background = new System.Windows.Forms.PictureBox();
            this.tb_tenlx_add = new System.Windows.Forms.TextBox();
            this.tb_phigiu_add = new System.Windows.Forms.TextBox();
            this.pb_update = new System.Windows.Forms.PictureBox();
            this.pb_add = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_background
            // 
            this.pb_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_background.Image = ((System.Drawing.Image)(resources.GetObject("pb_background.Image")));
            this.pb_background.Location = new System.Drawing.Point(0, 0);
            this.pb_background.Name = "pb_background";
            this.pb_background.Size = new System.Drawing.Size(982, 751);
            this.pb_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_background.TabIndex = 0;
            this.pb_background.TabStop = false;
            // 
            // tb_tenlx_add
            // 
            this.tb_tenlx_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tb_tenlx_add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_tenlx_add.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_tenlx_add.ForeColor = System.Drawing.Color.Teal;
            this.tb_tenlx_add.Location = new System.Drawing.Point(378, 269);
            this.tb_tenlx_add.Name = "tb_tenlx_add";
            this.tb_tenlx_add.Size = new System.Drawing.Size(262, 34);
            this.tb_tenlx_add.TabIndex = 3;
            // 
            // tb_phigiu_add
            // 
            this.tb_phigiu_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tb_phigiu_add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phigiu_add.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_phigiu_add.ForeColor = System.Drawing.Color.Teal;
            this.tb_phigiu_add.Location = new System.Drawing.Point(374, 493);
            this.tb_phigiu_add.Name = "tb_phigiu_add";
            this.tb_phigiu_add.Size = new System.Drawing.Size(262, 34);
            this.tb_phigiu_add.TabIndex = 4;
            // 
            // pb_update
            // 
            this.pb_update.BackColor = System.Drawing.Color.Transparent;
            this.pb_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_update.Image = ((System.Drawing.Image)(resources.GetObject("pb_update.Image")));
            this.pb_update.Location = new System.Drawing.Point(389, 635);
            this.pb_update.Name = "pb_update";
            this.pb_update.Size = new System.Drawing.Size(180, 60);
            this.pb_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_update.TabIndex = 12;
            this.pb_update.TabStop = false;
            this.pb_update.Click += new System.EventHandler(this.pb_update_Click);
            // 
            // pb_add
            // 
            this.pb_add.BackColor = System.Drawing.Color.Transparent;
            this.pb_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_add.Image = ((System.Drawing.Image)(resources.GetObject("pb_add.Image")));
            this.pb_add.Location = new System.Drawing.Point(389, 635);
            this.pb_add.Name = "pb_add";
            this.pb_add.Size = new System.Drawing.Size(180, 60);
            this.pb_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_add.TabIndex = 13;
            this.pb_add.TabStop = false;
            this.pb_add.Click += new System.EventHandler(this.pb_add_Click);
            // 
            // FAddEditCarType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 751);
            this.Controls.Add(this.pb_add);
            this.Controls.Add(this.pb_update);
            this.Controls.Add(this.tb_phigiu_add);
            this.Controls.Add(this.tb_tenlx_add);
            this.Controls.Add(this.pb_background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 798);
            this.MinimumSize = new System.Drawing.Size(1000, 798);
            this.Name = "FAddEditCarType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAddEditCarType";
            this.Load += new System.EventHandler(this.FAddEditCarType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_background;
        private TextBox tb_tenlx_add;
        private TextBox tb_phigiu_add;
        private PictureBox pb_update;
        private PictureBox pb_add;
    }
}