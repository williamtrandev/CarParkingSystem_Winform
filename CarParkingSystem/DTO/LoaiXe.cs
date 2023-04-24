using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiXe
    {
        private String maloai;
        private String tenloai;
        private float phigiu;

        public LoaiXe(string maloai, string tenloai, float phigiu)
        {
            this.maloai = maloai;
            this.tenloai = tenloai;
            this.phigiu = phigiu;
        }

        public LoaiXe(DataRow row)
        {
            this.MALOAI = row["MALOAI"].ToString();
            this.TENLOAI = row["TENLOAI"].ToString();
            this.PHIGIU = (float)row["PHIGIU"];
        }

        public LoaiXe()
        {
        }

        public string MALOAI { get => maloai; set => maloai = value; }
        public string TENLOAI { get => tenloai; set => tenloai = value; }
        public float PHIGIU { get => phigiu; set => phigiu = value; }
    }
}
