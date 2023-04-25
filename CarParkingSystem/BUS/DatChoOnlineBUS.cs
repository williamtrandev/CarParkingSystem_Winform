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
    public class DatChoOnlineBUS
    {
        private static DatChoOnlineBUS instance;
        public static DatChoOnlineBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatChoOnlineBUS();
                }
                return instance;
            }

        }

        public DatChoOnlineBUS()
        {

        }
        public DataTable getAllDon(int mabai)
        {
            return DAO.DatChoOnlineDAO.Instance.getAllDon(mabai);
        }
        public bool changeStateDon(int madon)
        {
            return DAO.DatChoOnlineDAO.Instance.changeStateDon(madon);
        }
        public bool deleteDonDatCho(int madon)
        {
            return DAO.DatChoOnlineDAO.Instance.deleteDonDatCho(madon);
        }
        public int insertDatCHoOnline(String sdtkhachhang, int ID_VITRI, int mabai, String ngaydat, int loaixe, String giodat)
        {
            return DatChoOnlineDAO.Instance.inserDatChoOnline(sdtkhachhang, ID_VITRI, mabai, ngaydat, loaixe, giodat);
        }

        public DataTable getAllDonHangOn(String sdtkh)
        {
            return DatChoOnlineDAO.Instance.getAllDonHangOn(sdtkh);
        }

        public int deleteDonOn(int madon, String sdt)
        {
            return DatChoOnlineDAO.Instance.deleteDon(madon, sdt);
        }
    }
}
