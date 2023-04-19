using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienDAO();
                }
                return instance;
            }

        }

        private NhanVienDAO()
        {   
        }
        public NhanVien checkAccount(String phone, String pass)    // Check whether exist an account of user to login
        {
            String query = "USP_login_to_system @phone , @pass";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { phone, pass });

            if (data.Rows.Count == 0)
            {
                return null;
            }

            return new NhanVien(data.Rows[0]); // return an object NhanVien if exists in database 
        }
        public bool checkExistAccount(String phone) // Check account by phone 
        {
            String query = "SELECT * FROM NhanVien WHERE SODT = @phone";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { phone });

            if (data.Rows.Count == 0)
            {
                return false;
            }

            return true; // return true if exists an account in database 
        }
        public bool insertAccountNhanVien(String sdt, String name, String diachi, String pass, int loainv)
        {
            String query = string.Format("INSERT INTO NhanVien VALUES('{0}', N'{1}', N'{2}', '{3}', '{4}')", sdt, name, diachi, pass, loainv);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public DataTable getAllStaff()
        {
            String query = "SELECT * FROM NhanVien";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool deleteAccountNhanVien(String sdt)
        {
            String query = string.Format("DELETE FROM NhanVien WHERE SODT = @sdt");
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { sdt }) > 0;
        }
        public bool updateAccountNhanVien(String sdtcu, String sdt, String name, String diachi, String pass, int loainv)
        {
            String query = string.Format("UPDATE NhanVien SET SODT = @sdt , TENNV = @name , DIACHI = @diachi , PASS = @pass , LOAINV = @loainv WHERE SODT = @sdtcu");
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { sdt, name, diachi, pass, loainv, sdtcu }) > 0;
        }
    }
}
