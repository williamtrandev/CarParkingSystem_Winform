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
    }
}
