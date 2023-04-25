using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FMainStaff : Form
    {
        Image imgBackgroundChoose = null;  // Variable that store background image
        int mabai;
        private NhanVien nhanvien = new NhanVien();

        public NhanVien Nhanvien { get => nhanvien; set => nhanvien = value; }
        public FMainStaff(int mabai)
        {
            InitializeComponent();
            this.mabai = mabai;
            this.imgBackgroundChoose = Properties.Resources.background_change;
        }
        // Function to change visible attribute to false
        private void changeVisible(Panel pnl = null)
        {
            pnl_default.Visible = false;
            pnl_control_dsxtb.Visible = false;
            pnl_control_xrvb.Visible = false;
            pnl_control_dsdt.Visible = false;
            if (pnl != null)
            {
                pnl.Visible = true;
            }
        }

        // Function to change background of enable panel
        private void changeBackgroundPanel(Panel pnl)
        {
            // Change background image of all panel to none value
            pnl_dsxtb.BackgroundImage = base.BackgroundImage;
            pnl_xrvb.BackgroundImage = base.BackgroundImage;
            pnl_dsxtb.BackgroundImage = base.BackgroundImage;
            pnl_xrvb.BackgroundImage = base.BackgroundImage;
            pnl_dsdt.BackgroundImage = base.BackgroundImage;
            // Change background image of the pnl that clicked
            pnl.BackgroundImage = imgBackgroundChoose;
            pnl.BackgroundImageLayout = ImageLayout.Stretch;
        }
        void changeSize()
        {
            int width = pnl_wrapper.Width / 4;
            int height = pnl_wrapper.Height;
            int x = 0, y = 0;

            pnl_mid.Size = new System.Drawing.Size(width, height);
            pnl_mid.Location = new Point(pnl_left.Width + width/2, 0);
            pnl_left.Size = new System.Drawing.Size(width, height);
            pnl_left.Location = new Point(width/2, 0);
            pnl_left.Margin = new Padding(width/2, 0, 0, 0);
            pnl_right.Size = new System.Drawing.Size(width, height);
            pnl_right.Location = new Point(pnl_left.Width + pnl_mid.Width + width/2, 0);
            pnl_right.Margin = new Padding(0, 0, width/2, 0);

        }
        private void FMainStaff_Load(object sender, EventArgs e)
        {
            lb_dsxtb.Parent = pnl_dsxtb;
            lb_dsxtb.BackColor = Color.Transparent;
            lb_xrvb.Parent = pnl_xrvb;
            lb_xrvb.BackColor = Color.Transparent;
            lb_dsdt.Parent = pnl_dsdt;
            lb_dsdt.BackColor = Color.Transparent;
            btn_morao.Enabled = false;
            changeVisible(pnl_default);
            loadCar(this.mabai);
            loadTheVao(this.mabai);
            loadTheRa(this.mabai);
            loadDonDatCho(this.mabai);
            loadVitri(this.mabai);
            changeSize();
        }
        void loadCar(int mabai)
        {
            flp_dsxtb.Controls.Clear(); // Clear all element
            int w = flp_dsxtb.Width / 6, h = w / 2;
            List<ViTri> vitri = BUS.ViTriBUS.Instance.getAllXe(mabai);
            foreach (ViTri vt in vitri)
            {
                int pa = (flp_dsxtb.Width - 4 * w - 100) / 3;
                Button btn = new Button() { Width = w, Height = w / 2 };
                if(vt.TINHTRANG == 1)
                {
                    btn.BackgroundImage = Properties.Resources.car_parking;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.BackColor = Color.Turquoise;
                } else if(vt.TINHTRANG == 2)
                {
                    btn.BackgroundImage = Properties.Resources.car_parking;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.BackColor = Color.Bisque;

                }
                int i = vt.SOVITRI;
                btn.Text = i.ToString();
                btn.Font = new Font("Arial", 15);
                btn.TextAlign = ContentAlignment.TopLeft;
                if (i % 4 == 1)
                {
                    btn.Margin = new Padding(pa, 25, 25, 25);
                }
                else if (i % 4 == 0)
                {
                    btn.Margin = new Padding(25, 25, pa, 25);
                }
                else
                {
                    btn.Margin = new Padding(25, 25, 25, 25);
                }
                flp_dsxtb.Controls.Add(btn);
            }
        }
        void loadDonDatCho(int mabai)
        {
            dgv_dsdt.DataSource = BUS.DatChoOnlineBUS.Instance.getAllDon(mabai);
        }
        void loadTheVao(int mabai)
        {
            DataTable dt = BUS.TheBUS.Instance.getAllTheVao(mabai);
            List<SupportThe> items = new List<SupportThe>();
            foreach(DataRow dr in dt.Rows)
            {
                items.Add(new SupportThe { Sothe = (int)dr["SOTHE"], Tenthe = dr["TENTHE"].ToString() });
            }
            cb_thevao.DataSource = items;
            cb_thevao.DisplayMember = "tenthe";
            cb_thevao.SelectedIndex = -1;
        }
        void loadTheRa(int mabai)
        {
            DataTable dt = BUS.TheBUS.Instance.getAllTheRa(mabai);
            List<SupportThe> items = new List<SupportThe>();
            foreach (DataRow dr in dt.Rows)
            {
                items.Add(new SupportThe { Sothe = (int)dr["SOTHE"], Tenthe = dr["TENTHE"].ToString() });
            }
            cb_thera.DataSource = items;
            cb_thera.DisplayMember = "tenthe";
            cb_thera.SelectedIndex = -1;
        }
        void loadVitri(int mabai)
        {
            List<ViTri> lvt = BUS.ViTriBUS.Instance.getVitrisTheoMaBai(mabai);
            cb_vitri.DataSource = lvt;
            cb_vitri.DisplayMember = "sovitri";
        }
        private void lb_dsxtb_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel(pnl_dsxtb);
            changeVisible(pnl_control_dsxtb);
        }

        private void pnl_dsxtb_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel(pnl_dsxtb);
            changeVisible(pnl_control_dsxtb);
        }

        private void lb_xrvb_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel(pnl_xrvb);
            changeVisible(pnl_control_xrvb);
        }

        private void pnl_xrvb_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel(pnl_xrvb);
            changeVisible(pnl_control_xrvb);
        }


        private void pnl_dsdt_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel(pnl_dsdt);
            changeVisible(pnl_control_dsdt);
        }

        private void lb_dsdt_Click(object sender, EventArgs e)
        {
            changeBackgroundPanel(pnl_dsdt);
            changeVisible(pnl_control_dsdt);
        }

        private void pb_datcho_Click(object sender, EventArgs e)
        {
            int id_vitri = (int) dgv_dsdt.CurrentRow.Cells["ID_VITRI"].Value;
            int madon = (int) dgv_dsdt.CurrentRow.Cells["MADON"].Value;
            bool checkUpdateViTri = BUS.ViTriBUS.Instance.changeStateVitriDatCho(id_vitri);
            bool checkUpdateDonDat = BUS.DatChoOnlineBUS.Instance.changeStateDon(madon);
            if(checkUpdateViTri && checkUpdateDonDat)
            {
                MessageBox.Show("Chốt đơn đặt chỗ thành công", "Thông báo");
                loadDonDatCho(this.mabai);
                loadCar(this.mabai);
            } else
            {
                MessageBox.Show("Chốt đơn đặt chỗ đã có lỗi", "Thông báo");
            }
        }

        private void pb_huydon_Click(object sender, EventArgs e)
        {
            int madon = (int)dgv_dsdt.CurrentRow.Cells["MADON"].Value;
            bool checkDelete = BUS.DatChoOnlineBUS.Instance.deleteDonDatCho(madon);
            if(checkDelete)
            {
                MessageBox.Show("Hủy đơn đặt chỗ thành công", "Thông báo");
                loadDonDatCho(this.mabai);
            } else
            {
                MessageBox.Show("Hủy đơn đặt chỗ thất bại", "Thông báo");
            }
        }

        private void cb_thera_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_bsdoichieu.Text = "";
            tb_sothedoichieu.Text = "";
            tb_tgvao.Text = "";
            if (cb_thera.SelectedIndex != -1 && tb_bienso.Text.Trim() != "")
            {
                SupportThe selectedItem = (SupportThe) cb_thera.SelectedItem;
                int sothe = selectedItem.Sothe;
                The the = BUS.TheBUS.Instance.getDetail(sothe);
                tb_bsdoichieu.Text = the.BIENSOXE;
                tb_sothedoichieu.Text = the.TENTHE;
                tb_tgvao.Text = (Convert.ToDateTime(the.GIOVAO)).ToString("dd-MM-yyyy HH:mm:ss");
                if(checkValidOut())
                {
                    MessageBox.Show("Hợp lệ, xe có thể ra", "Thông báo");
                    btn_morao.Enabled = true;
                } else
                {
                    MessageBox.Show("Không trùng biển số", "Cảnh báo");
                    btn_morao.Enabled = false;
                }
            }
        }
        bool checkValidOut()
        {
            if (tb_bienso.Text.Trim() == tb_bsdoichieu.Text.Trim())
                return true;
            return false;
        }

        private void btn_choxevao_Click(object sender, EventArgs e)
        {
            if(tb_biensovao.Text.Trim() != "")
            {
                The the = new The();
                SupportThe selectedItem = (SupportThe)cb_thevao.SelectedItem;
                the.SOTHE = selectedItem.Sothe;
                the.BIENSOXE = tb_biensovao.Text.ToString();
                the.GIOVAO = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                the.TRANGTHAI = 1;
                if(tb_sdt.Text.Trim() != "")
                {
                    the.SDTKH = tb_sdt.Text.ToString();
                }
                bool checkUpdate = BUS.TheBUS.Instance.updateThe(the);
                if (checkUpdate)
                {
                    MessageBox.Show("Cho xe vào bãi", "Thông báo");
                    loadTheVao(this.mabai);
                    loadTheRa(this.mabai);
                    tb_biensovao.Clear();
                    tb_sdt.Clear();
                }
            } else
            {
                MessageBox.Show("Chưa nhận dạng được biển số", "Cảnh báo");
            }
            
        }

        private void btn_kiemtra_Click(object sender, EventArgs e)
        {
            tb_bsdoichieu.Text = "";
            tb_sothedoichieu.Text = "";
            tb_tgvao.Text = "";
            if (cb_thera.SelectedIndex != -1 && tb_bienso.Text.Trim() != "")
            {
                SupportThe selectedItem = (SupportThe)cb_thera.SelectedItem;
                int sothe = selectedItem.Sothe;
                The the = BUS.TheBUS.Instance.getDetail(sothe);
                tb_bsdoichieu.Text = the.BIENSOXE;
                tb_sothedoichieu.Text = the.TENTHE;
                tb_tgvao.Text = (Convert.ToDateTime(the.GIOVAO)).ToString("dd-MM-yyyy HH:mm:ss");
                if (checkValidOut())
                {
                    MessageBox.Show("Hợp lệ, xe có thể ra", "Thông báo");
                    btn_morao.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Không trùng biển số", "Cảnh báo");
                    btn_morao.Enabled = false;
                }
            }
        }

        private void btn_xedattruoc_Click(object sender, EventArgs e)
        {
            tb_sdt.Enabled = true;
        }

        private void FMainStaff_Resize(object sender, EventArgs e)
        {
            changeSize();
        }

        /*private void btn_morao_Click(object sender, EventArgs e)
        {
            SupportThe selectedItem = (SupportThe)cb_thera.SelectedItem;
            int sothe = selectedItem.Sothe;
            The the = BUS.TheBUS.Instance.getDetail(sothe);
            bool checkInsert = BUS.HoaDonBUS.Instance.insertHoaDon(the.SDTKH, this.nv.SDT, );
        }*/
    }
}
