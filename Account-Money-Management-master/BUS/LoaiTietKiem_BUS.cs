using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiTietKiem_BUS
    {
        public static List<LoaiTietKiem_DTO> LoadLoaiTietKiem()
        {
            return LoaiTietKiem_DAO.LoadLoaiTietKiem();
        }
        public static bool ThemLoaiTietKiem(LoaiTietKiem_DTO loaiTietKiem)
        {
            return LoaiTietKiem_DAO.ThemLoaiTietKiem(loaiTietKiem);
        }
        public static bool XoaLoaiTietKiem(LoaiTietKiem_DTO loaiTietKiem)
        {
            return LoaiTietKiem_DAO.XoaLoaiTietKiem(loaiTietKiem);
        }
        public static bool SuaLoaiTietKiem(LoaiTietKiem_DTO loaiTietKiem)
        {
            return LoaiTietKiem_DAO.SuaLoaiTietKiem(loaiTietKiem);
        }
    }
}
