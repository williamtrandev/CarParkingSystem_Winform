using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FMainManager : Form
    {
        Image imgBackgroundChoose = null;  // Variable that store background image
        public BindingSource bs_khachhang, bs_nhanvien;
        public FMainManager()
        {
            InitializeComponent();
            bs_khachhang = new BindingSource();
            bs_nhanvien = new BindingSource();
        }
        private void FMainManager_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            CenterTheBox();
            pnl_control_qlkh.Visible = false;
            pnl_control_qlnv.Visible = false;
            pnl_control_bcdt.Visible = false;
            pnl_control_qlbx.Visible = false;
            // Set background of label to transparent
            lb_qlnv.Parent = pnl_qlnv;
            lb_qlbx.Parent = pnl_qlbx;
            lb_qlkh.Parent = pnl_qlkh;
            lb_lsrv.Parent = pnl_lsrv;
            lb_bcdt.Parent = pnl_bcdt;
            lb_qlnv.BackColor = Color.Transparent;
            lb_qlbx.BackColor = Color.Transparent;
            lb_qlkh.BackColor = Color.Transparent;
            lb_lsrv.BackColor = Color.Transparent;
            lb_bcdt.BackColor = Color.Transparent;
            this.imgBackgroundChoose = Properties.Resources.background_change;
            loadCustomer();
            loadStaff();
        }
        private void FMainManager_Resize(object sender, EventArgs e)
        {
            CenterTheBox();
        }
        // Function to center delete and update button in tab QuanLyKhachHang
        private void CenterTheBox()
        {
            var left_update = pnl_bottom.ClientRectangle.Width / 2 - (pb_delete_qlkh.ClientRectangle.Width + 30);
            var left_delete = pnl_bottom.ClientRectangle.Width / 2 + 30;
            var left_add = pnl_bottom_qlnv.ClientRectangle.Width / 2 - (pb_add_qlnv.ClientRectangle.Width / 2);
            var left_update_qlnv = pnl_bottom_qlnv.ClientRectangle.Width / 2 - (pb_add_qlnv.ClientRectangle.Width + pb_add_qlnv.ClientRectangle.Width / 2 + 30);
            var left_delete_qlnv = pnl_bottom_qlnv.ClientRectangle.Width / 2 + (pb_add_qlnv.ClientRectangle.Width / 2 + 30);
            var top = (pnl_bottom.ClientRectangle.Height - pb_delete_qlkh.ClientRectangle.Height) / 2;
            pb_update_qlkh.Location = new Point(pnl_bottom.ClientRectangle.Location.X + left_update, pnl_bottom.ClientRectangle.Location.Y + top);
            pb_delete_qlkh.Location = new Point(pnl_bottom.ClientRectangle.Location.X + left_delete, pnl_bottom.ClientRectangle.Location.Y + top);
            pb_add_qlnv.Location = new Point(pnl_bottom.ClientRectangle.Location.X + left_add, pnl_bottom.ClientRectangle.Location.Y + top);
            pb_update_qlnv.Location = new Point(pnl_bottom.ClientRectangle.Location.X + left_update_qlnv, pnl_bottom.ClientRectangle.Location.Y + top);
            pb_delete_qlnv.Location = new Point(pnl_bottom.ClientRectangle.Location.X + left_delete_qlnv, pnl_bottom.ClientRectangle.Location.Y + top);
        }

        // Function to change visible attribute to false
        private void changeVisible(Panel pnl)
        {
            pnl_default.Visible = false;
            pnl_control_qlkh.Visible = false;
            pnl_control_qlnv.Visible = false;
            pnl.Visible = true;
        }

        // Function to change background of enable panel
        private void changeBackgroundPanel(Panel pnl) 
        {
            // Change background image of all panel to none value
            pnl_qlnv.BackgroundImage = base.BackgroundImage;
            pnl_qlkh.BackgroundImage = base.BackgroundImage;
            pnl_qlbx.BackgroundImage = base.BackgroundImage;
            pnl_lsrv.BackgroundImage = base.BackgroundImage;
            pnl_bcdt.BackgroundImage = base.BackgroundImage;    
            // Change background image of the pnl that clicked
            pnl.BackgroundImage = imgBackgroundChoose;
            pnl.BackgroundImageLayout = ImageLayout.Stretch;
        }

      

        private void pnl_qlnv_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel((Panel)sender);
            changeVisible(pnl_control_qlnv);
        }

        private void pnl_qlbx_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel((Panel)sender);
        }

        private void pnl_qlkh_Click(object sender, EventArgs e)
        {   
            changeBackgroundPanel((Panel)sender);
            changeVisible(pnl_control_qlkh);

        }

        private void pnl_lsrv_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel((Panel)sender);

        }

        private void pnl_bcdt_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel((Panel)sender);
        }

        private void lb_qlnv_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel(pnl_qlnv);
            changeVisible(pnl_control_qlnv);

        }

        private void lb_qlbx_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel(pnl_qlbx);
        }

        private void lb_qlkh_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel(pnl_qlkh);
            changeVisible(pnl_control_qlkh);
        }

        private void lb_lsrv_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel(pnl_lsrv);
        }

        private void lb_bcdt_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel(pnl_bcdt);
        }

        // Function that load all customer in database
        public void loadCustomer()
        {
            
            DataTable dt = new DataTable();
            dt = BUS.KhachHangBUS.Instance.getAllCustomer();
            bs_khachhang.DataSource = dt;
            dgv_qlkh.DataSource = bs_khachhang;
        }

        // Function that load all staff in database
        public void loadStaff()
        {
            DataTable dt = new DataTable();
            dt = BUS.NhanVienBUS.Instance.getAllStaff();
            DataTable dtCloned = dt.Clone();
            dtCloned.Columns[4].DataType = typeof(String);
            foreach (DataRow row in dt.Rows)
            {
                dtCloned.ImportRow(row);
            }
            IDictionary<int, string> loainvDict = new Dictionary<int, string>() { { 0, "Nhân viên bãi" }, { 1, "Quản lý"} };
            for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
            {
                dtCloned.Rows[rowIndex][4] = loainvDict[Convert.ToInt32(dt.Rows[rowIndex][4])];
            }
            bs_nhanvien.DataSource = dtCloned;
            dgv_qlnv.DataSource = bs_nhanvien; 
        }

        
        private void pnl_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FLogin f = new FLogin();
            f.Show();
        }

        private void lb_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FLogin f = new FLogin();
            f.Show();
        }

        private void pb_update_qlkh_Click(object sender, EventArgs e)
        {
            FEditCustomer f = new FEditCustomer(this);
            f.Show();
        }

        private void pb_add_qlnv_Click(object sender, EventArgs e)
        {
            FAddEditStaff f = new FAddEditStaff(this, true);
            f.Show();
        }

        private void pb_delete_qlnv_Click(object sender, EventArgs e)
        {
            if (dgv_qlnv.CurrentRow.Cells["SODT_NV"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa nhân viên này không?", "Xóa nhân viên", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool check = BUS.NhanVienBUS.Instance.deleteAccountNhanVien(dgv_qlnv.CurrentRow.Cells["SODT_NV"].Value.ToString());
                    if (check)
                    {
                        loadStaff();
                    }
                }
            }
        }

        private void pb_update_qlnv_Click(object sender, EventArgs e)
        {
            FAddEditStaff f = new FAddEditStaff(this, false);
            f.Show();
        }

        private void pb_delete_qlkh_Click(object sender, EventArgs e)
        {
            if (dgv_qlkh.CurrentRow.Cells["SODT"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa khách hàng này không?", "Xóa khách hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool check = BUS.KhachHangBUS.Instance.deleteAccount(dgv_qlkh.CurrentRow.Cells["SODT"].Value.ToString());
                    if (check)
                    {
                        loadCustomer();
                    }
                }
            }
        }


        
    }
}
