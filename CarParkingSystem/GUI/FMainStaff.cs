﻿using DTO;
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
        
        public FMainStaff()
        {
            InitializeComponent();
            this.mabai = 1;
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

        private void FMainStaff_Load(object sender, EventArgs e)
        {
            lb_dsxtb.Parent = pnl_dsxtb;
            lb_dsxtb.BackColor = Color.Transparent;
            lb_xrvb.Parent = pnl_xrvb;
            lb_xrvb.BackColor = Color.Transparent;
            lb_dsdt.Parent = pnl_dsdt;
            lb_dsdt.BackColor = Color.Transparent;
            changeVisible(pnl_default);
            loadCar(1);
            loadTheVao(this.mabai);
            loadTheRa(this.mabai);
            loadDonDatCho(this.mabai);
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
                loadCar(1);
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
          /*  SupportThe selectedItem = (SupportThe) cb_thera.SelectedItem;
            int sothe = selectedItem.Sothe;
            The the = BUS.TheBUS.Instance.getDetail(sothe);
            tb_bsdoichieu.Text = the.BIENSOXE;
            tb_sothedoichieu.Text = the.TENTHE;
            tb_tgvao.Text = the.GIOVAO;*/
        }
    }
}