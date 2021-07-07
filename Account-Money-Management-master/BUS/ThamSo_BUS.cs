using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThamSo_BUS
    {
        public static bool SuaTienGuiToiThieu(ThamSo_DTO thamSo)
        {
            return ThamSo_DAO.SuaTienGuiToiThieu(thamSo);
        }
        public static bool SuaTienGuiThemToiThieu(ThamSo_DTO thamSo)
        {
            return ThamSo_DAO.SuaTienGuiThemToiThieu(thamSo);
        }
        public static bool SuaThoiGianGuiToiThieu(ThamSo_DTO thamSo)
        {
            return ThamSo_DAO.SuaThoiGianGuiToiThieu(thamSo);
        }
    }
}
