using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SupportLoaiXe
    {
        public int Maloai { get; set; }
        public double Phigiu { get; set; }
        public string Tenloai { get; set; }
        public int Deleted { get; set; }
        public override string ToString()
        {
            return Tenloai;
        }
    }
}
