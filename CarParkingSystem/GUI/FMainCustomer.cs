using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class FMainCustomer : Form
    {
        public BindingSource bs_hd_kh, bs_datchoonline;
        public FMainCustomer()
        {
            InitializeComponent();
            bs_hd_kh = new BindingSource();
            bs_datchoonline = new BindingSource();
        }
        private void FUser_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
            LoadInfo();
            loadViewParkingLot(Listbaigiuxe);
            loadLoaiXe();

            panel_datchoonline.Visible = true;
            panel34_UserInfo.Visible = false;

            // ==============
            //load_donhangonline();




        }


        #region Attribute

        private KhachHang khachhang = new KhachHang();
        private List<BaiGiu> listbaigiuxe = new List<BaiGiu>();
        private List<ViTri> listvitriTheoMaBai = new List<ViTri>();
        private List<LoaiXe> listLoaiXe = new List<LoaiXe>();
        private bool checkdoimatkhau = false;


        public KhachHang Khachhang { get => khachhang; set => khachhang = value; }
        public List<BaiGiu> Listbaigiuxe { get => listbaigiuxe; set => listbaigiuxe = value; }
        public List<ViTri> ListvitriTheoMaBai { get => listvitriTheoMaBai; set => listvitriTheoMaBai = value; }
        public List<LoaiXe> ListLoaiXe { get => listLoaiXe; set => listLoaiXe = value; }

        #endregion

        #region Event Handlers

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            panel_doimatkhau.Visible = !panel_doimatkhau.Visible;

            if (panel_doimatkhau.Visible == true)
            {
                checkdoimatkhau = true;
                //textBox_matkhau.Enabled = true;
            }
            else
            {
                checkdoimatkhau = false;
                //textBox_matkhau.Enabled = false;
            }
        }

        private void label46_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridView_danhsachdatchoon.SelectedCells[0].OwningRow.Cells["madon"].Value.ToString());
            String tinhtrang = dataGridView_danhsachdatchoon.SelectedCells[0].OwningRow.Cells["tinhtrang"].Value.ToString();
            if (tinhtrang.Equals("đặt thành công"))
            {
                MessageBox.Show("Không thể Hủy!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xóa ?", "Đơn này", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int result = DatChoOnlineBUS.Instance.deleteDonOn(id, khachhang.SDT);
                MessageBox.Show("Xóa Thành Công!");
                load_donhangonline();
            }

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (checkdoimatkhau)
            {
                if (!textBox_xacnhanmkht.Text.ToString().Equals(Khachhang.PASS) ||
                    !textBox_matkhaumoi.Text.ToString().Equals(textBox_xacnhanmkmoi.Text.ToString())
                    )
                {
                    MessageBox.Show("Vui Lòng Nhập Đúng các trường thông tin!");
                    return;
                }
                int result = KhachHangBUS.Instance.updateInFoKH(Khachhang.SDT, textBox_ten.Text.ToString(), textBox_xacnhanmkmoi.Text.ToString());
                khachhang.PASS = textBox_xacnhanmkmoi.Text.ToString();
                MessageBox.Show("Success");
            }
            else
            {
                bool containsInt = textBox_ten.Text.ToString().Any(char.IsDigit);
                if (containsInt || textBox_ten.Text.ToString().Equals(""))
                {
                    MessageBox.Show("Lỗi Format! Vui Lòng Kiểm Tra Lại");
                    return;

                }
                int result = KhachHangBUS.Instance.updateInFoKH(Khachhang.SDT, textBox_ten.Text.ToString(), khachhang.PASS);
                MessageBox.Show("Success!");
            }
        }

        private void panel_Click_bai(object sender, EventArgs e)  
        {
            Panel p = sender as Panel;
            // identify which button was clicked and perform necessary actions
            tb_tenbai.Text = p.Name.ToString();
            tb_tenbai.Tag = p.Tag;
            List<ViTri> list = ViTriDAO.Instance.getVitriTheoMaBai((int)p.Tag);
            loadViewLocationCar(list);
            textBox_tenvitri.Text = "";


        }
        private void picture_Click_bai(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            // identify which button was clicked and perform necessary actions
            tb_tenbai.Text = p.Name.ToString();
            tb_tenbai.Tag = p.Tag;
            List<ViTri> list = ViTriDAO.Instance.getVitriTheoMaBai((int)p.Tag);
            loadViewLocationCar(list);
            textBox_tenvitri.Text = "";


        }
        private void label_Click_bai(object sender, EventArgs e)
        {
            Label p = sender as Label;
            // identify which button was clicked and perform necessary actions

            tb_tenbai.Text = p.Name.ToString();
            tb_tenbai.Tag = p.Tag;
            List<ViTri> list = ViTriDAO.Instance.getVitriTheoMaBai((int)p.Tag);
            loadViewLocationCar(list);
            textBox_tenvitri.Text = "";

        }

        private void panel_Click_vitri(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            // identify which button was clicked and perform necessary actions
            int maibai = Int32.Parse(p.Name.ToString().Replace("panelvitri", ""));
            textBox_tenvitri.Tag = p.Tag;
            textBox_tenvitri.Text = "Vị trí " + maibai.ToString();

        }
        private void picture_Click_vitri(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            // identify which button was clicked and perform necessary actions
            int maibai = Int32.Parse(p.Name.ToString().Replace("picvitri", ""));
            textBox_tenvitri.Tag = p.Tag;
            textBox_tenvitri.Text = "Vị trí " + maibai.ToString();
        }
        private void label_Click_vitri(object sender, EventArgs e)
        {
            Label p = sender as Label;
            // identify which button was clicked and perform necessary actions
            int maibai = Int32.Parse(p.Name.ToString().Replace("labelvitri", ""));
            textBox_tenvitri.Tag = p.Tag;
            textBox_tenvitri.Text = "Vị trí " + maibai.ToString();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int maloaixe_ = maloaixe();
                int mabai = Int32.Parse(tb_tenbai.Tag.ToString());
                int mavitri = Int32.Parse(textBox_tenvitri.Tag.ToString());
                String sdt = textBox_sdtkh.Text.ToString();
                String ngaydat = dateTimePicker_ngaydat.Value.ToString("yyyy-MM-dd");
                String giodat = textBox_giodat.Text.ToString();

                if (dateTimePicker_ngaydat.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("ngày Đặt Hiện Không Khả Dụng! Vui Lòng Chọn Lại"); 
                    {
                        MessageBox.Show("Error!");
                        return;
                    }
                    return;
                }
                else if(dateTimePicker_ngaydat.Value.Date == DateTime.Today)
                {
                    Char value1 = 'h';
                    if (!giodat.Contains(value1))
                    {
                        MessageBox.Show("Lỗi Cú Pháp!");
                        return;
                    }
                    else
                    {


                    }
                    String[] items = giodat.Split("h");
                    try
                    {
                        int gio = Int32.Parse(items[0]);
                        int phut = Int32.Parse(items[1]);
                        TimeSpan currentTime = DateTime.Now.TimeOfDay;
                        int gioht = Int32.Parse(currentTime.Hours.ToString());
                        int phutht = Int32.Parse(currentTime.Minutes.ToString());

                        if(gio < gioht)
                        {
                            MessageBox.Show("Error! Check thông tin đặt!");
                            return;
                        }

                        if(gio == gioht)
                        {
                            if(phut < phutht)
                            {
                                MessageBox.Show("Error! Check thông tin đặt!");
                                return;
                            }
                        }

                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show("Lỗi Cú Pháp!");
                        return;
                    }
                }

                if (mabai == 0 || mavitri == 0 || sdt.Equals("") || giodat.Equals(""))
                {
                    MessageBox.Show("Error!");
                    return;
                }
                Char value = 'h';
                if (!giodat.Contains(value))
                {
                    MessageBox.Show("Lỗi Cú Pháp!");
                    return;
                }
                else
                {


                }

                int result = DatChoOnlineBUS.Instance.insertDatCHoOnline(sdt, mavitri, mabai, ngaydat, maloaixe_,giodat);
                MessageBox.Show("Đặt CHỗ Thành Công! Chờ Xác Nhận Của Nhân Viên Bãi Xe!");

            }
            catch(Exception ec)
            {
                MessageBox.Show("Error!");
                return;
            }
            

            


        }



        #endregion



        #region Methods

        private void load_donhangonline()
        {
            DataTable dt = new DataTable();
            dt = BUS.DatChoOnlineBUS.Instance.getAllDonHangOn(Khachhang.SDT);
            DataTable dtCloned = dt.Clone();
            dtCloned.Columns[6].DataType = typeof(String);
            foreach (DataRow row in dt.Rows)
            {
                dtCloned.ImportRow(row);
            }
            IDictionary<int, string> datchoonlinedic = new Dictionary<int, string>() { { -1, "bị hủy" }, { 0, "chờ xử lý" }, { 1, "đặt thành công" } };
            for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
            {
                dtCloned.Rows[rowIndex][6] = datchoonlinedic[Convert.ToInt32(dt.Rows[rowIndex][6])];
            }
            bs_datchoonline.DataSource = dtCloned;
            dataGridView_danhsachdatchoon.DataSource = bs_datchoonline;
        }

        private void loadhd_kh()
        {
            DataTable dt = new DataTable();
            dt = HoaDonBUS.Instance.getAllHD_KH(Khachhang.SDT);
            bs_hd_kh.DataSource = dt;
            dataGridView_listhd_kh.DataSource = bs_hd_kh;
        }

        private void loadInfoLichSuDatCho()
        {

        }

        public int maloaixe()
        {
            string selectedValue = comboBox_loaixe.Text.ToString();
            foreach (LoaiXe lx in ListLoaiXe)
            {
                if (lx.Tenloaixe.Equals(selectedValue))
                {
                    return lx.Maloai;
                }
            }
            return 0;
        }

        private void loadLoaiXe()
        {

            comboBox_loaixe.DataSource = ListLoaiXe;
            comboBox_loaixe.DisplayMember = "tenloaixe";
        }

        private void LoadInfo()
        {
            Listbaigiuxe = BaiGiuBUS.Instance.getallBaiGiuXe();
            ListLoaiXe = LoaiXeBUS.Instance.getAllLoaiXe();
            panel_chualistvitrixeMain.Controls.Clear();
            Khachhang = KhachHangBUS.Instance.checkAccount("111111111", "123");
            textBox_diem.Text = khachhang.DIEMTICHLUY.ToString();
            textBox_matkhau.Text = khachhang.PASS.ToString();
            textBox_sdt.Text = khachhang.SDT;
            textBox_ten.Text = khachhang.TENKH;
            textBox_sdtkh.Text = khachhang.SDT;
            textBox_tenkhon.Text = khachhang.TENKH;
        }
        private void loadViewParkingLot(List<BaiGiu> list)
        {
            panel_listchuabaixe.Controls.Clear();
            int soluongbai = list.Count();
            int checksoluongbai = 0;
            int check = 0;
            int y = 20;
            while (true)
            {
                if (checksoluongbai == soluongbai)
                {
                    break;
                }

                Panel panel = new Panel()
                {
                    Width = 170,
                    Height = 75
                };
                panel.BackColor = Color.CornflowerBlue;

                // ================================
                PictureBox picture = new PictureBox()
                {
                    Width = 80,
                    Height = 75
                };

                picture.Image = GUI.Properties.Resources.parking_car;
                //picture.Image = Image.FromFile("E:\\Documents\\OneDrive - student.tdtu.edu.vn\\Desktop\\CarParking\\CarParkingSystem_Winform\\CarParkingSystem\\GUI\\Resources\\spaces.png");
                picture.Dock = DockStyle.Left;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                panel.Controls.Add(picture);
                picture.Parent = panel;
                // ================================

                // ==============================
                Label label = new Label()
                {
                    Width = 80,
                    Height = 30
                };
                label.Text = list[checksoluongbai].Tenbai;
                label.Location = new Point(88,20);
                label.ForeColor = Color.Red;
                label.Font = new Font("Regular", 13);
                panel.Controls.Add(label);
                label.Parent = panel;
                //===============================

                panel.Click += new EventHandler(panel_Click_bai); 
                picture.Click += new EventHandler(picture_Click_bai);
                label.Click += new EventHandler(label_Click_bai);

                if (check == 0)
                {
                    panel.Location = new Point(25, y);
                    check++;
                }else if(check == 1)
                {
                    panel.Location = new Point(240, y);
                    check++;
                }
                else if(check == 2)
                {
                    panel.Location = new Point(450, y);
                    check++;
                }
                else
                {
                    check = 0;
                    y = y+ 100;
                    continue;
                }
                loadInfoParkingLot(panel, picture, label, list[checksoluongbai]);
                checksoluongbai++;
                panel_listchuabaixe.Controls.Add(panel);
                panel.Parent = panel_listchuabaixe;

            }

        }

        private void loadViewLocationCar(List<ViTri> list)
        {
            panel_chualistvitrixeMain.Controls.Clear();
            int soluongvitri = list.Count();
            int checksoluongvitri = 0;
            int check = 0;
            int y = 30;
            while (true)
            {
                if (checksoluongvitri == soluongvitri)
                {
                    break;
                }

                Panel panel = new Panel()
                {
                    Width = 113,
                    Height = 100
                };
                panel.BackColor = Color.CornflowerBlue;

                // ================================
                PictureBox picture = new PictureBox()
                {
                    Width = 113,
                    Height = 66
                };

                picture.Image = GUI.Properties.Resources.location_car;
                //picture.Image = Image.FromFile("E:\\Documents\\OneDrive - student.tdtu.edu.vn\\Desktop\\CarParking\\CarParkingSystem_Winform\\CarParkingSystem\\GUI\\Resources\\parking-car.png");
                picture.Dock = DockStyle.Top;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                panel.Controls.Add(picture);
                picture.Parent = panel;
                // ================================

                // ==============================
                Label label = new Label()
                {
                    Width = 80,
                    Height = 30
                };
                label.Text = "Vị trí "+list[checksoluongvitri].SOVITRI;
                label.Location = new Point(18, 70);
                label.ForeColor = Color.Black;
                label.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                panel.Controls.Add(label);
                label.Parent = panel;
                //===============================

                panel.Click += new EventHandler(panel_Click_vitri);
                picture.Click += new EventHandler(picture_Click_vitri);
                label.Click += new EventHandler(label_Click_vitri);

                if (check == 0)
                {
                    panel.Location = new Point(25, y);
                    check++;
                }
                else if (check == 1)
                {
                    panel.Location = new Point(186, y);
                    check++;
                }
                else if (check == 2)
                {
                    panel.Location = new Point(345, y);
                    check++;
                }else if (check == 3)
                {
                    panel.Location = new Point(504, y);
                    check++;
                }

                else
                {
                    check = 0;
                    y = y + 135;
                    continue;
                }
                loadInfoLocationCar(panel, picture, label, list[checksoluongvitri]);
                checksoluongvitri++;
                panel_chualistvitrixeMain.Controls.Add(panel);
                panel.Parent = panel_chualistvitrixeMain;

            }
        }

        private void loadInfoParkingLot(Panel panel, PictureBox pic, Label label, BaiGiu bai) 
        {
            panel.Name = bai.Tenbai.ToString();
            pic.Name = bai.Tenbai.ToString();
            label.Name =  bai.Tenbai.ToString();

            panel.Tag = bai.Mabai;
            pic.Tag = bai.Mabai;
            label.Tag = bai.Mabai;
        }

        private void lb_datchoonline_Click(object sender, EventArgs e)
        {
            panel_datchoonline.Visible = true;
            panel34_UserInfo.Visible = false;
            loadViewParkingLot(Listbaigiuxe);
        }



        private void label1_Click(object sender, EventArgs e)
        {
            panel_datchoonline.Visible = false;
            panel34_UserInfo.Visible = true;
            panelinfo.Visible = true;
            panel36_danhsachDatOnline.Visible = false;
            panel_mainLichSuGuiXe.Visible = false;


        }



        private void label34_Click(object sender, EventArgs e)
        {
            panelinfo.Visible = true;
            panel36_danhsachDatOnline.Visible = false;
            panel_mainLichSuGuiXe.Visible = false;
            LoadInfo();
        }



        private void label33_Click(object sender, EventArgs e)
        {
            panelinfo.Visible = false;
            panel36_danhsachDatOnline.Visible = false;
            panel_mainLichSuGuiXe.Visible = true;
            loadhd_kh();
        }


        private void label32_Click(object sender, EventArgs e)
        {
            panelinfo.Visible = false;
            panel_datchoonline.Visible = false;
            panel36_danhsachDatOnline.Visible = true;
            panel_mainLichSuGuiXe.Visible = false;
            panel_datchoonline.Visible = false;
            load_donhangonline();

        }

        private void pnl_datchoonline_Click(object sender, EventArgs e)
        {
            panel_datchoonline.Visible = true;
            panel34_UserInfo.Visible = false;
        }

  

        private void panel1_Click(object sender, EventArgs e)
        {
            panel_datchoonline.Visible = false;
            panel34_UserInfo.Visible = true;
            panelinfo.Visible = true;
            panel36_danhsachDatOnline.Visible = false;
            panel_mainLichSuGuiXe.Visible = false;
        }



        private void panel39_Click(object sender, EventArgs e)
        {
            panelinfo.Visible = false;
            panel36_danhsachDatOnline.Visible = false;
            panel_mainLichSuGuiXe.Visible = true;
            loadhd_kh();
        }

        private void panel38_Click(object sender, EventArgs e)
        {
            panelinfo.Visible = false;
            panel_datchoonline.Visible = false;
            panel36_danhsachDatOnline.Visible = true;
            panel_mainLichSuGuiXe.Visible = false;
            panel_datchoonline.Visible = false;
            load_donhangonline();
        }

        private void loadInfoLocationCar(Panel panel, PictureBox pic, Label label, ViTri vitri)
        {
            if(vitri.TINHTRANG == 1)
            {
                panel.BackColor = Color.Red;
                panel.Enabled = false;
                pic.Enabled = false;
                label.Enabled = false;
            }
            else if (vitri.TINHTRANG == 2)
            {
                panel.BackColor = Color.YellowGreen;
                panel.Enabled = false;
                pic.Enabled = false;
                label.Enabled = false;
            }

            panel.Name = "panelvitri" + vitri.SOVITRI.ToString();
            pic.Name = "picvitri" + vitri.SOVITRI.ToString();
            label.Name = "labelvitri" + vitri.SOVITRI.ToString();

            panel.Tag = vitri.ID_VITRI.ToString();
            pic.Tag = vitri.ID_VITRI.ToString();
            label.Tag = vitri.ID_VITRI.ToString();
        }





        #endregion


    }
}
