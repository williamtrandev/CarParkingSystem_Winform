using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private String mahd;
        private String tennv;
        private String tenloai;
        private String tenbai;
        private int sovitri;
        private String giora;
        private int tongtien;

        public HoaDon(DataRow row)
        {
            this.mahd = row["MAHD"].ToString();
            this.tennv = row["TENNV"].ToString();
            this.tenloai = row["TENLOAI"].ToString();
            this.tenbai = row["TENBAI"].ToString();
            this.sovitri = (int)row["SOVITRI"];
            this.giora = row["GIORA"].ToString();
            //this.tongtien = Int32.Parse(row["TONGTIEN"].ToString());
            this.tongtien = (int)row["TONGTIEN"];

        }


        public string Mahd { get => mahd; set => mahd = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public string Tenbai { get => tenbai; set => tenbai = value; }
        public int Sovitri { get => sovitri; set => sovitri = value; }
        public string Giora { get => giora; set => giora = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }



        public HoaDon()
        {

        }


    }
}