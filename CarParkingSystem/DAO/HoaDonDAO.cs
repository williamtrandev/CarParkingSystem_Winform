using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonDAO();
                }
                return instance;
            }

        }

        private HoaDonDAO()
        {
        }
        
        public bool insertHoaDon(string sdtkh, string nvthu, int maloaixe, int id_vitri, string giovao, string giora)
        {
            String query = "exec dbo.insertHoaDon @sdtkh , @nvthu , @maloaixe , @id_vitri , @giovao , @giora";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { sdtkh, nvthu, maloaixe, id_vitri, giovao, giora }) > 0;
        }

        public DataTable getAllHD_KH(String sdtkh)
        {
            String query = "lichsudatchokh @sdtkh";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { sdtkh });
        }
        public DataTable getAllHoaDon(String start, String end) 
        {
            string query = "exec getAllHoaDon @start , @end";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { start, end });
        }
    }
}
