using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        public static SqlConnection MoKetNoiDatabase()
        {
            string chuoiKetNoi = @"Data Source=DESKTOP-I2KUT1M\CITADEL;Initial Catalog=QuanLySoTietKiem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            conn.Open();
            return conn;
        }

        public static void DongKetNoiDatabase(SqlConnection conn)
        {
            conn.Close();
        }

        public static DataTable LayDataTable(string chuoiTruyVan, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(chuoiTruyVan, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool ThucThiLenhTruyVan(string chuoiTruyVan, SqlConnection conn)
        {
            try
            {
                SqlCommand cm = new SqlCommand(chuoiTruyVan, conn);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

