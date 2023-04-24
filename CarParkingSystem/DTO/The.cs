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
        private int sothe, id_vitri, trangthai;
        private string tenthe, biensoxe, giovao;

        public The(int sothe, string tenthe, int id_vitri, string biensoxe, int trangthai, string giovao)
        {
            this.sothe = sothe;
            this.tenthe = tenthe;
            this.id_vitri= id_vitri;
            this.biensoxe  = biensoxe;
            this.trangthai = trangthai;
            this.giovao= giovao;
        }

        public The()
        {
        }
        public The(DataRow row)
        {
            this.sothe = (int) row["sothe"];
            this.tenthe = row["tenthe"].ToString();
            this.id_vitri = (int) row["id_vitri"];
            this.biensoxe = row["biensoxe"].ToString();
            this.trangthai = (int) row["trangthai"];
            this.giovao = row["giovao"].ToString();
        }
        public int SOTHE { get => sothe; set => sothe = value; }
        public string TENTHE { get => tenthe; set => tenthe = value; }
        public int ID_VITRI { get => id_vitri; set => id_vitri = value; }
        public string BIENSOXE { get => biensoxe; set => biensoxe = value; }
        public int TRANGTHAI { get => trangthai; set => trangthai = value; }
        public string GIOVAO { get => giovao; set => giovao = value; }
    }
}
