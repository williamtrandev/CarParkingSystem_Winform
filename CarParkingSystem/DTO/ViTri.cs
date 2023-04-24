using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ViTri
    {
        private int id_vitri, sovitri, mabaixe, tinhtrang;

        public ViTri(int id_vitri, int sovitri, int mabaixe, int tinhtrang)
        {
            this.id_vitri = id_vitri;
            this.sovitri = sovitri;
            this.mabaixe = mabaixe;
            this.tinhtrang = tinhtrang;
        }

        public ViTri()
        {
        }
        public ViTri(DataRow row)
        {
            this.id_vitri = (int) row["ID_VITRI"];
            this.sovitri = (int) row["SOVITRI"];
            this.mabaixe = (int) row["MABAIXE"];
            this.tinhtrang = (int) row["TINHTRANG"];
        }
        public int ID_VITRI { get => id_vitri; set => id_vitri = value; }
        public int SOVITRI { get => sovitri; set => sovitri = value; }
        public int MABAIXE { get => mabaixe; set => mabaixe = value; }
        public int TINHTRANG { get => tinhtrang; set => tinhtrang = value; }
    }
}
