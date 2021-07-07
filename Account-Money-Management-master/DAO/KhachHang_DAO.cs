using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class KhachHang_DAO
    {
        static SqlConnection conn;
        public static List<KhachHang_DTO> LoadKhachHang()
        {
            string chuoiTruyVan = "Select * From KhachHang";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<KhachHang_DTO> danhSachKhachHang = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO khachHang = new KhachHang_DTO();   
                khachHang.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                khachHang.HoTen = dt.Rows[i]["HoTen"].ToString();
                khachHang.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                khachHang.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                khachHang.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                khachHang.SoDienThoai = dt.Rows[i]["SoDienThoai"].ToString();
                khachHang.CMND = dt.Rows[i]["CMND"].ToString();
                khachHang.NgayCap = DateTime.Parse(dt.Rows[i]["NgayCap"].ToString());
                khachHang.NoiCap = dt.Rows[i]["NoiCap"].ToString();

                danhSachKhachHang.Add(khachHang);
            }
            DataProvider.MoKetNoiDatabase();
            return danhSachKhachHang;
        }


        //-------------------------- thêm khách hàng ------------------------------
        public static bool ThemKhachHang(KhachHang_DTO khachHang)
        {
            string QueryString = $" INSERT INTO KhachHang (MaKhachHang, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, CMND, NgayCap, NoiCap) "
                + $"VALUES(N'{khachHang.MaKhachHang}',N'{khachHang.HoTen}',N'{khachHang.GioiTinh}','{khachHang.NgaySinh}',N'{khachHang.DiaChi}',N'{khachHang.SoDienThoai}',N'{khachHang.CMND}','{khachHang.NgayCap}',N'{khachHang.NoiCap}'); ";
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
        //-------------------------- thêm khách hàng ------------------------------


        //-------------------------- xóa khách hàng ------------------------------
        public static bool XoaKhachHang(KhachHang_DTO khachHang)
        {
            // chuỗi truy vấn nhân viên
            string QueryString = string.Format("DELETE FROM KhachHang where MaKhachHang ='{0}'", khachHang.MaKhachHang);
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
        //-------------------------- xóa khách hàng ------------------------------



        //-------------------------- sửa nhân viên -------------------------------
        public static bool SuaKhachHang(KhachHang_DTO khachHang)
        {
            string QueryString = string.Format("UPDATE KhachHang set HoTen=N'{0}', GioiTinh=N'{1}', NgaySinh='{2}', DiaChi=N'{3}', SoDienThoai=N'{4}', CMND=N'{5}', NgayCap ='{6}', NoiCap =N'{7}' where MaKhachHang='{8}'", khachHang.HoTen, khachHang.GioiTinh, khachHang.NgaySinh, khachHang.DiaChi, khachHang.SoDienThoai, khachHang.CMND, khachHang.NgayCap, khachHang.NoiCap, khachHang.MaKhachHang);
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
        //-------------------------- sửa nhân viên -------------------------------



        // --------------------- - tìm kiếm khách hàng ----------------------------
        public static List<KhachHang_DTO> TimKhachHang(string tenKhachHang)
        {
            string QueryString = string.Format("select * from KhachHang where  HoTen like '%" + tenKhachHang + "%'");
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(QueryString, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<KhachHang_DTO> danhSachKhachHang = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO khachHang = new KhachHang_DTO();

                khachHang.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                khachHang.HoTen = dt.Rows[i]["HoTen"].ToString();
                khachHang.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                khachHang.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                khachHang.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                khachHang.SoDienThoai = dt.Rows[i]["SoDienThoai"].ToString();
                khachHang.CMND = dt.Rows[i]["CMND"].ToString();
                khachHang.NgayCap = DateTime.Parse(dt.Rows[i]["NgayCap"].ToString());
                khachHang.NoiCap = dt.Rows[i]["NoiCap"].ToString();

                danhSachKhachHang.Add(khachHang);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSachKhachHang;
        }
        // --------------------- - tìm kiếm khách hàng ----------------------------


        // --------------------- lấy họ tên khách hàng theo mã----------------------
        public static String LayHoTenKhachHang(string maKhachHang)
        {
            string QueryString = $"Select HoTen From KhachHang Where MaKhachHang = '{maKhachHang}'";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataTable dt = DataProvider.LayDataTable(QueryString, conn);
                return dt.Rows[0]["HoTen"].ToString();
            }
            catch (Exception)
            {
                DataProvider.DongKetNoiDatabase(conn);
                return null;
            }
        }
        // --------------------- lấy họ tên khách hàng theo mã----------------------



        // --------------------- lấy CMND khách hàng theo mã----------------------
        public static String LayCMND(string maKhachHang)
        {
            string QueryString = $"Select CMND From KhachHang Where MaKhachHang = '{maKhachHang}'";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataTable dt = DataProvider.LayDataTable(QueryString, conn);
                return dt.Rows[0]["CMND"].ToString();
            }
            catch (Exception)
            {
                DataProvider.DongKetNoiDatabase(conn);
                return null;
            }
        }
        // --------------------- lấy CMND khách hàng theo mã----------------------



        // --------------------- lấy Địa chỉ khách hàng theo mã----------------------
        public static String LayDiaChi(string maKhachHang)
        {
            string QueryString = $"Select DiaChi From KhachHang Where MaKhachHang = '{maKhachHang}'";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataTable dt = DataProvider.LayDataTable(QueryString, conn);
                return dt.Rows[0]["DiaChi"].ToString();
            }
            catch (Exception)
            {
                DataProvider.DongKetNoiDatabase(conn);
                return null;
            }
        }
        // --------------------- lấy Địa chỉ khách hàng theo mã----------------------

    }
}
