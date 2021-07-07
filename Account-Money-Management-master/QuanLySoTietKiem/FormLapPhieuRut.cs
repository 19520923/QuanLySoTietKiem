using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySoTietKiem
{
    public partial class FormLapPhieuRut : Form
    {
        List<int> ID = new List<int>();
        public FormLapPhieuRut()
        {
            InitializeComponent();
        }

        private void FormLapPhieuRut_Load(object sender, EventArgs e)
        {
            LoadMaSoTietKiem();
            LoadPhieuRutTien();
        }

        List<PhieuRutTien_DTO> danhSachPhieuRutTien;
        private void LoadPhieuRutTien()
        {
            ID.Clear();
            danhSachPhieuRutTien = PhieuRutTien_BUS.LoadPhieuRutTien();

            if (danhSachPhieuRutTien != null)
            {
                foreach (PhieuRutTien_DTO prt in danhSachPhieuRutTien)
                {
                    ID.Add(int.Parse(prt.MaPhieuRut.Substring(2)));
                }
            }

            if (danhSachPhieuRutTien == null)
            {
                danhSachPhieuRutTien = new List<PhieuRutTien_DTO>();
            }
            dgvDanhSachPhieuRutTien.DataSource = danhSachPhieuRutTien;

            txtMaPhieuRut.Text = TaoMaPhieuRutTien(danhSachPhieuRutTien.Count + 1);

            dgvDanhSachPhieuRutTien.Columns["MaPhieuRut"].HeaderText = "Mã Phiếu Rút";
            dgvDanhSachPhieuRutTien.Columns["MaSoTietKiem"].HeaderText = "Mã Sổ Tiết Kiệm";
            dgvDanhSachPhieuRutTien.Columns["SoTienRut"].HeaderText = "Số Tiền Rút";
            dgvDanhSachPhieuRutTien.Columns["NgayRut"].HeaderText = "Ngày Rút";
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

        //---------------------- Số tiền gửi chỉ nhập số --------------------------
        private void txtSoTienRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //---------------------- Số tiền gửi chỉ nhập số --------------------------


        private void cbMaSoTietKiem_SelectedValueChanged(object sender, EventArgs e)
        {
            String str = SoTietKiem_DAO.LayTenKhachHang(cbMaSoTietKiem.Text);
            txtKhachHang.Text = str;
        }

        private void cbMaSoTietKiem_TextChanged(object sender, EventArgs e)
        {
            String str = SoTietKiem_DAO.LayTenKhachHang(cbMaSoTietKiem.Text);
            txtKhachHang.Text = str;
        }


        //-------------------------- Sự kiện Click vào 1 dòng ------------------------------
        DataGridViewRow drPhieuRutTien;      
        private void dgvDanhSachPhieuRutTien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                drPhieuRutTien = dgvDanhSachPhieuRutTien.SelectedRows[0];
            }
            catch (Exception)
            {
                return;
            }
            if (drPhieuRutTien.Cells["MaPhieuRut"].Value.ToString() != "0001")
            {
                txtMaPhieuRut.Text = drPhieuRutTien.Cells["MaPhieuRut"].Value.ToString();
                cbMaSoTietKiem.Text = drPhieuRutTien.Cells["MaSoTietKiem"].Value.ToString();
                dtpNgayRut.Text = drPhieuRutTien.Cells["NgayRut"].Value.ToString();
                txtSoTienRut.Text = drPhieuRutTien.Cells["SoTienRut"].Value.ToString();
            }
        }
        //-------------------------- Sự kiện Click vào 1 dòng ------------------------------


        private string XacDinhMaPhieuRut()
        {
            if (!ID.Contains(1))
            {
                return TaoMaPhieuRutTien(1);
            }
            else
            {
                for (int i = 0; i < ID.Count - 1; i++)
                {
                    if (ID[i] + 1 != ID[i + 1])
                    {
                        return TaoMaPhieuRutTien((ID[i] + 1));
                    }
                }
                return TaoMaPhieuRutTien((ID[ID.Count - 1] + 1));
            }
        }
        private string TaoMaPhieuRutTien(int MaPGT)
        {
            string s;
            s = MaPGT.ToString();
            while (s.Length < 3)
            {
                s = s.Insert(0, "0");
            }
            s = "PR" + s;
            return s;
        }


        //------------------------------- Lưu phiếu rút ---------------------------------
        private void btnLuuPhieuRutTien_Click(object sender, EventArgs e)
        {
            if (cbMaSoTietKiem.Text == "" || txtSoTienRut.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin ...");
                return;
            }

            LoaiTietKiem_DTO ltk = LoaiTietKiem_DAO.LayLoaiTietKiem(cbMaSoTietKiem.Text);

            PhieuRutTien_DTO phieuRutTien = new PhieuRutTien_DTO();
            BaoCaoNgay_DTO baoCaoNgay = new BaoCaoNgay_DTO();
            BaoCaoThang_DTO baoCaoThang = new BaoCaoThang_DTO();
            

            string str = txtMaPhieuRut.Text;

            if (danhSachPhieuRutTien != null)
            {
                foreach (PhieuRutTien_DTO prt in danhSachPhieuRutTien)
                {
                    if (str == prt.MaPhieuRut)
                    {
                        MessageBox.Show("Phiếu rút tiền đã tồn tại");
                        return;
                    }
                }
            }

            phieuRutTien.MaPhieuRut = XacDinhMaPhieuRut();
            phieuRutTien.MaSoTietKiem = cbMaSoTietKiem.Text;
            phieuRutTien.SoTienRut = int.Parse(txtSoTienRut.Text);
            phieuRutTien.NgayRut = DateTime.ParseExact(dtpNgayRut.Text, "dd-MM-yyyy", new CultureInfo("en-CA"));


            //kiểm tra loại tiết kiệm và xét quy định 3
            if (ltk.MaLoaiTietKiem != "LTK001")
            {
                TimeSpan ts = DateTime.Today - SoTietKiem_DAO.LayNgayMoSoTietKiem(phieuRutTien.MaSoTietKiem);
                if (ts.Days / 30 < ltk.KyHan)
                {
                    MessageBox.Show("Chỉ được rút khi quá kỳ hạn");
                    return;
                }
            }
            else
            {

                DateTime toDay = DateTime.Today;
                TimeSpan time = toDay - SoTietKiem_DAO.LayNgayMoSoTietKiem(phieuRutTien.MaSoTietKiem);
                if (time.Days < ThamSo_DAO.LayThoiGianGuiToiThieu())
                {
                    MessageBox.Show("Chỉ được rút sau khi mở sổ ít nhất " + ThamSo_DAO.LayThoiGianGuiToiThieu() + " ngày");
                    return;
                }
            }

            baoCaoNgay.MaChiTietNgay = XacDinhMaPhieuRut() + "1";
            baoCaoNgay.MaLoaiTietKiem = SoTietKiem_DAO.LayMaLoaiTietKiemTheoSTK(cbMaSoTietKiem.Text);
            baoCaoNgay.TongThu = 0;
            baoCaoNgay.TongChi = int.Parse(txtSoTienRut.Text);
            baoCaoNgay.ChenhLech = baoCaoNgay.TongChi;
            baoCaoNgay.NgayLap = phieuRutTien.NgayRut;

            baoCaoThang.MaSoTietKiem = phieuRutTien.MaSoTietKiem;

            int sodu = SoTietKiem_DAO.LaySoDu(phieuRutTien.MaSoTietKiem);
            //
            if (ltk.MaLoaiTietKiem != "LTK001") phieuRutTien.SoTienRut = sodu;
            //
            if (phieuRutTien.SoTienRut > sodu)
            {
                MessageBox.Show("Số dư không đủ");
                return;
            }    

            if (phieuRutTien.SoTienRut == sodu)
            {
                PhieuRutTien_BUS.CapNhatTrangThaiSo(phieuRutTien);
                BaoCaoThang_BUS.CapNhatTrangThaiSo(baoCaoThang);
                MessageBox.Show("Sổ đóng");
            }

            if (PhieuRutTien_BUS.LuuPhieuRutTien(phieuRutTien) && PhieuRutTien_BUS.CapNhatSoDu(phieuRutTien) && BaoCaoNgay_BUS.ThemChiTietNgay(baoCaoNgay))
            {
                cbMaSoTietKiem.Text = "";
                txtSoTienRut.Text = "";
                LoadPhieuRutTien();
                MessageBox.Show("Lưu thành công");
                return;
            }
            MessageBox.Show("Sổ đã đóng");
        }
        //------------------------------- Lưu phiếu rút ---------------------------------
    }
}
