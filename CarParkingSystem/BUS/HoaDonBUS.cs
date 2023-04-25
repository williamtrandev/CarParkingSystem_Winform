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
    public class HoaDonBUS
    {
        private static HoaDonBUS instance;
        public static HoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonBUS();
                }
                return instance;
            }

        }

        public HoaDonBUS()
        {

        }
        public bool insertHoaDon(string sdtkh, string nvthu, int maloaixe, int id_vitri, string giovao, string giora)
        {
            return DAO.HoaDonDAO.Instance.insertHoaDon(sdtkh, nvthu, maloaixe, id_vitri, giovao, giora);
        }


        public DataTable getAllHD_KH(String sdtkh)
        {
            return HoaDonDAO.Instance.getAllHD_KH(sdtkh);
        }
        public DataTable getAllHoaDon(String start, String end)
        {
            return HoaDonDAO.Instance.getAllHoaDon(start, end);
        }
    }
}
