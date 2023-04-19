namespace GUI
{
    partial class FRegister
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

        private PictureBox pb_background_register;
        private PictureBox pb_close_register;
        private PictureBox pb_minus_register;
        private TextBox tb_phone_register;
        private Label lb_validate_phone_register;
        private TextBox tb_name_register;
        private Label lb_validate_name_register;
        private TextBox tb_pass_register;
        private Label lb_validate_pass_register;
        private TextBox tb_confirm_register;
        private Label lb_validate_confirm_register;
        private PictureBox pb_register_register;
        private PictureBox pb_login_register;
        private Label lb_validate_pass_confirm;
    }
}