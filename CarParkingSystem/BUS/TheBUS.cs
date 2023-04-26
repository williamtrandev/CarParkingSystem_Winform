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
    public class TheBUS
    {
        private static TheBUS instance;
        public static TheBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TheBUS();
                }
                return instance;
            }

        }

        public TheBUS()
        {

        }
        public DataTable getAllTheVao(int id_vitri)
        {
            return DAO.TheDAO.Instance.getAllTheVao(id_vitri);
        }
        public DataTable getAllTheRa(int id_vitri)
        {
            return DAO.TheDAO.Instance.getAllTheRa(id_vitri);
        }
        public The getDetail(int id)
        {
            return DAO.TheDAO.Instance.getDetail(id);
        }
        public bool updateThe(The the)
        {
            return DAO.TheDAO.Instance.updateThe(the.SOTHE, the.BIENSOXE, the.GIOVAO, the.TRANGTHAI, the.MALOAIXE);
        }
    }
}
