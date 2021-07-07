using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySoTietKiem
{
    public partial class FormBaoCaoThang : Form
    {
        public FormBaoCaoThang()
        {
            InitializeComponent();
            LoadLoaiTietKiem();
            LoadBaoCaoThang();
        }

        List<BaoCaoThang_DTO> danhSach;
        private void LoadBaoCaoThang()
        {
            danhSach = BaoCaoThang_BUS.LoadBaoCaoThang();

            if (danhSach == null) return;

            dgvBaoCaoThang.DataSource = danhSach;
            dgvBaoCaoThang.Columns["MaChiTietThang"].Visible = false;
            dgvBaoCaoThang.Columns["MaLoaiTietKiem"].Visible = false;
            dgvBaoCaoThang.Columns["MaSoTietKiem"].Visible = false;

            dgvBaoCaoThang.Columns["NgayMoSo"].HeaderText = "Ngày";
            dgvBaoCaoThang.Columns["SoMo"].HeaderText = "Sổ Mở";
            dgvBaoCaoThang.Columns["SoDong"].HeaderText = "Sổ Đóng";
            dgvBaoCaoThang.Columns["ChenhLech"].HeaderText = "Chênh lệch";

        }


        private List<LoaiTietKiem_DTO> danhSachLoaiTietKiem;
        private void LoadLoaiTietKiem()
        {
            cbLoaiTietKiem.Items.Clear();
            danhSachLoaiTietKiem = LoaiTietKiem_DAO.LoadLoaiTietKiem();
            if (danhSachLoaiTietKiem != null)
            {
                for (int i = 0; i < danhSachLoaiTietKiem.Count; i++)
                {
                    string str = danhSachLoaiTietKiem[i].TenLoaiTietKiem;
                    cbLoaiTietKiem.Items.Add(str);
                }
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (cbThang.Text != "" && cbNam.Text != "" && cbLoaiTietKiem.Text != "")
            {
                string maLoaiTietKiem = SoTietKiem_DAO.LayMaLoaiTietKiem(cbLoaiTietKiem.Text);
                List<BaoCaoThang_DTO> ketQua = BaoCaoThang_BUS.TraCuuThang(cbThang.Text, cbNam.Text, maLoaiTietKiem);
                if (ketQua == null)
                {
                    ketQua = new List<BaoCaoThang_DTO>();
                }
                dgvBaoCaoThang.DataSource = ketQua;

                int somo = 0;
                int sodong = 0;
                int chenhlech;
                for (int i = 0; i < dgvBaoCaoThang.Rows.Count; i++)
                {
                    somo += int.Parse(dgvBaoCaoThang.Rows[i].Cells["SoMo"].Value.ToString());
                    sodong += int.Parse(dgvBaoCaoThang.Rows[i].Cells["SoDong"].Value.ToString());
                }
                chenhlech = Math.Abs(somo - sodong);
                lbSoMo.Text = somo.ToString();
                lbSoDong.Text = sodong.ToString();
                lbChenhLech.Text = chenhlech.ToString();
            }
           
        }
    }
}
