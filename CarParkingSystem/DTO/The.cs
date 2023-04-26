using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class The
    {
        private int sothe, id_vitri, trangthai, maloaixe;
        private string tenthe, biensoxe, giovao, sdtkh;

        public The(int sothe, string tenthe, int id_vitri, string biensoxe, int trangthai, string giovao, string sdtkh, int maloaixe)
        {
            this.sothe = sothe;
            this.tenthe = tenthe;
            this.id_vitri= id_vitri;
            this.biensoxe  = biensoxe;
            this.trangthai = trangthai;
            this.giovao= giovao;
            this.sdtkh= sdtkh;
            this.maloaixe = maloaixe;
        }

        public The()
        {
        }
        public The(DataRow row)
        {
            this.sothe = (int) row["sothe"];
            this.tenthe = row["tenthe"].ToString();
            this.id_vitri =  Int32.Parse(row["id_vitri"].ToString());
            this.biensoxe = row["biensoxe"].ToString();
            this.trangthai = (int) row["trangthai"];
            this.giovao = row["giovao"].ToString();
            this.sdtkh = row["sdtkh"].ToString();
            this.maloaixe = (int)row["maloaixe"];
        }
        public int SOTHE { get => sothe; set => sothe = value; }
        public string TENTHE { get => tenthe; set => tenthe = value; }
        public int ID_VITRI { get => id_vitri; set => id_vitri = value; }
        public string BIENSOXE { get => biensoxe; set => biensoxe = value; }
        public int TRANGTHAI { get => trangthai; set => trangthai = value; }
        public string GIOVAO { get => giovao; set => giovao = value; }
        public string SDTKH { get => sdtkh; set => sdtkh = value; }
        public int MALOAIXE { get => maloaixe; set => maloaixe = value; }
    }
}
