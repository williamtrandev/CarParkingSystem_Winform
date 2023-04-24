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
    public class ViTriBUS
    {
        private static ViTriBUS instance;
        public static ViTriBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ViTriBUS();
                }
                return instance;
            }

        }

        public ViTriBUS()
        {

        }
        public List<ViTri> getAllXe(int mabai)
        {
            return DAO.ViTriDAO.Instance.getAllXe(mabai);
        }
        public bool changeStateVitriDatCho(int id_vitri)
        {
            return DAO.ViTriDAO.Instance.changeStateVitriDatCho(id_vitri);
        }
    }
}
