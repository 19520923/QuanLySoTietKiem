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
    public class PhieuGuiTien_DAO
    {
        static SqlConnection conn;
        public static List<PhieuGuiTien_DTO> LoadPhieuGuiTien()
        {
            string chuoiTruyVan = "Select MaPhieuGui, MaSoTietKiem, SoTienGui, NgayGui From PhieuGuiTien";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<PhieuGuiTien_DTO> danhSachPhieuGuiTien = new List<PhieuGuiTien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuGuiTien_DTO phieuGuiTien = new PhieuGuiTien_DTO();
                phieuGuiTien.MaPhieuGui = dt.Rows[i]["MaPhieuGui"].ToString();
                phieuGuiTien.MaSoTietKiem = dt.Rows[i]["MaSoTietKiem"].ToString();
                phieuGuiTien.SoTienGui = int.Parse(dt.Rows[i]["SoTienGui"].ToString());
                phieuGuiTien.NgayGui = DateTime.Parse(dt.Rows[i]["NgayGui"].ToString());

                danhSachPhieuGuiTien.Add(phieuGuiTien);
            }
            DataProvider.MoKetNoiDatabase();
            return danhSachPhieuGuiTien;
        }


        //-------------------------- Lưu phiếu gửi tiền ------------------------------
        public static bool LuuPhieuGuiTien(PhieuGuiTien_DTO phieuGuiTien)
        {
            string QueryString = $" INSERT INTO PhieuGuiTien (MaPhieuGui, MaSoTietKiem, SoTienGui, NgayGui) "
                + $"VALUES('{phieuGuiTien.MaPhieuGui}','{phieuGuiTien.MaSoTietKiem}', {phieuGuiTien.SoTienGui},'{phieuGuiTien.NgayGui}'); ";
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
        //-------------------------- Lưu phiếu gửi tiền ------------------------------


        //----------------------------Cập nhật số dư----------------------------------
        public static bool CapNhatSoDu(PhieuGuiTien_DTO phieuGuiTien)
        {
            string QueryString = string.Format("UPDATE SoTietKiem set SoDu = SoDu + {0} from SoTietKiem where MaSoTietKiem = '{1}'",  phieuGuiTien.SoTienGui ,phieuGuiTien.MaSoTietKiem);
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

    }
}
