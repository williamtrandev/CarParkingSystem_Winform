using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;
        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienBUS();
                }
                return instance;
            }

        }

        public NhanVienBUS()
        {

        }
        public NhanVien checkAccount(String phone, String pass)
        {
            return DAO.NhanVienDAO.Instance.checkAccount(phone, pass);
        }
        public bool checkExistAccount(String phone)
        {
            return DAO.NhanVienDAO.Instance.checkExistAccount(phone);
        }
        public bool insertAccountNhanVien(String sdt, String name, String diachi, String pass, int loainv)
        {
            return DAO.NhanVienDAO.Instance.insertAccountNhanVien(sdt, name, diachi, pass, loainv);
        }
        public DataTable getAllStaff()
        {
            return DAO.NhanVienDAO.Instance.getAllStaff();
        }
        public bool deleteAccountNhanVien(String sdt)
        {
            return DAO.NhanVienDAO.Instance.deleteAccountNhanVien(sdt);
        }
        public bool updateAccountNhanVien(String sdtcu, String sdt, String name, String diachi, String pass, int loainv)
        {
            return DAO.NhanVienDAO.Instance.updateAccountNhanVien(sdtcu, sdt, name, diachi, pass, loainv);
        }
    }
}
