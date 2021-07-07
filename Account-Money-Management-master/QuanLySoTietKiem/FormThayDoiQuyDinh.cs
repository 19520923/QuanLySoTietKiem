using BUS;
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
    public partial class FormThayDoiQuyDinh : Form
    {
        List<int> ID = new List<int>();
        public FormThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void FormThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            LoadLoaiTietKiem();
        }

        List<LoaiTietKiem_DTO> danhSachLoaiTietKiem;

        private void LoadLoaiTietKiem()
        {
            ID.Clear();
            danhSachLoaiTietKiem = LoaiTietKiem_BUS.LoadLoaiTietKiem();

            if (danhSachLoaiTietKiem != null)
            {
                foreach (LoaiTietKiem_DTO ltk in danhSachLoaiTietKiem)
                {
                    ID.Add(int.Parse(ltk.MaLoaiTietKiem.Substring(3)));
                }
            }

            dgvDanhSachLoaiTietKiem.DataSource = danhSachLoaiTietKiem;

            if (danhSachLoaiTietKiem == null)
                return;

            dgvDanhSachLoaiTietKiem.Columns["MaLoaiTietKiem"].HeaderText = "Mã Loại Tiết Kiệm";
            dgvDanhSachLoaiTietKiem.Columns["TenLoaiTietKiem"].HeaderText = "Tên Loại Tiết Kiệm";
            dgvDanhSachLoaiTietKiem.Columns["KyHan"].HeaderText = "Kỳ Hạn (Tháng)";
            dgvDanhSachLoaiTietKiem.Columns["LaiSuat"].HeaderText = "Lãi Suất (%)";

            for (int i = 0; i < 4; i++) dgvDanhSachLoaiTietKiem.AutoResizeColumn(i);

        }



        //-------------------------- Sự kiện Click vào 1 dòng ------------------------------
        DataGridViewRow drLoaiTietKiem;
        private void dgvDanhSachLoaiTietKiem_Click(object sender, EventArgs e)
        {
            try
            {
                drLoaiTietKiem = dgvDanhSachLoaiTietKiem.SelectedRows[0];
            }
            catch (Exception)
            {
                return;
            }
            if (drLoaiTietKiem.Cells["MaLoaiTietKiem"].Value.ToString() != "0001")
            {
                txtMaLoaiTietKiem.Text = drLoaiTietKiem.Cells["MaLoaiTietKiem"].Value.ToString();
                txtTenLoaiTietKiem.Text = drLoaiTietKiem.Cells["TenLoaiTietKiem"].Value.ToString();
                txtKyHan.Text = drLoaiTietKiem.Cells["KyHan"].Value.ToString();
                txtLaiSuat.Text = drLoaiTietKiem.Cells["LaiSuat"].Value.ToString();
                
            }
        }

        //-------------------------- Sự kiện Click vào 1 dòng ------------------------------


        private string XacDinhMaLoaiTietKiem()
        {
            if (!ID.Contains(1))
            {
                return TaoMaLoaiTietKiem(1);
            }
            else
            {
                for (int i = 0; i < ID.Count - 1; i++)
                {
                    if (ID[i] + 1 != ID[i + 1])
                    {
                        return TaoMaLoaiTietKiem((ID[i] + 1));
                    }
                }
                return TaoMaLoaiTietKiem((ID[ID.Count - 1] + 1));
            }
        }
        private string TaoMaLoaiTietKiem(int MaKH)
        {
            string s;
            s = MaKH.ToString();
            while (s.Length < 3)
            {
                s = s.Insert(0, "0");
            }
            s = "LTK" + s;
            return s;
        }

        //----------------------- Kỳ hạn chỉ nhập số -----------------------
        private void txtKyHan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //---------------------- Kỳ hạn chỉ nhập số  -------------------



        //-------------------------- thêm loại tiết kiệm ------------------------------
        private void btnThemLoaiTietKiem_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiTietKiem.Text == "" || txtKyHan.Text == "" || txtLaiSuat.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin ...");
                return;
            }
            LoaiTietKiem_DTO loaiTietKiem = new LoaiTietKiem_DTO();

            String str = txtMaLoaiTietKiem.Text;

            if (danhSachLoaiTietKiem != null)
            {
                foreach (LoaiTietKiem_DTO ltk in danhSachLoaiTietKiem)
                {
                    if (str == ltk.MaLoaiTietKiem)
                    {
                        MessageBox.Show("Loại tiết kiệm đã tồn tại");
                        return;
                    }
                }
            }

            loaiTietKiem.MaLoaiTietKiem = XacDinhMaLoaiTietKiem();
            loaiTietKiem.TenLoaiTietKiem = txtTenLoaiTietKiem.Text;
            loaiTietKiem.KyHan = int.Parse(txtKyHan.Text);
            loaiTietKiem.LaiSuat = Math.Round(float.Parse(txtLaiSuat.Text),2);

            if (LoaiTietKiem_BUS.ThemLoaiTietKiem(loaiTietKiem))
            {
                txtTenLoaiTietKiem.Text = "";
                txtKyHan.Text = "";
                txtLaiSuat.Text = "";
                LoadLoaiTietKiem();
                MessageBox.Show("Thêm thành công");
                return;
            }
            MessageBox.Show("Thêm thất bại");
        }
        //-------------------------- thêm loại tiết kiệm ------------------------------


        //-------------------------- xóa loại tiết kiệm ------------------------------
        private void btnXoaLoaiTietKiem_Click(object sender, EventArgs e)
        {
            if (drLoaiTietKiem == null)
            {
                MessageBox.Show("Chọn Loại tiết kiệm muốn xóa");
                return;
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LoaiTietKiem_DTO loaiTietKiem = new LoaiTietKiem_DTO();
                loaiTietKiem.MaLoaiTietKiem = drLoaiTietKiem.Cells[0].Value.ToString();
                if (danhSachLoaiTietKiem == null)
                    dgvDanhSachLoaiTietKiem.DataSource = null;
                if (LoaiTietKiem_BUS.XoaLoaiTietKiem(loaiTietKiem))
                {
                    drLoaiTietKiem = null;
                    txtMaLoaiTietKiem.Text = "";
                    txtTenLoaiTietKiem.Text = "";
                    txtKyHan.Text = "";
                    txtLaiSuat.Text = "";                
                    LoadLoaiTietKiem();
                    MessageBox.Show("Xóa thành công");
                    return;
                }
                MessageBox.Show("Xóa thất bại");
            }
        }
        //-------------------------- xóa loại tiết kiệm ------------------------------



        //-------------------------- Sửa loại tiết kiệm ------------------------------
        private void btnSuaLoaiTietKiem_Click(object sender, EventArgs e)
        {
            if (drLoaiTietKiem == null)
            {
                MessageBox.Show("Chọn loại tiết kiệm muốn cập nhật");
                return;
            }

            LoaiTietKiem_DTO loaiTietKiem = new LoaiTietKiem_DTO();
            loaiTietKiem.MaLoaiTietKiem = drLoaiTietKiem.Cells["MaLoaiTietKiem"].Value.ToString();
            loaiTietKiem.TenLoaiTietKiem = txtTenLoaiTietKiem.Text;
            loaiTietKiem.KyHan = int.Parse(txtKyHan.Text);
            loaiTietKiem.LaiSuat = Math.Round(float.Parse(txtLaiSuat.Text),2);

            if (LoaiTietKiem_BUS.SuaLoaiTietKiem(loaiTietKiem))
            {
                drLoaiTietKiem = null;
                txtMaLoaiTietKiem.Text = "";
                txtTenLoaiTietKiem.Text = "";
                txtKyHan.Text = "";
                txtLaiSuat.Text = "";            
                LoadLoaiTietKiem();
                MessageBox.Show("Sửa thành công");
                return;
            }
            MessageBox.Show("Sửa thất bại");
        }
        //-------------------------- Sửa loại tiết kiệm ------------------------------



        private void btnThayDoiTienGuiToiThieu_Click(object sender, EventArgs e)
        {
           if (txtTienGuiToiThieu.Text == "")
           {
                MessageBox.Show("Vui lòng nhập Tien Gui Toi Thieu muốn thay đổi ");
                return;
           }    

            ThamSo_DTO thamSo = new ThamSo_DTO();
            thamSo.TienGuiToiThieu = int.Parse(txtTienGuiToiThieu.Text);

            if (ThamSo_BUS.SuaTienGuiToiThieu(thamSo))
            {
                txtTienGuiToiThieu.Text = "";
                MessageBox.Show("Cập nhật thành công");
                return;
            }
            MessageBox.Show("Cập nhật thất bại");
        }

        private void btnThayDoiTienGuiThemToiThieu_Click(object sender, EventArgs e)
        {
            if (txtTienGuiThemToiThieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tien Gui Thêm Tối Thieu muốn thay đổi ");
                return;
            }

            ThamSo_DTO thamSo = new ThamSo_DTO();
            thamSo.TienGuiThemToiThieu = int.Parse(txtTienGuiThemToiThieu.Text);

            if (ThamSo_BUS.SuaTienGuiThemToiThieu(thamSo))
            {
                txtTienGuiThemToiThieu.Text = "";
                MessageBox.Show("Cập nhật thành công");
                return;
            }
            MessageBox.Show("Cập nhật thất bại");
        }

        private void btnThayTGGuiToiThieu_Click(object sender, EventArgs e)
        {
            if (txtThoiGianGuiToiThieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thời gian tối thiểu muốn thay đổi ");
                return;
            }

            ThamSo_DTO thamSo = new ThamSo_DTO();
            thamSo.ThoiGianGuiToiThieu = int.Parse(txtThoiGianGuiToiThieu.Text);

            if (ThamSo_BUS.SuaThoiGianGuiToiThieu(thamSo))
            {
                txtThoiGianGuiToiThieu.Text = "";
                MessageBox.Show("Cập nhật thành công");
                return;
            }
            MessageBox.Show("Cập nhật thất bại");
        }
    }
}
