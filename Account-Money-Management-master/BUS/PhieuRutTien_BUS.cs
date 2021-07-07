using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuRutTien_BUS
    {
        public static List<PhieuRutTien_DTO> LoadPhieuRutTien()
        {
            return PhieuRutTien_DAO.LoadPhieuRutTien();
        }
        public static bool LuuPhieuRutTien(PhieuRutTien_DTO phieuRutTien)
        {
            return PhieuRutTien_DAO.LuuPhieuRutTien(phieuRutTien);
        }
        public static bool CapNhatSoDu(PhieuRutTien_DTO phieuRutTien)
        {
            return PhieuRutTien_DAO.CapNhatSoDu(phieuRutTien);
        }
        public static bool CapNhatTrangThaiSo(PhieuRutTien_DTO phieuRutTien)
        {
            return PhieuRutTien_DAO.CapNhatTrangThaiSo(phieuRutTien);
        }
    }
}
