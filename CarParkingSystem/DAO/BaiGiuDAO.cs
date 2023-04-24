using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BaiGiuDAO
    {
        private static BaiGiuDAO instance;

        public static BaiGiuDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BaiGiuDAO();
                }
                return instance;
            }

        }

        private BaiGiuDAO()
        {
        }
        public DataTable getAllBaiGiu()
        {
            String query = "SELECT MABAI, TENBAI, SUCCHUA FROM BaiGiu WHERE DELETED=0";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool insertBaiGiu(BaiGiu bg)
        {
            String query = "INSERT INTO BaiGiu (TENBAI, SUCCHUA) VALUES( @TENBAI , @SUCCHUA )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { bg.TENBAI, bg.SUCCHUA }) > 0;
        }
        public bool updateBaiGiu(BaiGiu bg)
        {
            String query = "UPDATE BaiGiu SET TENBAI = @TENBAI , SUCCHUA = @SUCCHUA WHERE MABAI = @MABAI";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { bg.TENBAI, bg.SUCCHUA, bg.MABAI }) > 0;
        }
        public bool removeBaiGiu(String mabai)
        {
            String query = "UPDATE BaiGiu SET DELETED=1 WHERE MABAI = @MABAI";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mabai }) > 0;
        }
    }
}
