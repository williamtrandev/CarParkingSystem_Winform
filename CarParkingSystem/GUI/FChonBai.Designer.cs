namespace GUI
{
    partial class FChonBai
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_chonbai = new System.Windows.Forms.ComboBox();
            this.btn_chonbai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(317, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn bãi xe";
            // 
            // cb_chonbai
            // 
            this.cb_chonbai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chonbai.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_chonbai.FormattingEnabled = true;
            this.cb_chonbai.Location = new System.Drawing.Point(230, 153);
            this.cb_chonbai.Name = "cb_chonbai";
            this.cb_chonbai.Size = new System.Drawing.Size(336, 49);
            this.cb_chonbai.TabIndex = 1;
            // 
            // btn_chonbai
            // 
            this.btn_chonbai.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_chonbai.Location = new System.Drawing.Point(317, 270);
            this.btn_chonbai.Name = "btn_chonbai";
            this.btn_chonbai.Size = new System.Drawing.Size(148, 51);
            this.btn_chonbai.TabIndex = 2;
            this.btn_chonbai.Text = "Chọn";
            this.btn_chonbai.UseVisualStyleBackColor = true;
            this.btn_chonbai.Click += new System.EventHandler(this.btn_chonbai_Click);
            // 
            // FChonBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 440);
            this.Controls.Add(this.btn_chonbai);
            this.Controls.Add(this.cb_chonbai);
            this.Controls.Add(this.label1);
            this.Name = "FChonBai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn bãi xe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cb_chonbai;
        private Button btn_chonbai;
    }
}