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
    public class PhieuRutTien_DAO
    {
        static SqlConnection conn;
        public static List<PhieuRutTien_DTO> LoadPhieuRutTien()
        {
            string chuoiTruyVan = "Select * From PhieuRutTien";
            conn = DataProvider.MoKetNoiDatabase();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<PhieuRutTien_DTO> danhSachPhieuRutTien = new List<PhieuRutTien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuRutTien_DTO phieuRutTien = new PhieuRutTien_DTO();
                phieuRutTien.MaPhieuRut = dt.Rows[i]["MaPhieuRut"].ToString();
                phieuRutTien.MaSoTietKiem = dt.Rows[i]["MaSoTietKiem"].ToString();
                phieuRutTien.SoTienRut = int.Parse(dt.Rows[i]["SoTienRut"].ToString());
                phieuRutTien.NgayRut = DateTime.Parse(dt.Rows[i]["NgayRut"].ToString());

                danhSachPhieuRutTien.Add(phieuRutTien);
            }
            DataProvider.MoKetNoiDatabase();
            return danhSachPhieuRutTien;
        }


        //-------------------------- Lưu phiếu rút tiền ------------------------------
        public static bool LuuPhieuRutTien(PhieuRutTien_DTO phieuRutTien)
        {
            string QueryString = $" INSERT INTO PhieuRutTien (MaPhieuRut, MaSoTietKiem, SoTienRut, NgayRut) "
                + $"VALUES('{phieuRutTien.MaPhieuRut}','{phieuRutTien.MaSoTietKiem}', {phieuRutTien.SoTienRut},'{phieuRutTien.NgayRut}'); ";
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
        //-------------------------- Lưu phiếu rút tiền ------------------------------


        //----------------------------Cập nhật số dư----------------------------------
        public static bool CapNhatSoDu(PhieuRutTien_DTO phieuRutTien)
        {
            string QueryString = string.Format("UPDATE SoTietKiem set SoDu = SoDu - {0} from SoTietKiem where MaSoTietKiem = '{1}'", phieuRutTien.SoTienRut, phieuRutTien.MaSoTietKiem);
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


        //----------------------------Cập nhật trạng thái sổ----------------------------------
        public static bool CapNhatTrangThaiSo(PhieuRutTien_DTO phieuRutTien)
        {
            string QueryString = string.Format("UPDATE SoTietKiem set TrangThaiSo = 1 from SoTietKiem where MaSoTietKiem = '{0}'", phieuRutTien.MaSoTietKiem);
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
