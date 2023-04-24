using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DatChoOnlineDAO
    {
        private static DatChoOnlineDAO instance;

        public static DatChoOnlineDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatChoOnlineDAO();
                }
                return instance;
            }

        }

        private DatChoOnlineDAO()
        {
        }
        public DataTable getAllDon(int mabai)
        {
            string query = "SELECT madon, sdtkhachhang, sovitri, ngaydat, tenloai, giodat, id_vitri FROM dbo.getAllDon( @mabai )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { mabai });

        } 
        public bool changeStateDon(int madon)
        {
            string query = "UPDATE datchoonline set tinhtrang = 1 where madon = @madon";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { madon }) > 0;
        }
        public bool deleteDonDatCho(int madon)
        {
            string query = "UPDATE datchoonline set tinhtrang = -1 where madon = @madon";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { madon }) > 0;
        }
    }
}
