using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SupportBaiGiu
    {
        public int Mabai { get; set; }
        public string Tenbai { get; set; }

        public override string ToString()
        {
            return Tenbai;
        }
    }
}
