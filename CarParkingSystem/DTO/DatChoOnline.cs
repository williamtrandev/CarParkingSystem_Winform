using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatChoOnline
    {
        private int madon;
        private String sdtkhachhang;
        private int id_vitri;
        private int mabai;
        private String ngaydat;
        private int loaixe;
        private String giodat;
        private int tinhtrang;
        public DatChoOnline(DataRow row)
        {
            this.sdtkhachhang = row["sdtkhachhang"].ToString();
            this.madon = (int)row["madon"];
            this.id_vitri = (int)row["id_vitri"];
            this.mabai = (int)row["mabai"];
            this.loaixe = (int)row["loaixe"];
            this.giodat = row["giodat"].ToString();
            this.tinhtrang = (int)row["tinhtrang"];
            this.ngaydat = (row["ngaydat"].ToString());
        }

        public DatChoOnline()
        {

        }

        public DatChoOnline(int madon, string sdtkhachhang, int mavitri, int mabai, String ngaydat, int loaixe, String giodat, int tinhtrang)
        {
            this.madon = madon;
            this.sdtkhachhang = sdtkhachhang;
            this.id_vitri = mavitri;
            this.mabai = mabai;
            this.ngaydat = ngaydat;
            this.loaixe = loaixe;
            this.giodat = giodat;
            this.tinhtrang = tinhtrang;
        }

        public int Madon { get => madon; set => madon = value; }
        public string Sdtkhachhang { get => sdtkhachhang; set => sdtkhachhang = value; }
        public int Id_vitri { get => id_vitri; set => id_vitri = value; }
        public int Mabai { get => mabai; set => mabai = value; }
        public String Ngaydat { get => ngaydat; set => ngaydat = value; }
        public int Loaixe { get => loaixe; set => loaixe = value; }
        public String Giodat { get => giodat; set => giodat = value; }
        public int Tinhtrang { get => tinhtrang; set => tinhtrang = value; }

    }
}