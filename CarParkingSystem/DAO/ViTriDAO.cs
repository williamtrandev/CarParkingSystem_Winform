using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ViTriDAO
    {
        private static ViTriDAO instance;

        public static ViTriDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ViTriDAO();
                }
                return instance;
            }

        }

        private ViTriDAO()
        {
        }
        public List<ViTri> getAllXe(int mabai)
        {
            List<ViTri> vt = new List<ViTri>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.getAllXe( @mabai )", new object[] {mabai});
            foreach (DataRow dr in dt.Rows)
            {
                vt.Add(new ViTri(dr));
            }
            return vt;
        }
        public bool changeStateVitriDatCho(int id_vitri)
        {
            string query = "UPDATE Vitri SET tinhtrang = 1 where ID_VITRI = @id_vitri";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_vitri }) > 0;
        }
        public List<ViTri> getVitriTheoMaBai(int mabai)
        {
            String query = "select * from ViTri where MABAIXE = @mabai and tinhtrang != 3";
            List<ViTri> listvitri = new List<ViTri>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { mabai });
            foreach (DataRow item in data.Rows)
            {
                ViTri hh = new ViTri(item);
                listvitri.Add(hh);
            }

            return listvitri;
        }
    }
}
