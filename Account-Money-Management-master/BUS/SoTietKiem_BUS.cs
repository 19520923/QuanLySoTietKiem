using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class SoTietKiem_BUS
    {
        public static List<SoTietKiem_DTO> LoadSoTietKiem()
        {
            return SoTietKiem_DAO.LoadSoTietKiem();
        }
        public static bool MoSoTietKiem(SoTietKiem_DTO soTietKiem)
        {
            return SoTietKiem_DAO.MoSoTietKiem(soTietKiem);
        }
        public static List<SoTietKiem_DTO> TimSoTietKiem(string maSoTietKiem)
        {
            return SoTietKiem_DAO.TimSoTietKiem(maSoTietKiem);
        }
        public static List<SoTietKiem_DTO> TimSoTietKiemTheoLoai(string maloaiTietKiem)
        {
            return SoTietKiem_DAO.TimSoTietKiemTheoLoai(maloaiTietKiem);
        }
        public static List<SoTietKiem_DTO> TimSoTietKiemTheoMaKH(string maKH)
        {
            return SoTietKiem_DAO.TimSoTietKiemTheoMaKH(maKH);
        }
        public static List<SoTietKiem_DTO> TimSoTietKiemTheoNgay(string tuNgay, string denNgay)
        {
            return SoTietKiem_DAO.TimSoTietKiemTheoNgay(tuNgay, denNgay);
        }
    }
}
