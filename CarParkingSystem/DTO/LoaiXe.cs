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
        private int maloai;
        private String tenloaixe;
        private double phigiu;
        private int deleted;

        public LoaiXe(DataRow row)
        {

            this.phigiu = (Double)row["PHIGIU"];
            this.tenloaixe = row["TENLOAI"].ToString();
            this.maloai = (int)row["MALOAI"];
            this.Deleted = (int)row["DELETED"];
        }

        public LoaiXe(int maloai, string tenloaixe, double phigiu)
        {
            this.maloai = maloai;
            this.tenloaixe = tenloaixe;
            this.phigiu = phigiu;
        }

        public LoaiXe()
        {
        }

        public int Maloai { get => maloai; set => maloai = value; }
        public string Tenloaixe { get => tenloaixe; set => tenloaixe = value; }
        public double Phigiu { get => phigiu; set => phigiu = value; }
        public int Deleted { get => deleted; set => deleted = value; }
    }
}
