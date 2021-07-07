using DTO;
using DAO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLySoTietKiem
{
    public partial class FormLapSoTietKiem : Form
    {
        List<int> ID = new List<int>();
        public FormLapSoTietKiem()
        {
            InitializeComponent();        
        }

        List<SoTietKiem_DTO> danhSachSoTietKiem;

        private void LoadSoTietKiem()
        {
            ID.Clear();
            danhSachSoTietKiem = SoTietKiem_BUS.LoadSoTietKiem();
            

            if (danhSachSoTietKiem != null)
            {
                foreach (SoTietKiem_DTO stk in danhSachSoTietKiem)
                {
                    ID.Add(int.Parse(stk.MaSoTietKiem.Substring(3)));
                }
            }          


            

            if (danhSachSoTietKiem == null)
            {
                danhSachSoTietKiem = new List<SoTietKiem_DTO>();
            }
            dgvDanhSachSoTietKiem.DataSource = danhSachSoTietKiem;

            txtMaSoTietKiem.Text = "STK" + (danhSachSoTietKiem.Count + 1).ToString("000");

            dgvDanhSachSoTietKiem.Columns["MaSoTietKiem"].HeaderText = "Mã Sổ TK";
            dgvDanhSachSoTietKiem.Columns["MaKhachHang"].HeaderText = "Khách hàng";
            dgvDanhSachSoTietKiem.Columns["MaLoaiTietKiem"].HeaderText = "Mã Loại TK";
            dgvDanhSachSoTietKiem.Columns["NgayMoSo"].HeaderText = "Ngày Mở Sổ";
            dgvDanhSachSoTietKiem.Columns["SoTienGuiTietKiem"].HeaderText = "Số tiền gửi";

            dgvDanhSachSoTietKiem.Columns["TenLoaiTietKiem"].Visible = false;
            dgvDanhSachSoTietKiem.Columns["SoLanDaoHan"].Visible = false;
            dgvDanhSachSoTietKiem.Columns["TienLai"].Visible = false;
            dgvDanhSachSoTietKiem.Columns["SoDu"].Visible = false;
            dgvDanhSachSoTietKiem.Columns["TrangThaiSo"].Visible = false;

        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.btnThongTinKhachHang_Click(sender, e);
            formMain.Show();
        }

        private List<LoaiTietKiem_DTO> danhSachLoaiTietKiem = new List<LoaiTietKiem_DTO>();
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

        private List<KhachHang_DTO> danhSachKhachHang = new List<KhachHang_DTO>();
        private void LoadMaKhachHang()
        {
            cbMaKhachHang.Items.Clear();
            danhSachKhachHang = KhachHang_DAO.LoadKhachHang();
            if (danhSachKhachHang != null)
            {
                for (int i = 0; i < danhSachKhachHang.Count; i++)
                {
                    string str = danhSachKhachHang[i].MaKhachHang;
                    cbMaKhachHang.Items.Add(str);
                }
            }
        }

        private void cbMaKhachHang_SelectedValueChanged(object sender, EventArgs e)
        {
            String str = KhachHang_DAO.LayHoTenKhachHang(cbMaKhachHang.Text);
            txtHoTenKH.Text = str;
            String str1 = KhachHang_DAO.LayCMND(cbMaKhachHang.Text);
            txtCMND.Text = str1;
            String str2 = KhachHang_DAO.LayDiaChi(cbMaKhachHang.Text);
            txtDiaChi.Text = str2;
        }

        private void cbMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            String str = KhachHang_DAO.LayHoTenKhachHang(cbMaKhachHang.Text);
            txtHoTenKH.Text = str;
            String str1 = KhachHang_DAO.LayCMND(cbMaKhachHang.Text);
            txtCMND.Text = str1;
            String str2 = KhachHang_DAO.LayDiaChi(cbMaKhachHang.Text);
            txtDiaChi.Text = str2;
        }



        //-------------------------- Sự kiện Click vào 1 dòng ------------------------------
        DataGridViewRow drSoTietKiem;
        private void dgvDanhSachSoTietKiem_Click(object sender, EventArgs e)
        {
            try
            {
                drSoTietKiem = dgvDanhSachSoTietKiem.SelectedRows[0];
            }
            catch (Exception)
            {
                return;
            }
            if (drSoTietKiem.Cells["MaSoTietKiem"].Value.ToString() != "0001")
            {
                txtMaSoTietKiem.Text = drSoTietKiem.Cells["MaSoTietKiem"].Value.ToString();
                cbMaKhachHang.Text = drSoTietKiem.Cells["MaKhachHang"].Value.ToString();
                txtSoTienGui.Text = drSoTietKiem.Cells["SoTienGuiTietKiem"].Value.ToString();
                cbLoaiTietKiem.Text = SoTietKiem_DAO.LayTenLoaiTietKiem(drSoTietKiem.Cells["MaLoaiTietKiem"].Value.ToString());                        
                dtpNgayMoSo.Text = drSoTietKiem.Cells["NgayMoSo"].Value.ToString();          
            }
        }
        //-------------------------- Sự kiện Click vào 1 dòng ------------------------------


        private string XacDinhMaSoTietKiem()
        {
            if (!ID.Contains(1))
            {
                return TaoMaSoTietKiem(1);
            }
            else
            {
                for (int i = 0; i < ID.Count - 1; i++)
                {
                    if (ID[i] + 1 != ID[i + 1])
                    {
                        return TaoMaSoTietKiem((ID[i] + 1));
                    }
                }
                return TaoMaSoTietKiem((ID[ID.Count - 1] + 1));
            }
        }
        private string TaoMaSoTietKiem(int MaSTK)
        {
            string s;
            s = MaSTK.ToString();
            while (s.Length < 3)
            {
                s = s.Insert(0, "0");
            }
            s = "STK" + s;
            return s;
        }


        private void txtSoTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        bool KiemTraMaKH(String MaKH)
        {
            foreach (KhachHang_DTO kh in danhSachKhachHang)
            {
                if (MaKH == kh.MaKhachHang)
                {                  
                    return true;
                }
            }
            return false;
        }

        //------------------------------ Mở sổ tiết kiệm ----------------------------------
        private void btnMoSo_Click(object sender, EventArgs e)
        {
            if (cbMaKhachHang.Text == "" || txtSoTienGui.Text == "" || cbLoaiTietKiem.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin ...");
                return;
            }
            SoTietKiem_DTO soTietKiem = new SoTietKiem_DTO();
            BaoCaoNgay_DTO baoCaoNgay = new BaoCaoNgay_DTO();
            BaoCaoThang_DTO baoCaoThang = new BaoCaoThang_DTO();

            string str = txtMaSoTietKiem.Text;

            if (danhSachSoTietKiem != null)
            {
                foreach (SoTietKiem_DTO stk in danhSachSoTietKiem)
                {
                    if (str == stk.MaSoTietKiem)
                    {
                        MessageBox.Show("Sổ tiết kiệm đã tồn tại");
                        return;
                    }
                }
            }

            String str1 = cbMaKhachHang.Text;
            if (danhSachKhachHang != null)
            {
                if (KiemTraMaKH(str1) == false)
                {
                    MessageBox.Show("Khách hàng chưa đăng kí thông tin");
                    return;
                }
            }

            soTietKiem.MaSoTietKiem = XacDinhMaSoTietKiem();
            soTietKiem.MaKhachHang = cbMaKhachHang.Text;
            soTietKiem.MaLoaiTietKiem = SoTietKiem_DAO.LayMaLoaiTietKiem(cbLoaiTietKiem.Text);
            soTietKiem.NgayMoSo = DateTime.ParseExact(dtpNgayMoSo.Text, "dd-MM-yyyy", new CultureInfo("en-CA"));
            soTietKiem.SoTienGuiTietKiem = int.Parse(txtSoTienGui.Text);
            soTietKiem.SoLanDaoHan = 0;
            soTietKiem.TienLai = 0;
            soTietKiem.SoDu = soTietKiem.SoTienGuiTietKiem;
            soTietKiem.TrangThaiSo = 0;

            if (soTietKiem.SoTienGuiTietKiem < ThamSo_DAO.LaySoTienGuiToiThieu())
            {
                MessageBox.Show("Tiền gửi tối thiếu là " + ThamSo_DAO.LaySoTienGuiToiThieu());
                return;
            }    

            baoCaoNgay.MaChiTietNgay = XacDinhMaSoTietKiem() + "1";
            baoCaoNgay.MaLoaiTietKiem = soTietKiem.MaLoaiTietKiem;
            baoCaoNgay.TongThu = int.Parse(txtSoTienGui.Text);
            baoCaoNgay.TongChi = 0;
            baoCaoNgay.ChenhLech = baoCaoNgay.TongThu;
            baoCaoNgay.NgayLap = soTietKiem.NgayMoSo;

            baoCaoThang.MaChiTietThang = XacDinhMaSoTietKiem() + "2";
            baoCaoThang.MaSoTietKiem = XacDinhMaSoTietKiem();
            baoCaoThang.MaLoaiTietKiem = baoCaoNgay.MaLoaiTietKiem;
            baoCaoThang.SoMo = 1;
            baoCaoThang.SoDong = 0;
            baoCaoThang.ChenhLech = 1;
            baoCaoThang.NgayMoSo = soTietKiem.NgayMoSo;

            if (SoTietKiem_BUS.MoSoTietKiem(soTietKiem) && BaoCaoNgay_BUS.ThemChiTietNgay(baoCaoNgay) && BaoCaoThang_BUS.ThemChiTietThang(baoCaoThang))
            {
                cbMaKhachHang.Text = "";
                txtSoTienGui.Text = "";
                cbLoaiTietKiem.Text = "";      
                LoadSoTietKiem();
                MessageBox.Show("Thêm thành công");
                return;
            }
            MessageBox.Show("Thêm thất bại");
        }

        private void FormLapSoTietKiem_Load(object sender, EventArgs e)
        {
            LoadLoaiTietKiem();
            LoadMaKhachHang();
            LoadSoTietKiem();
        }
        //------------------------------ Mở sổ tiết kiệm ----------------------------------

    }
}
