using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private String sdt;
        private String ten_kh;
        private String matkhau;
        private int diem_tichluy;

        public KhachHang(string sdt, string ten_kh, string matkhau, int diem_tichluy)
        {
            this.sdt = sdt;
            this.ten_kh = ten_kh;
            this.matkhau = matkhau;
            this.diem_tichluy = diem_tichluy;

        }

        public KhachHang(DataRow row)
        {
            this.SDT = row["SODT"].ToString();
            this.TENKH = row["TENKH"].ToString();
            this.PASS = row["PASS"].ToString();
            this.DIEMTICHLUY = (int) row["DIEMTICHLUY"];
        }

        public KhachHang()
        {
        }

        public string SDT { get => sdt; set => sdt = value; }
        public string TENKH { get => ten_kh; set => ten_kh = value; }
        public string PASS { get => matkhau; set => matkhau = value; }
        public int DIEMTICHLUY { get => diem_tichluy; set => diem_tichluy = value; }
    }
}
