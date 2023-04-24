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
    public class LoaiXeBUS
    {
        private static LoaiXeBUS instance;
        public static LoaiXeBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiXeBUS();
                }
                return instance;
            }

        }

        public LoaiXeBUS()
        {

        }
        public DataTable getAllLoaiXe()
        {
            return DAO.LoaiXeDAO.Instance.getAllLoaiXe();
        }
        public bool insertLoaiXe(LoaiXe lx)
        {
            return DAO.LoaiXeDAO.Instance.insertLoaiXe(lx);
        }
        public bool updateLoaiXe(LoaiXe lx)
        {
            return DAO.LoaiXeDAO.Instance.updateLoaiXe(lx);
        }
        public bool removeLoaiXe(String maloai)
        {
            return DAO.LoaiXeDAO.Instance.removeLoaiXe(maloai);
        }
    }
}
