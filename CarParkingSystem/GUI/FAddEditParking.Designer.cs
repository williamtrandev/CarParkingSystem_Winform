namespace GUI
{
    partial class FAddEditParking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddEditParking));
            this.pb_background = new System.Windows.Forms.PictureBox();
            this.tb_tenbx_add = new System.Windows.Forms.TextBox();
            this.tb_succhua_add = new System.Windows.Forms.TextBox();
            this.pb_add_parking = new System.Windows.Forms.PictureBox();
            this.pb_update_parking = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add_parking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_update_parking)).BeginInit();
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
            // tb_tenbx_add
            // 
            this.tb_tenbx_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tb_tenbx_add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_tenbx_add.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_tenbx_add.ForeColor = System.Drawing.Color.Teal;
            this.tb_tenbx_add.Location = new System.Drawing.Point(364, 261);
            this.tb_tenbx_add.Name = "tb_tenbx_add";
            this.tb_tenbx_add.Size = new System.Drawing.Size(262, 34);
            this.tb_tenbx_add.TabIndex = 1;
            // 
            // tb_succhua_add
            // 
            this.tb_succhua_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tb_succhua_add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_succhua_add.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_succhua_add.ForeColor = System.Drawing.Color.Teal;
            this.tb_succhua_add.Location = new System.Drawing.Point(364, 493);
            this.tb_succhua_add.Name = "tb_succhua_add";
            this.tb_succhua_add.Size = new System.Drawing.Size(262, 34);
            this.tb_succhua_add.TabIndex = 2;
            // 
            // pb_add_parking
            // 
            this.pb_add_parking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_add_parking.Image = ((System.Drawing.Image)(resources.GetObject("pb_add_parking.Image")));
            this.pb_add_parking.Location = new System.Drawing.Point(402, 632);
            this.pb_add_parking.Name = "pb_add_parking";
            this.pb_add_parking.Size = new System.Drawing.Size(180, 61);
            this.pb_add_parking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_add_parking.TabIndex = 3;
            this.pb_add_parking.TabStop = false;
            this.pb_add_parking.Click += new System.EventHandler(this.pb_add_parking_Click);
            // 
            // pb_update_parking
            // 
            this.pb_update_parking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_update_parking.Image = ((System.Drawing.Image)(resources.GetObject("pb_update_parking.Image")));
            this.pb_update_parking.Location = new System.Drawing.Point(402, 632);
            this.pb_update_parking.Name = "pb_update_parking";
            this.pb_update_parking.Size = new System.Drawing.Size(180, 61);
            this.pb_update_parking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_update_parking.TabIndex = 4;
            this.pb_update_parking.TabStop = false;
            this.pb_update_parking.Click += new System.EventHandler(this.pb_update_parking_Click);
            // 
            // FAddEditParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.pb_update_parking);
            this.Controls.Add(this.pb_add_parking);
            this.Controls.Add(this.tb_succhua_add);
            this.Controls.Add(this.tb_tenbx_add);
            this.Controls.Add(this.pb_background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "FAddEditParking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAddEditParking";
            this.Load += new System.EventHandler(this.FAddEditParking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add_parking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_update_parking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_background;
        private TextBox tb_tenbx_add;
        private TextBox tb_succhua_add;
        private PictureBox pb_add_parking;
        private PictureBox pb_update_parking;
    }
}