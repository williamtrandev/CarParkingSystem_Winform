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
        private int mabai;
        private String tenbai;
        private int succhua;
        private int deleted;

        public BaiGiu(DataRow row)
        {
            this.mabai = (int)row["MABAI"];
            this.tenbai = row["TENBAI"].ToString();
            this.succhua = (int)row["SUCCHUA"];
            this.deleted = (int)row["DELETED"];
        }

        public BaiGiu() { }

        public BaiGiu(int mabai, string tenbai, int succhua, int deleted)
        {
            this.mabai = mabai;
            this.tenbai = tenbai;
            this.succhua = succhua;
            this.deleted = deleted;

        }

        public int Mabai { get => mabai; set => mabai = value; }
        public string Tenbai { get => tenbai; set => tenbai = value; }
        public int Succhua { get => succhua; set => succhua = value; }
        public int Deleted { get => deleted; set => deleted = value; }
    }
}
