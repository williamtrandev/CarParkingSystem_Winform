using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class FAddEditStaff : Form
    {
        private FMainManager fmm;
        private bool action;
        static string sdtcu = "";

        public FAddEditStaff(FMainManager fmm, bool action)
        {
            InitializeComponent();
            this.fmm = fmm;
            this.action = action;
        }

        private void pb_add_Click(object sender, EventArgs e)
        {
            lb_validate_phone.Text = lb_validate_name.Text = lb_validate_pass.Text = lb_validate_diachi.Text = "";
            // validating when click on button "Dang Nhap"
            if (tb_phone.Text == "")   // Show message to user
            {
                lb_validate_phone.Text = "Số điện thoại chưa nhập!";
                tb_phone.Focus();     // Focus on input textbox for user
                return;
            }
            if (tb_name.Text == "")    // Show message to user
            {
                lb_validate_name.Text = "Họ và tên chưa nhập!";
                tb_name.Focus();
                return;
            }
            if (tb_diachi.Text == "")    // Show message to user
            {
                lb_validate_diachi.Text = "Địa chỉ chưa nhập!";
                tb_diachi.Focus();
                return;
            }
            if (tb_pass.Text == "")    // Show message to user
            {
                lb_validate_pass.Text = "Mật khẩu chưa nhập!";
                tb_pass.Focus();
                return;
            }
            
            // validating user account
            this.ActiveControl = null;
            String sdt = tb_phone.Text.ToString();
            String name = tb_name.Text.ToString();
            String diachi = tb_diachi.Text.ToString();
            String pass = tb_pass.Text.ToString();
            int loainv = cb_loainv.SelectedItem.ToString() == "Quản lý" ? 1 : 0;
            if (NhanVienBUS.Instance.checkExistAccount(sdt))
            {
                lb_validate_phone.Text = "Số điện thoại tồn tại!";
                return;
            }
            bool check = NhanVienBUS.Instance.insertAccountNhanVien(sdt, name, diachi, pass, loainv);
            if (check)
            {
                MessageBox.Show("Thêm nhân viên thành công");
                this.Hide();
                fmm.loadStaff();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void FAddEditStaff_Load(object sender, EventArgs e)
        {
            if (action)
            {
                pb_background.Image = Properties.Resources.addStaff;
                pb_add.Visible = true;
                pb_update.Visible = false;
            }
            else
            {
                pb_background.Image = Properties.Resources.editStaff;
                pb_add.Visible = false;
                pb_update.Visible = true;
                DataRowView rowSelect = (DataRowView)fmm.bs_nhanvien.Current;   // Get the row that is selected in Form Main
                tb_phone.Text = rowSelect["SODT"].ToString();
                sdtcu = rowSelect["SODT"].ToString();
                tb_name.Text = rowSelect["TENNV"].ToString();
                tb_pass.Text = rowSelect["PASS"].ToString();
                tb_diachi.Text = rowSelect["DIACHI"].ToString();
            }
            lb_validate_loainv.Parent = pb_background;
            lb_validate_phone.Parent = pb_background;
            lb_validate_name.Parent = pb_background;
            lb_validate_diachi.Parent = pb_background;
            lb_validate_pass.Parent = pb_background;
            pb_add.Parent = pb_background;
            pb_update.Parent = pb_background;
            cb_loainv.Items.Add("Nhân viên bãi");
            cb_loainv.Items.Add("Quản lý");
        }

        private void pb_update_Click(object sender, EventArgs e)
        {
            lb_validate_phone.Text = lb_validate_name.Text = lb_validate_pass.Text = lb_validate_diachi.Text = "";
            // validating when click on button "Cap Nhat"
            if (tb_phone.Text == "")   // Show message to user
            {
                lb_validate_phone.Text = "Số điện thoại chưa nhập!";
                tb_phone.Focus();     // Focus on input textbox for user
                return;
            }
            if (tb_name.Text == "")    // Show message to user
            {
                lb_validate_name.Text = "Họ và tên chưa nhập!";
                tb_name.Focus();
                return;
            }
            if (tb_diachi.Text == "")    // Show message to user
            {
                lb_validate_diachi.Text = "Địa chỉ chưa nhập!";
                tb_diachi.Focus();
                return;
            }
            if (tb_pass.Text == "")    // Show message to user
            {
                lb_validate_pass.Text = "Mật khẩu chưa nhập!";
                tb_pass.Focus();
                return;
            }
            if (cb_loainv.SelectedIndex == -1)
            {
                lb_validate_loainv.Text = "Vui lòng chọn loại nhân viên";
                return;
            }
            // validating user account
            this.ActiveControl = null;
            String sdt = tb_phone.Text.ToString();
            String name = tb_name.Text.ToString();
            String diachi = tb_diachi.Text.ToString();
            String pass = tb_pass.Text.ToString();
            int loainv = cb_loainv.SelectedItem.ToString() == "Quản lý" ? 1 : 0;
            
            if (NhanVienBUS.Instance.checkExistAccount(sdt))
            {
                lb_validate_phone.Text = "Số điện thoại tồn tại!";
                return;
            }
            bool check = NhanVienBUS.Instance.updateAccountNhanVien(sdtcu, sdt, name, diachi, pass, loainv);
            if (check)
            {
                MessageBox.Show("Cập nhật thành công");
                this.Hide();
                fmm.loadStaff();

            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }
    }
}
