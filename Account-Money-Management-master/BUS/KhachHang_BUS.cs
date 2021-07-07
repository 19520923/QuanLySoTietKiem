using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class KhachHang_BUS
    {
        public static List<KhachHang_DTO> LoadKhachHang()
        {
            return KhachHang_DAO.LoadKhachHang();
        }
        public static bool ThemKhachHang(KhachHang_DTO khachHang)
        {
            return KhachHang_DAO.ThemKhachHang(khachHang);
        }
        public static bool XoaKhachHang(KhachHang_DTO khachHang)
        {
            return KhachHang_DAO.XoaKhachHang(khachHang);
        }
        public static bool SuaKhachHang(KhachHang_DTO khachHang)
        {
            return KhachHang_DAO.SuaKhachHang(khachHang);
        }
        public static List<KhachHang_DTO> TimKhachHang(string tenKhachHang)
        {
            return KhachHang_DAO.TimKhachHang(tenKhachHang);
        }
    }
}