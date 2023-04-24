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
    public partial class FAddEditParking : Form
    {
        private FMainManager fmm;
        private bool isAdd;
        public FAddEditParking(FMainManager fmm, bool isAdd = true)
        {
            InitializeComponent();
            this.fmm = fmm;
            this.isAdd = isAdd;
        }

        private void FAddEditParking_Load(object sender, EventArgs e)
        {
            pb_add_parking.Parent = pb_background;
            pb_update_parking.Parent = pb_background;
            pb_add_parking.BackColor = Color.Transparent;
            pb_update_parking.BackColor = Color.Transparent;
            if(!isAdd)
            {
                this.Text = "Thay đổi thông tin bãi xe";
                DataRowView rowSelect = (DataRowView)fmm.bs_baigiu.Current;   // Get the row that is selected in Form Main
                string mabai = rowSelect["MABAI"].ToString();
                tb_tenbx_add.Text = rowSelect["TENBAI"].ToString();
                tb_succhua_add.Text = rowSelect["SUCCHUA"].ToString();
                pb_update_parking.Visible = true;
                pb_add_parking.Visible = false;
            } else
            {
                this.Text = "Thêm bãi xe mới";
                pb_update_parking.Visible = false;
                pb_add_parking.Visible = true;
            }
        }

        private void pb_update_parking_Click(object sender, EventArgs e)
        {
            DataRowView rowSelect = (DataRowView)fmm.bs_baigiu.Current;   // Get the row that is selected in Form Main
            BaiGiu bg = new BaiGiu();
            bg.MABAI = rowSelect["MABAI"].ToString();
            bg.TENBAI = tb_tenbx_add.Text.ToString();
            bg.SUCCHUA = Convert.ToInt32(tb_succhua_add.Text);
            bool checkUpdate = BUS.BaiGiuBUS.Instance.updateBaiGiu(bg);
            if (checkUpdate)
            {
                MessageBox.Show("Thay đổi thông tin bãi xe thành công");
                fmm.loadBaiGiu();
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin bãi xe thất bại");
            }
        }

        private void pb_add_parking_Click(object sender, EventArgs e)
        {
            BaiGiu bg = new BaiGiu();
            bg.TENBAI = tb_tenbx_add.Text.ToString();
            bg.SUCCHUA = Convert.ToInt32(tb_succhua_add.Text);
            bool checkInsert = BUS.BaiGiuBUS.Instance.insertBaiGiu(bg);
            if (checkInsert)
            {
                MessageBox.Show("Thêm bãi xe mới thành công");
                fmm.loadBaiGiu();
            } else
            {
                MessageBox.Show("Thêm bãi xe mới thất bại");
            }
        }
    }
}
