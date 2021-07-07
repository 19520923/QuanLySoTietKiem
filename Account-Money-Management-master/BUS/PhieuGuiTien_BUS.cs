using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class PhieuGuiTien_BUS
    {
        public static List<PhieuGuiTien_DTO> LoadPhieuGuiTien()
        {
            return PhieuGuiTien_DAO.LoadPhieuGuiTien();
        }
        public static bool LuuPhieuGuiTien(PhieuGuiTien_DTO phieuGuiTien)
        {
            return PhieuGuiTien_DAO.LuuPhieuGuiTien(phieuGuiTien);
        }
        public static bool CapNhatSoDu(PhieuGuiTien_DTO phieuGuiTien)
        {
            return PhieuGuiTien_DAO.CapNhatSoDu(phieuGuiTien);
        }
    }
}
