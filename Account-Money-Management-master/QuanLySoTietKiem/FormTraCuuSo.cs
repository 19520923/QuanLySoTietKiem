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
    public partial class FormTraCuuSo : Form
    {
        public FormTraCuuSo()
        {
            InitializeComponent();
            LoadLoaiTietKiem();
            LoadMaSoTietKiem();
            LoadSoTietKiem();
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


        private List<SoTietKiem_DTO> danhSachSoTietKiem;
        private void LoadMaSoTietKiem()
        {
            cbMaSoTietKiem.Items.Clear();
            danhSachSoTietKiem = SoTietKiem_DAO.LoadSoTietKiem();
            if (danhSachSoTietKiem != null)
            {
                for (int i = 0; i < danhSachSoTietKiem.Count; i++)
                {
                    string str = danhSachSoTietKiem[i].MaSoTietKiem;
                    cbMaSoTietKiem.Items.Add(str);
                }
            }
        }

        private void LoadSoTietKiem()
        {
            danhSachSoTietKiem = SoTietKiem_BUS.LoadSoTietKiem();
            dgvDanhSachSoTietKiem.DataSource = danhSachSoTietKiem;

            if (danhSachSoTietKiem == null)
            {
                return;
            }

            dgvDanhSachSoTietKiem.Columns["MaSoTietKiem"].HeaderText = "Mã Sổ TK";
            dgvDanhSachSoTietKiem.Columns["MaLoaiTietKiem"].Visible = false;
            dgvDanhSachSoTietKiem.Columns["MaKhachHang"].HeaderText = "Khách hàng";
            dgvDanhSachSoTietKiem.Columns["SoDu"].HeaderText = "Số Dư";
            dgvDanhSachSoTietKiem.Columns["TenLoaiTietKiem"].HeaderText = "Loại Tiết Kiệm";

            dgvDanhSachSoTietKiem.Columns["NgayMoSo"].Visible = false;
            dgvDanhSachSoTietKiem.Columns["SoTienGuiTietKiem"].Visible = false;
            dgvDanhSachSoTietKiem.Columns["SoLanDaoHan"].Visible = false;
            dgvDanhSachSoTietKiem.Columns["TienLai"].Visible = false;          
            dgvDanhSachSoTietKiem.Columns["TrangThaiSo"].Visible = false;



            for (int i = 0; i < dgvDanhSachSoTietKiem.Rows.Count; i++)
            {
                dgvDanhSachSoTietKiem.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }


        }

        private void dgvDanhSachSoTietKiem_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvDanhSachSoTietKiem.Rows.Count; i++)
            {
                dgvDanhSachSoTietKiem[0, i].Value = i + 1;
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (cbMaSoTietKiem.Text == "" && txtKhachHang.Text == "")
            {
                string maLTK = SoTietKiem_DAO.LayMaLoaiTietKiem(cbLoaiTietKiem.Text);
                List<SoTietKiem_DTO> ketQua = SoTietKiem_BUS.TimSoTietKiemTheoLoai(maLTK);
                if (ketQua == null)
                    return;
                dgvDanhSachSoTietKiem.DataSource = ketQua;
                
            }
            if (cbLoaiTietKiem.Text == "" && txtKhachHang.Text == "")
            {
                List<SoTietKiem_DTO> ketQua1 = SoTietKiem_BUS.TimSoTietKiem(cbMaSoTietKiem.Text);
                if (ketQua1 == null)
                    return;
                dgvDanhSachSoTietKiem.DataSource = ketQua1;
                
            }
            if (cbLoaiTietKiem.Text == "" && cbMaSoTietKiem.Text == "")
            {
                List<SoTietKiem_DTO> ketQua = SoTietKiem_BUS.TimSoTietKiemTheoMaKH(txtKhachHang.Text);
                if (ketQua == null)
                    return;
                dgvDanhSachSoTietKiem.DataSource = ketQua;

            }
            if (cbLoaiTietKiem.Text == "" && cbMaSoTietKiem.Text == "" && txtKhachHang.Text == "")
            {
                List<SoTietKiem_DTO> ketQua = SoTietKiem_BUS.TimSoTietKiemTheoNgay(dtpTuNgay.Text, dtpDenNgay.Text);
                if (ketQua == null)
                    return;
                dgvDanhSachSoTietKiem.DataSource = ketQua;

            }
            txtKhachHang.Text = "";
            cbMaSoTietKiem.Text = "";
            cbLoaiTietKiem.Text = "";
        }
    }
}
