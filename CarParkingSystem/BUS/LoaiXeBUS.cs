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
        public List<LoaiXe> getAllLoaiXe()
        {
            List<LoaiXe> Temp = new List<LoaiXe>();
            foreach (LoaiXe c in LoaiXeDAO.Instance.getAllLoaiXe())
            {
                if (c.Deleted == 0)
                {
                    Temp.Add(c);
                }
            }
            return Temp;
        }
        public DataTable getAllLoaiXeDT()
        {
            return DAO.LoaiXeDAO.Instance.getAllLoaiXeDT();
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
