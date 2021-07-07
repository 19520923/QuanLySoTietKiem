using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BaoCaoNgay_BUS
    {
        public static List<BaoCaoNgay_DTO> LoadBaoCaoNgay()
        {
            return BaoCaoNgay_DAO.LoadBaoCaoNgay();
        }
        public static bool ThemChiTietNgay(BaoCaoNgay_DTO baoCaoNgay)
        {
            return BaoCaoNgay_DAO.ThemChiTietNgay(baoCaoNgay);
        }
        public static List<BaoCaoNgay_DTO> TraCuuNgay(DateTime ngayBaoCao)
        {
            return BaoCaoNgay_DAO.TraCuuNgay(ngayBaoCao);
        }
    }
}
