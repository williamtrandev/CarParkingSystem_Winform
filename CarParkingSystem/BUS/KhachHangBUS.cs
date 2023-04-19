using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhachHangBUS();
                }
                return instance;
            }

        }

        public KhachHangBUS()
        {

        }
        public KhachHang checkAccount(String phone, String pass)
        {
            return DAO.KhachHangDAO.Instance.checkAccount(phone, pass);
        }
        public bool checkExistAccount(String phone)
        {
            return DAO.KhachHangDAO.Instance.checkExistAccount(phone);
        }
        public bool insertAccountKhachHang(String sdt, String name, String pass, int diemtl)
        {
            return DAO.KhachHangDAO.Instance.insertAccountKhachHang(sdt, name, pass, diemtl);
        }
        public DataTable getAllCustomer()
        {
            return DAO.KhachHangDAO.Instance.getAllCustomer();
        }
        public bool deleteAccount(String sdt)
        {
            return DAO.KhachHangDAO.Instance.deleteAccount(sdt);
        }
        public bool updateAccountKhachHang(String sdtcu, String sdt, String name, String pass, int diemtl)
        {
            return DAO.KhachHangDAO.Instance.updateAccountKhachHang(sdtcu, sdt, name, pass, diemtl);
        }
    }
    
}
