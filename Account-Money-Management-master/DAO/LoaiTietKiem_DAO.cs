using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class LoaiTietKiem_DAO
    {
        static SqlConnection conn;
        public static List<LoaiTietKiem_DTO> LoadLoaiTietKiem()
        {
            string chuoiTruyVan = "Select * From LoaiTietKiem";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<LoaiTietKiem_DTO> danhSachLoaiTietKiem = new List<LoaiTietKiem_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiTietKiem_DTO loaiTietKiem = new LoaiTietKiem_DTO();
                loaiTietKiem.MaLoaiTietKiem = dt.Rows[i]["MaLoaiTietKiem"].ToString();
                loaiTietKiem. TenLoaiTietKiem= dt.Rows[i]["TenLoaiTietKiem"].ToString();
                loaiTietKiem.KyHan = (int)dt.Rows[i]["KyHan"];
                loaiTietKiem.LaiSuat = (double)dt.Rows[i]["LaiSuat"];
               

                danhSachLoaiTietKiem.Add(loaiTietKiem);
            }
            DataProvider.MoKetNoiDatabase();
            return danhSachLoaiTietKiem;
        }

        //-------------------------- thêm loại tiết kiệm ------------------------------
        public static bool ThemLoaiTietKiem(LoaiTietKiem_DTO loaiTietKiem)
        {
            string QueryString = $" INSERT INTO LoaiTietKiem (MaLoaiTietKiem, TenLoaiTietKiem, KyHan, LaiSuat) "
                + $"VALUES('{loaiTietKiem.MaLoaiTietKiem}',N'{loaiTietKiem.TenLoaiTietKiem}', {loaiTietKiem.KyHan},{loaiTietKiem.LaiSuat}); ";
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
        //--------------------------thêm loại tiết kiệm------------------------------


        //-------------------------- xóa loại tiết kiệm ------------------------------
        public static bool XoaLoaiTietKiem(LoaiTietKiem_DTO loaiTietKiem)
        {
            string QueryString = string.Format("DELETE FROM LoaiTietKiem where MaLoaiTietKiem ='{0}'", loaiTietKiem.MaLoaiTietKiem);
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
        //-------------------------- xóa loại tiết kiệm ------------------------------



        //-------------------------- sửa loại tiết kiệm  -------------------------------
        public static bool SuaLoaiTietKiem(LoaiTietKiem_DTO loaiTietKiem)
        {
            string QueryString = string.Format("UPDATE LoaiTietKiem set TenLoaiTietKiem=N'{0}', KyHan= {1}, LaiSuat = {2}  where MaLoaiTietKiem = '{3}'", loaiTietKiem.TenLoaiTietKiem, loaiTietKiem.KyHan, loaiTietKiem.LaiSuat, loaiTietKiem.MaLoaiTietKiem);
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
        //-------------------------- sửa loại tiết kiệm  -------------------------------

        //-------------------------- lấy kỳ hạn ----------------------------------------

        public static LoaiTietKiem_DTO LayLoaiTietKiem(string maSTK)
        {
            string maLTK = SoTietKiem_DAO.LayMaLoaiTietKiemTheoSTK(maSTK);
            LoaiTietKiem_DTO loaiTietKiem = new LoaiTietKiem_DTO();
            string QueryString = string.Format("select * from LoaiTietKiem where MaLoaiTietKiem = '{0}'",maLTK);
            conn = DataProvider.MoKetNoiDatabase();
            DataTable tb = DataProvider.LayDataTable(QueryString, conn);
            try
            {
                loaiTietKiem.MaLoaiTietKiem = tb.Rows[0]["MaLoaiTietKiem"].ToString();
                loaiTietKiem.TenLoaiTietKiem = tb.Rows[0]["TenLoaiTietKiem"].ToString();
                loaiTietKiem.KyHan = (int)tb.Rows[0]["KyHan"];
                loaiTietKiem.LaiSuat = (double)tb.Rows[0]["LaiSuat"];
                return loaiTietKiem;
            }
            catch
            {
                DataProvider.DongKetNoiDatabase(conn);
                return null;
            }
        }
    }
}
