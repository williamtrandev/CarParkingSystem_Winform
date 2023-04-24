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
    public partial class FAddEditCarType : Form
    {
        private FMainManager fmm;
        private bool isAdd;
        public FAddEditCarType(FMainManager fmm, bool isAdd=true)
        {
            InitializeComponent();
            this.fmm = fmm;
            this.isAdd = isAdd;
        }

        private void FAddEditCarType_Load(object sender, EventArgs e)
        {
            pb_add.Parent = pb_background;
            pb_update.Parent = pb_background;
            pb_add.BackColor = Color.Transparent;
            pb_update.BackColor = Color.Transparent;
            if (isAdd)
            {
                this.Text = "Thêm loại xe mới";
                pb_add.Visible = true;
                pb_update.Visible = false;
            } else
            {
                this.Text = "Thay đổi thông tin loại xe";
                pb_add.Visible = false;
                pb_update.Visible = true;
                DataRowView rowSelect = (DataRowView)fmm.bs_loaixe.Current;   // Get the row that is selected in Form Main
                string mabai = rowSelect["MALOAI"].ToString();
                tb_tenlx_add.Text = rowSelect["TENLOAI"].ToString();
                tb_phigiu_add.Text = rowSelect["PHIGIU"].ToString();
            }
        }

        private void pb_add_Click(object sender, EventArgs e)
        {
            LoaiXe lx = new LoaiXe();
            lx.TENLOAI = tb_tenlx_add.Text.ToString();
            lx.PHIGIU = float.Parse(tb_phigiu_add.Text);
            bool checkInsert = BUS.LoaiXeBUS.Instance.insertLoaiXe(lx);
            if (checkInsert)
            {
                MessageBox.Show("Thêm loại xe mới thành công");
                fmm.loadBaiGiu();
            }
            else
            {
                MessageBox.Show("Thêm loại xe mới thất bại");
            }
        }

        private void pb_update_Click(object sender, EventArgs e)
        {
            DataRowView rowSelect = (DataRowView)fmm.bs_loaixe.Current;   // Get the row that is selected in Form Main
            LoaiXe lx = new LoaiXe();
            lx.MALOAI = rowSelect["MALOAI"].ToString();
            lx.TENLOAI = tb_tenlx_add.Text.ToString();
            lx.PHIGIU = Convert.ToInt32(tb_phigiu_add.Text);
            bool checkUpdate = BUS.LoaiXeBUS.Instance.updateLoaiXe(lx);
            if (checkUpdate)
            {
                MessageBox.Show("Thay đổi thông tin loại xe thành công");
                fmm.loadLoaiXe();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin loại xe thất bại");
            }
        }
        
    }
}
