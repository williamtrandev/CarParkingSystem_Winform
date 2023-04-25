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
        public bool updateThe(int sothe, string biensoxe, string giovao, int trangthai)
        {
            String query = "UPDATE The SET biensoxe = @biensoxe , giovao = @giovao , trangthai = @trangthai WHERE sothe = @sothe";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { biensoxe, giovao, trangthai, sothe}) > 0;
        }
    }
}
