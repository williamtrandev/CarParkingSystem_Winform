using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private String sdt;
        private String ten_nv;
        private String diachi;
        private String matkhau;
        private int loai_nv;

        public NhanVien(string sdt, string ten_nv, string diachi, string matkhau, int loai_nv)
        {
            this.sdt = sdt;
            this.ten_nv = ten_nv;
            this.matkhau = matkhau;
            this.diachi = diachi;
            this.loai_nv = loai_nv;

        }

        public NhanVien(DataRow row)
        {
            this.SDT = row["SODT"].ToString();
            this.TENNV = row["TENNV"].ToString();
            this.diachi = row["DIACHI"].ToString();
            this.PASS = row["PASS"].ToString();
            this.LOAINV = (int)row["LOAINV"];
        }

        public NhanVien()
        {
        }

        public string SDT { get => sdt; set => sdt = value; }
        public string TENNV { get => ten_nv; set => ten_nv = value; }
        public string DIACHI { get => diachi; set => diachi = value; }
        public string PASS { get => matkhau; set => matkhau = value; }
        public int LOAINV { get => loai_nv; set => loai_nv = value; }
    }
}
