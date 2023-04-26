using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheDAO
    {
        private static TheDAO instance;

        public static TheDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TheDAO();
                }
                return instance;
            }

        }

        private TheDAO()
        {
        }

        public DataTable getAllTheVao__(int mabai)
        {
            string query = "select * from the where trangthai = 0";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getAllTheVao(int mabai)
        {
            string query = "SELECT t.* FROM The t JOIN Vitri vt ON t.id_vitri = vt.id_vitri JOIN BaiGiu bg ON vt.mabaixe = bg.mabai WHERE TRANGTHAI=0 AND bg.MABAI = @mabai";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { mabai });
        }
        public DataTable getAllTheRa(int mabai)
        {
            string query = "SELECT t.* FROM The t JOIN Vitri vt ON t.id_vitri = vt.id_vitri JOIN BaiGiu bg ON vt.mabaixe = bg.mabai WHERE TRANGTHAI=1 AND bg.MABAI = @mabai";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { mabai });
        }
        public The getDetail(int id)
        {
            string query = "SELECT * FROM The WHERE SOTHE = @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                return new The(row);
            }

            return null; // Nếu không tìm thấy thẻ thì trả về null
        }
        public bool updateThe(int sothe, string biensoxe, string giovao, int trangthai, int maloaixe)
        {
            String query = "UPDATE The SET biensoxe = @biensoxe , giovao = @giovao , trangthai = @trangthai , maloaixe = @maloaixe WHERE sothe = @sothe";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { biensoxe, giovao, trangthai, maloaixe, sothe }) > 0;
        }

        public bool updateThe_vitri(int vitri, int sothe)
        {
            String query = "update the set ID_VITRI = @vitri where SOTHE = @sothe";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { vitri , sothe }) > 0;
        }

        public void update(int vitri, int sothe)
        {
            String query = "update the set ID_VITRI =null , BIENSOXE = '', TRANGTHAI = 0 , GIOVAO = NULL, SDTKH = null where SOTHE = @sothe";
            bool check1 =  DataProvider.Instance.ExecuteNonQuery(query, new object[] {  sothe }) > 0;
            String query1 = "update vitri set TINHTRANG= 0 where ID_VITRI = @id_vitri";
            bool check11 = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { vitri }) > 0;
        }


        public List<The> getallthelist()
        {
            string query = "select * from the where trangthai = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<The> listban = new List<The>();


            foreach (DataRow item in data.Rows)
            {
                The hh = new The(item);
                listban.Add(hh);
            }

            return listban;
        }

    }
}
