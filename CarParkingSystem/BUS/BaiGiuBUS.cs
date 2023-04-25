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
    public class BaiGiuBUS
    {
        private static BaiGiuBUS instance;
        public static BaiGiuBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BaiGiuBUS();
                }
                return instance;
            }

        }

        public BaiGiuBUS()
        {

        }
        public List<BaiGiu> getallBaiGiuXe()
        {
            return BaiGiuDAO.Instance.GetBaiGiuXes();
        }
        public DataTable getAllBaiGiu()
        {
            return DAO.BaiGiuDAO.Instance.getAllBaiGiu();
        }
        public bool insertBaiGiu(BaiGiu bg)
        {
            return DAO.BaiGiuDAO.Instance.insertBaiGiu(bg);
        }
        public bool updateBaiGiu(BaiGiu bg)
        {
            return DAO.BaiGiuDAO.Instance.updateBaiGiu(bg);
        }
        public bool removeBaiGiu(String mabai)
        {
            return DAO.BaiGiuDAO.Instance.removeBaiGiu(mabai);
        }
    }
}
