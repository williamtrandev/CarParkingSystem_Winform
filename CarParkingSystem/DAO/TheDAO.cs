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
            //return (The) DataProvider.Instance.ExecuteScalar(query, new object[] { @id });
        }
    }
}
