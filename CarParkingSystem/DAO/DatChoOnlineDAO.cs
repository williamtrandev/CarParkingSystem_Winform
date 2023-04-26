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
            string query = "UPDATE datchoonline set tinhtrang = 2 where madon = @madon";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { madon }) > 0;
        }
        public bool deleteDonDatCho(int madon)
        {
            string query = "UPDATE datchoonline set tinhtrang = -1 where madon = @madon";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { madon }) > 0;
        }
        public int deleteDon(int madon, String sdt)
        {
            String query = string.Format("delete from datchoonline where madon = @madon and sdtkhachhang = @sdt");
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { madon, sdt });
        }




        public int inserDatChoOnline(String sdtkhachhang, int ID_VITRI, int mabai, String ngaydat, int loaixe, String giodat)
        {
            String query = "insert_datChoOnline @sdtkhachhang , @mavitri , @mabai , @ngaydat , @loaixe , @giodat";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sdtkhachhang, ID_VITRI, mabai, ngaydat, loaixe, giodat });
            return data;
        }

        public DataTable getAllDonHangOn(String sdtkh)
        {
            String query = "showdatchoonline_proc @sdtkh";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { sdtkh });
        }
        public DatChoOnline getDetail(String sdtkh, int mabai)
        {
            String query = "SELECT * FROM datchoonline where sdtkhachhang = @sdtkh and mabai = @mabai";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { sdtkh, mabai });
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            return new DatChoOnline(dt.Rows[0]);
        }
        public bool deleteDon(int madon)
        {
            string query = "delete from datchoonline where madon = @madon";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {madon}) > 0;
        }
    }
}
