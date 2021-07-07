using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BaoCaoThang_DAO
    {
        static SqlConnection conn;

        public static List<BaoCaoThang_DTO> LoadBaoCaoThang()
        {
            string chuoiTruyVan = "select NgayMoSo, sum(SoMo) as SoMo, sum(SoDong) as SoDong, ABS(sum(SoMo) - sum(SoDong)) AS ChenhLech from ChiTietBaoCaoThang group by NgayMoSo";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<BaoCaoThang_DTO> danhSach = new List<BaoCaoThang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BaoCaoThang_DTO baoCaoThang = new BaoCaoThang_DTO();
                baoCaoThang.NgayMoSo = DateTime.Parse(dt.Rows[i]["NgayMoSo"].ToString());
                baoCaoThang.SoMo = int.Parse(dt.Rows[i]["SoMo"].ToString());
                baoCaoThang.SoDong = int.Parse(dt.Rows[i]["SoDong"].ToString());
                baoCaoThang.ChenhLech = int.Parse(dt.Rows[i]["ChenhLech"].ToString());
                danhSach.Add(baoCaoThang);
            }
            DataProvider.MoKetNoiDatabase();
            return danhSach;
        }


        //-------------------------- thêm chi tiet bao cao ngay ------------------------------
        public static bool ThemChiTietThang(BaoCaoThang_DTO baoCaoThang)
        {
            string QueryString = $" INSERT INTO ChiTietBaoCaoThang (MaChiTietBaoCaoThang, MaSoTietKiem, MaLoaiTietKiem, SoMo, SoDong, ChenhLech, NgayMoSo) "
                + $"VALUES('{baoCaoThang.MaChiTietThang}','{baoCaoThang.MaSoTietKiem}','{baoCaoThang.MaLoaiTietKiem}',{baoCaoThang.SoMo},{baoCaoThang.SoDong},{baoCaoThang.ChenhLech},'{baoCaoThang.NgayMoSo}'); ";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataProvider.ThucThiLenhTruyVan(QueryString, conn);
                DataProvider.DongKetNoiDatabase(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.DongKetNoiDatabase(conn);
                return false;
            }
        }
        //--------------------------thêm chi tiet bao cao ngay -------------------------------


        //----------------------------Cập nhật trạng thái sổ----------------------------------
        public static bool CapNhatTrangThaiSo(BaoCaoThang_DTO baoCaoThang)
        {
            string QueryString = string.Format("UPDATE ChiTietBaoCaoThang set SoDong = 1, SoMo = 0  where MaSoTietKiem = '{0}'", baoCaoThang.MaSoTietKiem);
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataProvider.ThucThiLenhTruyVan(QueryString, conn);
                DataProvider.DongKetNoiDatabase(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.DongKetNoiDatabase(conn);
                return false;
            }
        }
        //----------------------------Cập nhật số dư----------------------------------


        // --------------------- - tìm kiếm sổ tiết kiệm THEO Thang----------------------------
        public static List<BaoCaoThang_DTO> TraCuuThang(string thang, string nam, string loaitietkiem)
        {
            string chuoiTruyVan = "select NgayMoSo, sum(SoMo) as SoMo, sum(SoDong) as SoDong, ABS(sum(SoMo) - sum(SoDong)) AS ChenhLech from ChiTietBaoCaoThang where MONTH(NgayMoSo) = "+thang+" and YEAR(NgayMoSo) = "+nam+" AND MaLoaiTietKiem = '"+loaitietkiem+"' group by NgayMoSo";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<BaoCaoThang_DTO> danhSach = new List<BaoCaoThang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BaoCaoThang_DTO baoCaoThang = new BaoCaoThang_DTO();
                baoCaoThang.NgayMoSo = DateTime.Parse(dt.Rows[i]["NgayMoSo"].ToString());
                baoCaoThang.SoMo = int.Parse(dt.Rows[i]["SoMo"].ToString());
                baoCaoThang.SoDong = int.Parse(dt.Rows[i]["SoDong"].ToString());
                baoCaoThang.ChenhLech = int.Parse(dt.Rows[i]["ChenhLech"].ToString());

                danhSach.Add(baoCaoThang);
            }
            DataProvider.MoKetNoiDatabase();
            return danhSach;
        }
    }
}
