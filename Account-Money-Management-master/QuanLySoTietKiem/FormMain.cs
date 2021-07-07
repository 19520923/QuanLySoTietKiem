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
    public partial class FormMain : Form
    {
        string TaiKhoangDN;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(string TKDN)
        {
            TaiKhoangDN = TKDN;
            InitializeComponent();
        }

        private void btnLapSoTietKiem_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            FormLapSoTietKiem frmLapSTK = new FormLapSoTietKiem();
            frmLapSTK.TopLevel = false;
            container.Controls.Add(frmLapSTK);
            frmLapSTK.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmLapSTK.AutoScroll = true;
            frmLapSTK.Dock = DockStyle.Fill;
            frmLapSTK.Show();
        }

        public void btnThongTinKhachHang_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            FormThongTinKhachHang frmThongTinKH = new FormThongTinKhachHang();
            frmThongTinKH.TopLevel = false;
            container.Controls.Add(frmThongTinKH);
            frmThongTinKH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmThongTinKH.AutoScroll = true;
            frmThongTinKH.Dock = DockStyle.Fill;
            frmThongTinKH.Show();
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            FormLapPhieu frmLapPhieu = new FormLapPhieu();
            frmLapPhieu.TopLevel = false;
            container.Controls.Add(frmLapPhieu);
            frmLapPhieu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmLapPhieu.AutoScroll = true;
            frmLapPhieu.Dock = DockStyle.Fill;
            frmLapPhieu.Show();
        }

        private void btnTraCuuSo_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            FormTraCuuSo frmTraCuuSo = new FormTraCuuSo();
            frmTraCuuSo.TopLevel = false;
            container.Controls.Add(frmTraCuuSo);
            frmTraCuuSo.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmTraCuuSo.AutoScroll = true;
            frmTraCuuSo.Dock = DockStyle.Fill;
            frmTraCuuSo.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            FormBaoCao frmBaoCao = new FormBaoCao();
            frmBaoCao.TopLevel = false;
            container.Controls.Add(frmBaoCao);
            frmBaoCao.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmBaoCao.AutoScroll = true;
            frmBaoCao.Dock = DockStyle.Fill;
            frmBaoCao.Show();
        }

        private void btnThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            FormThayDoiQuyDinh frmThayDoiQuyDinh = new FormThayDoiQuyDinh();
            frmThayDoiQuyDinh.TopLevel = false;
            container.Controls.Add(frmThayDoiQuyDinh);
            frmThayDoiQuyDinh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmThayDoiQuyDinh.AutoScroll = true;
            frmThayDoiQuyDinh.Dock = DockStyle.Fill;
            frmThayDoiQuyDinh.Show();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            FormThongTin frmThongTin = new FormThongTin();
            frmThongTin.TopLevel = false;
            container.Controls.Add(frmThongTin);
            frmThongTin.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmThongTin.AutoScroll = true;
            frmThongTin.Dock = DockStyle.Fill;
            frmThongTin.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

    }
}
