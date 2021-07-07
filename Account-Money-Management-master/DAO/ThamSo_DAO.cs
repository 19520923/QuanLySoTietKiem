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
    public class ThamSo_DAO
    {
        static SqlConnection conn;

        // --------------------- số tiền gui tối thiểu----------------------
        public static int LaySoTienGuiToiThieu()
        {
            string QueryString = $"Select SoTienGuiToiThieu From ThamSo ";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataTable dt = DataProvider.LayDataTable(QueryString, conn);
                return int.Parse(dt.Rows[0]["SoTienGuiToiThieu"].ToString());
            }
            catch (Exception)
            {
                DataProvider.DongKetNoiDatabase(conn);
                return -1;
            }
        }
        // --------------------- số tiền gui tối thiểu----------------------



        // --------------------- số tiền gui thêm  tối thiểu----------------------
        public static int LaySoTienGuiThemToiThieu()
        {
            string QueryString = $"Select SoTienGuiThemToiThieu From ThamSo ";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataTable dt = DataProvider.LayDataTable(QueryString, conn);
                return int.Parse(dt.Rows[0]["SoTienGuiThemToiThieu"].ToString());
            }
            catch (Exception)
            {
                DataProvider.DongKetNoiDatabase(conn);
                return -1;
            }
        }
        // --------------------- số tiền gui thêm tối thiểu----------------------


        // --------------------- số tiền gui thêm  tối thiểu----------------------
        public static int LayThoiGianGuiToiThieu()
        {
            string QueryString = $"Select ThoiGianGuiToiThieu From ThamSo ";
            conn = DataProvider.MoKetNoiDatabase();
            try
            {
                DataTable dt = DataProvider.LayDataTable(QueryString, conn);
                return int.Parse(dt.Rows[0]["ThoiGianGuiToiThieu"].ToString());
            }
            catch (Exception)
            {
                DataProvider.DongKetNoiDatabase(conn);
                return -1;
            }
        }
        // --------------------- số tiền gui thêm tối thiểu----------------------


        //-------------------------- cập nhật tiền gủi tối thiểu -------------------------------
        public static bool SuaTienGuiToiThieu(ThamSo_DTO thamSo)
        {
            string QueryString = string.Format("UPDATE ThamSo set SoTienGuiToiThieu={0}", thamSo.TienGuiToiThieu);
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
        //-------------------------- cập nhật tiền gủi tối thiểu -------------------------------


        //-------------------------- cập nhật tiền gủi tối thiểu -------------------------------
        public static bool SuaTienGuiThemToiThieu(ThamSo_DTO thamSo)
        {
            string QueryString = string.Format("UPDATE ThamSo set SoTienGuiThemToiThieu={0}", thamSo.TienGuiThemToiThieu);
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
        //-------------------------- cập nhật tiền gủi tối thiểu -------------------------------



        //-------------------------- cập nhật tiền gủi tối thiểu -------------------------------
        public static bool SuaThoiGianGuiToiThieu(ThamSo_DTO thamSo)
        {
            string QueryString = string.Format("UPDATE ThamSo set ThoiGianGuiToiThieu={0}", thamSo.ThoiGianGuiToiThieu);
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
        //-------------------------- cập nhật tiền gủi tối thiểu -------------------------------
    }
}
