using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class FChonBai : Form
    {
        NhanVien nv;
        public FChonBai(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
            DataTable dt = BUS.BaiGiuBUS.Instance.getAllBaiGiu();
            List<SupportBaiGiu> items = new List<SupportBaiGiu>();
            foreach (DataRow dr in dt.Rows)
            {
                items.Add(new SupportBaiGiu { Mabai = (int)dr["MABAI"], Tenbai = dr["TENBAI"].ToString() });
            }
            cb_chonbai.DataSource = items;
            cb_chonbai.DisplayMember = "tenbai";
            cb_chonbai.SelectedIndex = -1;
        }
        
        private void btn_chonbai_Click(object sender, EventArgs e)
        {
            if(cb_chonbai.SelectedIndex != -1)
            {
                SupportBaiGiu sp = (SupportBaiGiu)cb_chonbai.SelectedItem;
                FMainStaff fstaff = new FMainStaff(sp.Mabai);
                MessageBox.Show(sp.Mabai.ToString());
                fstaff.Nhanvien = this.nv;
                this.Hide();
                fstaff.ShowDialog();
                this.Show();
                this.WindowState = FormWindowState.Minimized;
            } else
            {
                MessageBox.Show("Vui lòng chọn bãi");
            }
        }
    }
}
