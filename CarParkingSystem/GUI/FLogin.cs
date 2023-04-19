using BUS;
using DTO;

namespace GUI
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            pb_login_login.Parent = pb_form_background;
            pb_register_login.Parent = pb_form_background;
            pb_close.Parent = pb_form_background;
            pb_minus.Parent = pb_form_background;
            lb_validate_phone.Parent = pb_form_background;
            lb_validate_pass.Parent = pb_form_background;
            lb_validate_msg.Parent = pb_form_background;
            // Change background of "Dang Nhap" and "Dang Ki" picturebox to remove white background
            pb_login_login.BackColor = Color.Transparent; 
            pb_register_login.BackColor = Color.Transparent;
            pb_close.BackColor = Color.Transparent;
            pb_minus.BackColor = Color.Transparent;
            lb_validate_phone.BackColor = Color.Transparent;
            lb_validate_pass.BackColor = Color.Transparent;
            lb_validate_msg.BackColor = Color.Transparent;
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_minus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void tb_phone_login_TextChanged(object sender, EventArgs e)
        {
            lb_validate_phone.Text = "";
        }
        private void tb_pass_login_TextChanged(object sender, EventArgs e)
        {
            lb_validate_pass.Text = "";
        }
        private void tb_phone_login_Click(object sender, EventArgs e)
        {
            tb_phone_login.SelectAll();
            lb_validate_phone.Text = "";
            lb_validate_pass.Text = "";
            lb_validate_msg.Text = "";
        }
        private void tb_pass_login_Click(object sender, EventArgs e)
        {
            tb_pass_login.SelectAll();
            lb_validate_phone.Text = "";
            lb_validate_pass.Text = "";
            lb_validate_msg.Text = "";
        }
        private void pb_login_login_Click(object sender, EventArgs e)
        {
            // validating when click on button "Dang Nhap"
            if(tb_phone_login.Text == "")   // Show message to user
            {
                lb_validate_phone.Text = "Số điện thoại chưa nhập!";
                tb_phone_login.Focus();     // Focus on input textbox for user
                return;
            }
            if(tb_pass_login.Text == "")    // Show message to user
            {
                lb_validate_pass.Text = "Mật khẩu chưa nhập!";
                tb_pass_login.Focus();
                return;
            }
            // validating user account
            this.ActiveControl = null;
            String sdt = tb_phone_login.Text.ToString();
            String pass = tb_pass_login.Text.ToString();
            KhachHang khachhang = null;
            khachhang = KhachHangBUS.Instance.checkAccount(sdt, pass);
            if (khachhang != null)
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                lb_validate_msg.Text = "Sai tên tài khoản hoặc mật khẩu!";
            }

        }

        private void pb_register_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRegister f = new FRegister();
            f.Show();
        }
    }
}