using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;
using System.Globalization;

namespace QuanLySoTietKiem
{
    public partial class FormLapPhieuGui : Form
    {
        List<int> ID = new List<int>();
        public FormLapPhieuGui()
        {
            InitializeComponent();
        }

        private void FormLapPhieuGui_Load(object sender, EventArgs e)
        {
            LoadMaSoTietKiem();
            LoadPhieuGuiTien();
            
        }

        List<PhieuGuiTien_DTO> danhSachPhieuGuiTien;
        private void LoadPhieuGuiTien()
        {
            ID.Clear();
            danhSachPhieuGuiTien = PhieuGuiTien_BUS.LoadPhieuGuiTien();

            if (danhSachPhieuGuiTien != null)
            {
                foreach (PhieuGuiTien_DTO pgt in danhSachPhieuGuiTien)
                {
                    ID.Add(int.Parse(pgt.MaPhieuGui.Substring(2)));
                }
            }

           

            if (danhSachPhieuGuiTien == null)
            {
                danhSachPhieuGuiTien = new List<PhieuGuiTien_DTO>();
            }

            dgvDanhSachPhieuGuiTien.DataSource = danhSachPhieuGuiTien;
            txtMaPhieuGui.Text = TaoMaPhieuGuiTien(danhSachPhieuGuiTien.Count + 1);

            dgvDanhSachPhieuGuiTien.Columns["MaPhieuGui"].HeaderText = "Mã Phiếu Gửi";
            dgvDanhSachPhieuGuiTien.Columns["MaSoTietKiem"].HeaderText = "Mã Sổ Tiết Kiệm";
            dgvDanhSachPhieuGuiTien.Columns["SoTienGui"].HeaderText = "Số tiền gửi";
            dgvDanhSachPhieuGuiTien.Columns["NgayGui"].HeaderText = "Ngày Gửi";           
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



        //---------------------- Số tiền gửi chỉ nhập số --------------------------
        private void txtSoTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //----------------------  Số tiền gửi chỉ nhập số  -------------------------



        //-------------------------- Sự kiện Click vào 1 dòng ------------------------------
        DataGridViewRow drPhieuGuiTien;
        private void dgvDanhSachPhieuGuiTien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                drPhieuGuiTien = dgvDanhSachPhieuGuiTien.SelectedRows[0];
            }
            catch (Exception)
            {
                return;
            }
            if (drPhieuGuiTien.Cells["MaPhieuGui"].Value.ToString() != "0001")
            {
                txtMaPhieuGui.Text = drPhieuGuiTien.Cells["MaPhieuGui"].Value.ToString();
                cbMaSoTietKiem.Text = drPhieuGuiTien.Cells["MaSoTietKiem"].Value.ToString();
                dtpNgayGui.Text = drPhieuGuiTien.Cells["NgayGui"].Value.ToString();
                txtSoTienGui.Text = drPhieuGuiTien.Cells["SoTienGui"].Value.ToString();
            }
        }
        //-------------------------- Sự kiện Click vào 1 dòng ------------------------------


        private string XacDinhMaPhieuGui()
        {
            if (!ID.Contains(1))
            {
                return TaoMaPhieuGuiTien(1);
            }
            else
            {
                for (int i = 0; i < ID.Count - 1; i++)
                {
                    if (ID[i] + 1 != ID[i + 1])
                    {
                        return TaoMaPhieuGuiTien((ID[i] + 1));
                    }
                }
                return TaoMaPhieuGuiTien((ID[ID.Count - 1] + 1));
            }
        }
        private string TaoMaPhieuGuiTien(int MaPGT)
        {
            string s;
            s = MaPGT.ToString();
            while (s.Length < 3)
            {
                s = s.Insert(0, "0");
            }
            s = "PG" + s;
            return s;
        }



        //------------------------------- Lưu phiếu gửi ---------------------------------
        private void btnLuuPhieuGuiTien_Click(object sender, EventArgs e)
        {
            if (cbMaSoTietKiem.Text == "" || txtSoTienGui.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin ...");
                return;
            }

            if (SoTietKiem_DAO.LayMaLoaiTietKiemTheoSTK(cbMaSoTietKiem.Text) != "LTK001")
            {
                MessageBox.Show("Chỉ được gửi với sổ tiết kiệm không kỳ hạn");
                return;
            }

            PhieuGuiTien_DTO phieuGuiTien = new PhieuGuiTien_DTO();
            BaoCaoNgay_DTO chiTietBaoCao = new BaoCaoNgay_DTO();

            String str = txtMaPhieuGui.Text;

            if (danhSachPhieuGuiTien != null)
            {
                foreach (PhieuGuiTien_DTO pgt in danhSachPhieuGuiTien)
                {
                    if (str == pgt.MaPhieuGui)
                    {
                        MessageBox.Show("Phiếu gửi tiền đã tồn tại");
                        return;
                    }
                }
            }

            phieuGuiTien.MaPhieuGui = XacDinhMaPhieuGui();
            phieuGuiTien.MaSoTietKiem = cbMaSoTietKiem.Text;
            phieuGuiTien.SoTienGui = int.Parse(txtSoTienGui.Text);
            phieuGuiTien.NgayGui = DateTime.ParseExact(dtpNgayGui.Text, "dd-MM-yyyy", new CultureInfo("en-CA"));

            if (phieuGuiTien.SoTienGui < ThamSo_DAO.LaySoTienGuiThemToiThieu())
            {
                MessageBox.Show("Tiền gửi thêm tối thiểu phải là " +ThamSo_DAO.LaySoTienGuiThemToiThieu());
                return;
            }    

            chiTietBaoCao.MaChiTietNgay = XacDinhMaPhieuGui() +"1";
            chiTietBaoCao.MaLoaiTietKiem = SoTietKiem_DAO.LayMaLoaiTietKiemTheoSTK(cbMaSoTietKiem.Text);
            chiTietBaoCao.TongThu = int.Parse(txtSoTienGui.Text);
            chiTietBaoCao.TongChi = 0;
            chiTietBaoCao.ChenhLech = chiTietBaoCao.TongThu;
            chiTietBaoCao.NgayLap = phieuGuiTien.NgayGui;



            int trangthaiso = SoTietKiem_DAO.LayTrangThaiSo(phieuGuiTien.MaSoTietKiem);
            if (trangthaiso == 1)
            {
                MessageBox.Show("Sổ đã đóng không thể gửi");
                return;
            }

            if (PhieuGuiTien_BUS.LuuPhieuGuiTien(phieuGuiTien) && PhieuGuiTien_BUS.CapNhatSoDu(phieuGuiTien) && BaoCaoNgay_BUS.ThemChiTietNgay(chiTietBaoCao))
            {
                cbMaSoTietKiem.Text = "";
                txtSoTienGui.Text = "";
                LoadPhieuGuiTien();
                MessageBox.Show("Lưu thành công");
                return;
            } 
            MessageBox.Show("Lưu Thất bại");
        }
        //------------------------------- Lưu phiếu gửi ---------------------------------
    }
}
