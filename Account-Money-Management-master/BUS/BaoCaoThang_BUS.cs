using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BaoCaoThang_BUS
    {
        public static List<BaoCaoThang_DTO> LoadBaoCaoThang()
        {
            return BaoCaoThang_DAO.LoadBaoCaoThang();
        }
        public static bool ThemChiTietThang(BaoCaoThang_DTO baoCaoThang)
        {
            return BaoCaoThang_DAO.ThemChiTietThang(baoCaoThang);
        }
        public static bool CapNhatTrangThaiSo(BaoCaoThang_DTO baoCaoThang)
        {
            return BaoCaoThang_DAO.CapNhatTrangThaiSo(baoCaoThang);
        }

        public static List<BaoCaoThang_DTO> TraCuuThang(string thang, string nam, string loaitietkiem)
        {
            return BaoCaoThang_DAO.TraCuuThang(thang, nam, loaitietkiem);
        }
    }
}
