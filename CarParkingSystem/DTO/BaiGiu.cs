using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaiGiu
    {
        private String mabai;
        private String tenbai;
        private int succhua;

        public BaiGiu(string mabai, string tenbai, int succhua)
        {
            this.mabai = mabai;
            this.tenbai = tenbai;
            this.succhua = succhua;
        }

        public BaiGiu(DataRow row)
        {
            this.MABAI = row["MABAI"].ToString();
            this.TENBAI = row["TENBAI"].ToString();
            this.SUCCHUA = (int)row["SUCCHUA"];
        }

        public BaiGiu()
        {
        }

        public string MABAI { get => mabai; set => mabai = value; }
        public string TENBAI { get => tenbai; set => tenbai = value; }
        public int SUCCHUA { get => succhua; set => succhua = value; }
    }
}
