using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace QuanLySoTietKiem
{
    public partial class FormThongTinKhachHang : Form
    {
        List<int> ID = new List<int>();
        public FormThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void FormThongTinKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            setMaKH();
        }

        List<KhachHang_DTO> danhSachKhachHang;
        private void LoadKhachHang()
        {
            ID.Clear();
            danhSachKhachHang = KhachHang_BUS.LoadKhachHang();
            

            if (danhSachKhachHang != null)
            {
                foreach (KhachHang_DTO kh in danhSachKhachHang)
                {
                    ID.Add(int.Parse(kh.MaKhachHang.Substring(2)));
                }
            } 
            else
            {
                danhSachKhachHang = new List<KhachHang_DTO>();
            }
            dgvDanhSachKhachHang.DataSource = danhSachKhachHang;

            dgvDanhSachKhachHang.Columns["MaKhachHang"].HeaderText = "Mã KH";
            dgvDanhSachKhachHang.Columns["HoTen"].HeaderText = "Họ & Tên";
            dgvDanhSachKhachHang.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvDanhSachKhachHang.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvDanhSachKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvDanhSachKhachHang.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgvDanhSachKhachHang.Columns["CMND"].HeaderText = "CMND";
            dgvDanhSachKhachHang.Columns["NgayCap"].HeaderText = "Ngày Cấp";
            dgvDanhSachKhachHang.Columns["NoiCap"].HeaderText = "Nơi Cấp";

            dgvDanhSachKhachHang.Columns["MaKhachHang"].Width = 57;
            dgvDanhSachKhachHang.Columns["HoTen"].Width = 100;
            dgvDanhSachKhachHang.Columns["GioiTinh"].Width = 50;
            dgvDanhSachKhachHang.Columns["NgaySinh"].Width = 80;
            dgvDanhSachKhachHang.Columns["DiaChi"].Width = 70;
            dgvDanhSachKhachHang.Columns["SoDienThoai"].Width = 90;
            dgvDanhSachKhachHang.Columns["CMND"].Width = 85;
        }

        private string XacDinhMaKhachHang()
        {
            if (!ID.Contains(1))
            {
                return TaoMaKhachHang(1);
            }
            else
            {
                for (int i = 0; i < ID.Count - 1; i++)
                {
                    if (ID[i] + 1 != ID[i + 1])
                    {
                        return TaoMaKhachHang((ID[i] + 1));
                    }
                }
                return TaoMaKhachHang((ID[ID.Count - 1] + 1));
            }
        }
        private string TaoMaKhachHang(int MaKH)
        {
            string s;
            s = MaKH.ToString();
            while (s.Length < 3)
            {
                s = s.Insert(0, "0");
            }
            s = "KH" + s;
            return s;
        }


        //-------------------------- thêm khách hàng ------------------------------
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || cbGioiTinh.Text == "" || txtDiaChi.Text == "" || txtSoDienThoai.Text == "" || txtCMND.Text == "" || txtNoiCap.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin ...");
                return;
            }
            KhachHang_DTO khachHang = new KhachHang_DTO();

            String str = txtMaKhachHang.Text;

            if (danhSachKhachHang != null)
            {
                foreach (KhachHang_DTO kh in danhSachKhachHang)
                {
                    if (str == kh.MaKhachHang)
                    {
                        MessageBox.Show("Khách Hàng đã tồn tại");
                        return;
                    }
                }
            }
            khachHang.MaKhachHang = XacDinhMaKhachHang();
            khachHang.HoTen = txtHoTen.Text;
            khachHang.GioiTinh = cbGioiTinh.Text;
            khachHang.NgaySinh = DateTime.ParseExact(dtpNgaySinh.Text, "dd-MM-yyyy", new CultureInfo("en-CA"));
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.SoDienThoai = txtSoDienThoai.Text;
            khachHang.CMND = txtCMND.Text;
            khachHang.NgayCap = DateTime.ParseExact(dtpNgayCap.Text, "dd-MM-yyyy", new CultureInfo("en-CA"));
            khachHang.NoiCap = txtNoiCap.Text;


            if (KhachHang_BUS.ThemKhachHang(khachHang))
            {
                txtHoTen.Text = "";
                cbGioiTinh.Text = "";
                txtDiaChi.Text = "";
                txtSoDienThoai.Text = "";
                txtCMND.Text = "";
                txtNoiCap.Text = "";
                LoadKhachHang();
                MessageBox.Show("Thêm thành công");
                return;
            }
            MessageBox.Show("Thêm thất bại");
        }
        //-------------------------- thêm khách hàng ------------------------------


        //-------------------------- CMND và SĐT chỉ nhập số ------------------------------
        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //-------------------------- CMND chỉ nhập số ------------------------------


        //-------------------------- Sự kiện Click vào 1 dòng ------------------------------
        DataGridViewRow drKhachHang;
        private void dgvDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                drKhachHang = dgvDanhSachKhachHang.SelectedRows[0];
            }
            catch (Exception)
            {
                return;
            }
            if (drKhachHang.Cells["MaKhachHang"].Value.ToString() != "0001")
            {
                txtMaKhachHang.Text = drKhachHang.Cells["MaKhachHang"].Value.ToString();
                txtHoTen.Text = drKhachHang.Cells["HoTen"].Value.ToString();
                cbGioiTinh.Text = drKhachHang.Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Text = drKhachHang.Cells["NgaySinh"].Value.ToString();
                txtDiaChi.Text = drKhachHang.Cells["DiaChi"].Value.ToString();
                txtSoDienThoai.Text = drKhachHang.Cells["SoDienThoai"].Value.ToString();
                txtCMND.Text = drKhachHang.Cells["CMND"].Value.ToString();
                dtpNgayCap.Text = drKhachHang.Cells["NgayCap"].Value.ToString();
                txtNoiCap.Text = drKhachHang.Cells["NoiCap"].Value.ToString();
            }
        }
        //----------------------- Sự kiện Click vào 1 dòng ------------------------------


        //-------------------------- xóa khách hàng ------------------------------
        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            if (drKhachHang == null)
            {
                MessageBox.Show("Chọn khách hàng muốn xóa");
                return;
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                KhachHang_DTO khachHang = new KhachHang_DTO();
                khachHang.MaKhachHang = drKhachHang.Cells[0].Value.ToString();
                if (danhSachKhachHang == null)
                    dgvDanhSachKhachHang.DataSource = null;
                if (KhachHang_BUS.XoaKhachHang(khachHang))
                {
                    drKhachHang = null;
                    txtMaKhachHang.Text = "";
                    txtHoTen.Text = "";
                    cbGioiTinh.Text = "";
                    txtDiaChi.Text = "";
                    txtSoDienThoai.Text = "";
                    txtCMND.Text = "";
                    txtNoiCap.Text = "";
                    LoadKhachHang();
                    MessageBox.Show("Xóa thành công");
                    return;
                }
                MessageBox.Show("Xóa thất bại");
            }
        }
        //-------------------------- xóa khách hàng ------------------------------



        //-------------------------- Sửa khách hàng ------------------------------
        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (drKhachHang == null)
            {
                MessageBox.Show("Chọn khách hàng muốn cập nhật");
                return;
            }

            KhachHang_DTO khachHang = new KhachHang_DTO();
            khachHang.MaKhachHang = drKhachHang.Cells["MaKhachHang"].Value.ToString();
            khachHang.HoTen = txtHoTen.Text;
            khachHang.GioiTinh = cbGioiTinh.Text;
            khachHang.NgaySinh = DateTime.ParseExact(dtpNgaySinh.Text, "dd-MM-yyyy", new CultureInfo("en-CA"));
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.SoDienThoai = txtSoDienThoai.Text;
            khachHang.CMND = txtCMND.Text;
            khachHang.NgayCap = DateTime.ParseExact(dtpNgayCap.Text, "dd-MM-yyyy", new CultureInfo("en-CA"));
            khachHang.NoiCap = txtNoiCap.Text;

            if (KhachHang_BUS.SuaKhachHang(khachHang))
            {

                drKhachHang = null;
                txtMaKhachHang.Text = "";
                txtHoTen.Text = "";
                cbGioiTinh.Text = "";
                txtDiaChi.Text = "";
                txtSoDienThoai.Text = "";
                txtCMND.Text = "";
                txtNoiCap.Text = "";
                LoadKhachHang();
                MessageBox.Show("Sửa thành công");
                return;
            }
            MessageBox.Show("Sửa thất bại");
        }
        //-------------------------- Sửa khách hàng ------------------------------



        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<KhachHang_DTO> ketQua = KhachHang_BUS.TimKhachHang(txtTimKiem.Text);
            if (ketQua == null)
                return;
            dgvDanhSachKhachHang.DataSource = ketQua;
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập tên khách hàng ...";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.ForeColor = Color.Black;
        }

        private void setMaKH()
        {
            if (danhSachKhachHang == null)
                txtMaKhachHang.Text = "KH001";
            txtMaKhachHang.Text = "KH"+(danhSachKhachHang.Count+1).ToString("000");
        }
    }
}