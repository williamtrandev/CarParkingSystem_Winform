using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO
{
    public class KhachHangDAO
    {

        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhachHangDAO();
                }
                return instance;
            }

        }

        private KhachHangDAO()
        {
        }
        public KhachHang checkAccount(String phone, String pass)    // Check whether exist an account of user to login
        {
            String query = "USP_login_to_system @phone , @pass";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { phone, pass });

            if (data.Rows.Count == 0)
            {
                return null;
            }

            return new KhachHang(data.Rows[0]); // return an object KhachHang if exists in database 
        }
        public bool checkExistAccount(String phone) // Check account by phone 
        {
            String query = "SELECT * FROM KhachHang WHERE SODT = @phone";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { phone });

            if (data.Rows.Count == 0)
            {
                return false;
            }

            return true; // return true if exists an account in database 
        }
        public bool insertAccountKhachHang(String sdt, String name, String pass, int diemtl)
        {
            String query = string.Format("INSERT INTO KhachHang VALUES('{0}', N'{1}', '{2}', 0)", sdt, name, pass, diemtl);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public DataTable getAllCustomer()
        {
            String query = "SELECT SODT, TENKH, PASS, DIEMTICHLUY FROM KhachHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool deleteAccount(String sdt)
        {
            String query = string.Format("DELETE FROM KhachHang WHERE SODT = @sdt");
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {sdt}) > 0;
        }
        public bool updateAccountKhachHang(String sdtcu, String sdt, String name, String pass, int diemtl)
        {
            String query = string.Format("UPDATE KhachHang SET SODT = @sdt , TENKH = @name , PASS = @pass , DIEMTICHLUY = @diemtl WHERE SODT = @sdtcu");
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { sdt, name, pass, diemtl, sdtcu }) > 0;
        }
        public int updateInFoKH(String sdtkhachhang, String tenKH, String pass)
        {
            String query = "updatekh @sdt , @tenkh , @pass";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sdtkhachhang, tenKH, pass });
            return data;
        }
    }
}
