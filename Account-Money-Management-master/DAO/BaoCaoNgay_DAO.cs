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
    public class BaoCaoNgay_DAO
    {
        static SqlConnection conn;

        public static List<BaoCaoNgay_DTO> LoadBaoCaoNgay()
        {
            string chuoiTruyVan = "select NgayLap, MaLoaiTietKiem, SUM(SoTienThu) as TongThu, SUM(SoTienChi) as TongChi, ABS(SUM(SoTienThu) - SUM(SoTienChi)) as ChenhLech from ChiTietBaoCaoNgay GROUP BY NgayLap, MaLoaiTietKiem";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<BaoCaoNgay_DTO> danhSach = new List<BaoCaoNgay_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BaoCaoNgay_DTO baoCaoNgay = new BaoCaoNgay_DTO();
                baoCaoNgay.MaLoaiTietKiem = dt.Rows[i]["MaLoaiTietKiem"].ToString();
                baoCaoNgay.TongThu = int.Parse(dt.Rows[i]["TongThu"].ToString());
                baoCaoNgay.TongChi = int.Parse(dt.Rows[i]["TongChi"].ToString());
                baoCaoNgay.NgayLap = DateTime.Parse(dt.Rows[i]["NgayLap"].ToString());
                baoCaoNgay.ChenhLech = int.Parse(dt.Rows[i]["ChenhLech"].ToString());
                danhSach.Add(baoCaoNgay);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSach;
        }

        //-------------------------- thêm chi tiet bao cao ngay ------------------------------
        public static bool ThemChiTietNgay(BaoCaoNgay_DTO baoCaoNgay)
        {
            string QueryString = $" INSERT INTO ChiTietBaoCaoNgay (MaChiTietBaoCao, MaLoaiTietKiem, SoTienThu, SoTienChi, ChenhLech, NgayLap) "
                + $"VALUES('{baoCaoNgay.MaChiTietNgay}','{baoCaoNgay.MaLoaiTietKiem}',{baoCaoNgay.TongThu},{baoCaoNgay.TongChi},{baoCaoNgay.ChenhLech},'{baoCaoNgay.NgayLap}'); ";
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


        // --------------------- - tìm kiếm sổ tiết kiệm THEO NGAY----------------------------
        public static List<BaoCaoNgay_DTO> TraCuuNgay(DateTime ngayBaoCao)
        {
            string chuoiTruyVan = "select NgayLap, MaLoaiTietKiem, SUM(SoTienThu) as TongThu, SUM(SoTienChi) as TongChi, ABS(SUM(SoTienThu) - SUM(SoTienChi)) as ChenhLech from ChiTietBaoCaoNgay where NgayLap = '"+ngayBaoCao+"' GROUP BY NgayLap, MaLoaiTietKiem";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<BaoCaoNgay_DTO> danhSach = new List<BaoCaoNgay_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BaoCaoNgay_DTO baoCaoNgay = new BaoCaoNgay_DTO();
                baoCaoNgay.MaLoaiTietKiem = dt.Rows[i]["MaLoaiTietKiem"].ToString();
                baoCaoNgay.TongThu = int.Parse(dt.Rows[i]["TongThu"].ToString());
                baoCaoNgay.TongChi = int.Parse(dt.Rows[i]["TongChi"].ToString());
                baoCaoNgay.NgayLap = DateTime.Parse(dt.Rows[i]["NgayLap"].ToString());
                baoCaoNgay.ChenhLech = int.Parse(dt.Rows[i]["ChenhLech"].ToString());
                danhSach.Add(baoCaoNgay);
            }
            DataProvider.MoKetNoiDatabase();
            return danhSach;
        }
    }
}
