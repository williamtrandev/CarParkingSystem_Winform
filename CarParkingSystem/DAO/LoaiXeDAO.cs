using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiXeDAO
    {
        private static LoaiXeDAO instance;

        public static LoaiXeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiXeDAO();
                }
                return instance;
            }

        }

        private LoaiXeDAO()
        {
        }
        public DataTable getAllLoaiXe()
        {
            String query = "SELECT MALOAI, TENLOAI, PHIGIU FROM LoaiXe WHERE DELETED=0";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool insertLoaiXe(LoaiXe lx)
        {
            String query = "INSERT INTO LoaiXe (TENLOAI, PHIGIU) VALUES( @TENLOAI , @PHIGIU )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { lx.TENLOAI, lx.PHIGIU }) > 0;
        }
        public bool updateLoaiXe(LoaiXe lx)
        {
            String query = "UPDATE LoaiXe SET TENLOAI = @TENLOAI , PHIGIU = @PHIGIU WHERE MALOAI = @MALOAI";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { lx.TENLOAI, lx.PHIGIU, lx.MALOAI }) > 0;
        }
        public bool removeLoaiXe(String maloai)
        {
            String query = "UPDATE LoaiXe SET DELETED = 1 WHERE MALOAI = @MALOAI";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maloai }) > 0;
        }
    }
}
