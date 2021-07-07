using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySoTietKiem
{
    public partial class LoginForm : Form
    {

        bool ClickUserText = false;
        bool ClickPassText = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void DangNhap()
        {
            string chuoiKetNoi = @"Data Source=DESKTOP-I2KUT1M\CITADEL;Initial Catalog=QuanLySoTietKiem;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(chuoiKetNoi))
            {
                try
                {
                    con.Open();
                    string tk = txtTenDangNhap.Text;
                    string mk = txtMatKhau.Text;
                    string sql = "select *from TaiKhoan where TenDangNhap='" + tk + "' and MatKhau='" + mk + "'";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader dta = cmd.ExecuteReader())
                        {
                            if (dta.Read() == true)
                            {
                                this.Hide();
                                dta.Close();
                                con.Close();
                                FormMain form2 = new FormMain(tk);
                                form2.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Đăng nhập thất bại");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Kết Nối");
                }
            }
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (ClickUserText == false)
            {
                txtTenDangNhap.Text = "";
                ClickUserText = true;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (ClickPassText == false)
            {
                txtMatKhau.Text = "";
                ClickPassText = true;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            ClickUserText = false;
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            ClickPassText = false;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }
    }
}
