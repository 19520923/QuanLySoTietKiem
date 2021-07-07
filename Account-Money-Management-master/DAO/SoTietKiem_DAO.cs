using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class SoTietKiem_DAO
    {
        static SqlConnection conn;
        public static List<SoTietKiem_DTO> LoadSoTietKiem()
        {
            string chuoiTruyVan = "Select MaSoTietKiem, MaKhachHang, MaLoaiTietKiem, NgayMoSo, SoTienGuiTietKiem , SoDu From SoTietKiem";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<SoTietKiem_DTO> danhSachSoTietKiem = new List<SoTietKiem_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SoTietKiem_DTO soTietKiem = new SoTietKiem_DTO();
                soTietKiem.MaSoTietKiem = dt.Rows[i]["MaSoTietKiem"].ToString();
                soTietKiem.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                soTietKiem.MaLoaiTietKiem = dt.Rows[i]["MaLoaiTietKiem"].ToString();
                soTietKiem.NgayMoSo = DateTime.Parse(dt.Rows[i]["NgayMoSo"].ToString());
                soTietKiem.SoTienGuiTietKiem = (int)dt.Rows[i]["SoTienGuiTietKiem"];
                soTietKiem.SoDu = (int)dt.Rows[i]["SoDu"];
                soTietKiem.TenLoaiTietKiem = LayTenLoaiTietKiem(dt.Rows[i]["MaLoaiTietKiem"].ToString());


                danhSachSoTietKiem.Add(soTietKiem);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSachSoTietKiem;
        }


        // --------------------- lấy tên loại tiết kiệm theo mã----------------------
        public static String LayTenLoaiTietKiem(string maLoaiTietKiem)
        {
            string QueryString = $"Select TenLoaiTietKiem From LoaiTietKiem Where MaLoaiTietKiem = '{maLoaiTietKiem}'";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataTable dt = DataProvider.LayDataTable(QueryString, conn);
                return dt.Rows[0]["TenLoaiTietKiem"].ToString();
            }
            catch (Exception)
            {
                DataProvider.DongKetNoiDatabase(conn);
                return null;
            }
        }
        // --------------------- lấy tên loại tiết kiệm theo mã----------------------


        // --------------------- lấy ngày mở sổ  theo mã----------------------
        public static DateTime LayNgayMoSoTietKiem(string maSoTietKiem)
        {
            string QueryString = $"Select NgayMoSo From SoTietKiem Where MaSoTietKiem = '{maSoTietKiem}'";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataTable dt = DataProvider.LayDataTable(QueryString, conn);
                return DateTime.Parse(dt.Rows[0]["NgayMoSo"].ToString());
            }
            catch (Exception)
            {
                DataProvider.DongKetNoiDatabase(conn);
                return DateTime.Parse("1/1/1111");
            }
        }
        // -------------------------lấy ngày mở sổ  theo mã-----------------------------


        // --------------------- lấy mã loại tiết kiệm theo mã----------------------
        public static String LayMaLoaiTietKiem(string tenLoaiTietKiem)
        {
            string QueryString = $"Select MaLoaiTietKiem From LoaiTietKiem Where TenLoaiTietKiem = '{tenLoaiTietKiem}'";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataTable dt = DataProvider.LayDataTable(QueryString, conn);
                return dt.Rows[0]["MaLoaiTietKiem"].ToString();
            }
            catch (Exception)
            {
                DataProvider.DongKetNoiDatabase(conn);
                return null;
            }
        }
        // --------------------- lấy mã loại tiết kiệm theo mã----------------------



        // --------------- lấy tên khách hàng theo mã sổ tiết kiệm-----------------
        public static String LayTenKhachHang(string maSoTietKiem)
        {
            string QueryString = $"Select HoTen From KhachHang KH, SoTietKiem STK Where KH.MaKhachHang = STK.MaKhachHang and STK.MaSoTietKiem = '{maSoTietKiem}'";
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
        // --------------- lấy tên khách hàng theo mã sổ tiết kiệm-----------------



        // --------------------- lấy số dư theo mã sổ tiết kiệm---------------------
        public static int LaySoDu(string maSoTietKiem)
        {
            string QueryString = $"Select SoDu From SoTietKiem Where MaSoTietKiem = '{maSoTietKiem}'";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataTable dt = DataProvider.LayDataTable(QueryString, conn);
                return int.Parse(dt.Rows[0]["SoDu"].ToString());
            }
            catch (Exception)
            {
                DataProvider.DongKetNoiDatabase(conn);
                return -1;
            }
        }
        // --------------------- lấy số dư theo mã sổ tiết kiệm---------------------


        // ------------------ lấy trang thai sổ theo mã sổ tiết kiệm-----------------
        public static int LayTrangThaiSo(string maSoTietKiem)
        {
            string QueryString = $"Select TrangThaiSo From SoTietKiem Where MaSoTietKiem = '{maSoTietKiem}'";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataTable dt = DataProvider.LayDataTable(QueryString, conn);
                return int.Parse(dt.Rows[0]["TrangThaiSo"].ToString());
            }
            catch (Exception)
            {
                DataProvider.DongKetNoiDatabase(conn);
                return -1;
            }
        }
        // ------------------ lấy trang thai sổ theo mã sổ tiết kiệm-----------------



        // ------------------ lấy mã loại ti theo mã sổ tiết kiệm-----------------
        public static string LayMaLoaiTietKiemTheoSTK(string maSoTietKiem)
        {
            string QueryString = string.Format("Select MaLoaiTietKiem From SoTietKiem Where MaSoTietKiem = '{0}'",maSoTietKiem);
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(QueryString, conn);
            try
            {
                string mltk = dt.Rows[0]["MaLoaiTietKiem"].ToString();
                return mltk;
            }
            catch 
            {
                DataProvider.DongKetNoiDatabase(conn);
                return "";
            }
        }
        // ------------------ lấy trang thai sổ theo mã sổ tiết kiệm-----------------



        //-------------------------- mở sổ tiết kiệm ------------------------------
        public static bool MoSoTietKiem(SoTietKiem_DTO soTietKiem)
        {
            string QueryString = $" INSERT INTO SoTietKiem (MaSoTietKiem, MaKhachHang, MaLoaiTietKiem, NgayMoSo, SoTienGuiTietKiem, SoLanDaoHan, TienLai, SoDu, TrangThaiSo) "
                + $"VALUES('{soTietKiem.MaSoTietKiem}','{soTietKiem.MaKhachHang}', '{soTietKiem.MaLoaiTietKiem}','{soTietKiem.NgayMoSo}',{soTietKiem.SoTienGuiTietKiem},{soTietKiem.SoLanDaoHan},{soTietKiem.TienLai},{soTietKiem.SoDu},{soTietKiem.TrangThaiSo}); ";
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
        //--------------------------mở sổ tiết kiệm------------------------------


        // --------------------- tìm kiếm sổ tiết kiệm ----------------------------
        public static List<SoTietKiem_DTO> TimSoTietKiem(string maSoTietKiem)
        {
            string QueryString = string.Format("select * from SoTietKiem where MaSoTietKiem like '%" + maSoTietKiem + "%'");
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(QueryString, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<SoTietKiem_DTO> danhSachSoTietKiem = new List<SoTietKiem_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SoTietKiem_DTO soTietKiem = new SoTietKiem_DTO();

                soTietKiem.MaSoTietKiem = dt.Rows[i]["MaSoTietKiem"].ToString();
                soTietKiem.MaLoaiTietKiem = dt.Rows[i]["MaLoaiTietKiem"].ToString();
                soTietKiem.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                soTietKiem.SoDu = int.Parse(dt.Rows[i]["SoDu"].ToString());
                soTietKiem.TenLoaiTietKiem = LayTenLoaiTietKiem(dt.Rows[i]["MaLoaiTietKiem"].ToString());

                danhSachSoTietKiem.Add(soTietKiem);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSachSoTietKiem;
        }
        // --------------------- - tìm kiếm sổ tiết kiệm ----------------------------


        // ----------------------- tìm kiếm sổ tiết kiệm theo loại tk ----------------------------
        public static List<SoTietKiem_DTO> TimSoTietKiemTheoLoai(string maLoaiTietKiem)
        {
            string QueryString = string.Format("select * from SoTietKiem where MaLoaiTietKiem like '%" + maLoaiTietKiem + "%'");
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(QueryString, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<SoTietKiem_DTO> danhSachSoTietKiem = new List<SoTietKiem_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SoTietKiem_DTO soTietKiem = new SoTietKiem_DTO();

                soTietKiem.MaSoTietKiem = dt.Rows[i]["MaSoTietKiem"].ToString();
                soTietKiem.MaLoaiTietKiem = dt.Rows[i]["MaLoaiTietKiem"].ToString();
                soTietKiem.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                soTietKiem.SoDu = int.Parse(dt.Rows[i]["SoDu"].ToString());
                soTietKiem.TenLoaiTietKiem = LayTenLoaiTietKiem(dt.Rows[i]["MaLoaiTietKiem"].ToString());

                danhSachSoTietKiem.Add(soTietKiem);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSachSoTietKiem;
        }
        // --------------------- - tìm kiếm sổ tiết kiệm ----------------------------


        // ----------------------- tìm kiếm sổ tiết kiệm theo MA KH----------------------------
        public static List<SoTietKiem_DTO> TimSoTietKiemTheoMaKH(string maKH)
        {
            string QueryString = string.Format("select * from SoTietKiem where MaKhachHang like '%" + maKH + "%'");
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(QueryString, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<SoTietKiem_DTO> danhSachSoTietKiem = new List<SoTietKiem_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SoTietKiem_DTO soTietKiem = new SoTietKiem_DTO();

                soTietKiem.MaSoTietKiem = dt.Rows[i]["MaSoTietKiem"].ToString();
                soTietKiem.MaLoaiTietKiem = dt.Rows[i]["MaLoaiTietKiem"].ToString();
                soTietKiem.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                soTietKiem.SoDu = int.Parse(dt.Rows[i]["SoDu"].ToString());
                soTietKiem.TenLoaiTietKiem = LayTenLoaiTietKiem(dt.Rows[i]["MaLoaiTietKiem"].ToString());

                danhSachSoTietKiem.Add(soTietKiem);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSachSoTietKiem;
        }
        // --------------------- - tìm kiếm sổ tiết kiệm ----------------------------


        // --------------------- - tìm kiếm sổ tiết kiệm THEO NGAY----------------------------
        public static List<SoTietKiem_DTO> TimSoTietKiemTheoNgay(string tuNgay, string denNgay)
        {
            string chuoiTruyVan = "select * from SoTietKiem where NgayMoSo >= '" + tuNgay + "' AND NgayMoSo <= '" + denNgay + "'";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<SoTietKiem_DTO> danhSachSoTietKiem = new List<SoTietKiem_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SoTietKiem_DTO soTietKiem = new SoTietKiem_DTO();

                soTietKiem.MaSoTietKiem = dt.Rows[i]["MaSoTietKiem"].ToString();
                soTietKiem.MaLoaiTietKiem = dt.Rows[i]["MaLoaiTietKiem"].ToString();
                soTietKiem.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                soTietKiem.SoDu = int.Parse(dt.Rows[i]["SoDu"].ToString());
                soTietKiem.TenLoaiTietKiem = LayTenLoaiTietKiem(dt.Rows[i]["MaLoaiTietKiem"].ToString());

                danhSachSoTietKiem.Add(soTietKiem);
            }
            DataProvider.DongKetNoiDatabase(conn);
            return danhSachSoTietKiem;
        }
        // --------------------- - tìm kiếm sổ tiết kiệm THEO NGAY----------------------------


    }
}
