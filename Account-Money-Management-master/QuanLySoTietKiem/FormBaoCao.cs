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
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void btnBaoCaoNgay_Click(object sender, EventArgs e)
        {
            containerBaoCao.Controls.Clear();
            FormBaoCaoNgay frmBaoCaoNgay = new FormBaoCaoNgay();
            frmBaoCaoNgay.TopLevel = false;
            containerBaoCao.Controls.Add(frmBaoCaoNgay);
            frmBaoCaoNgay.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmBaoCaoNgay.AutoScroll = true;
            frmBaoCaoNgay.Dock = DockStyle.Fill;
            frmBaoCaoNgay.Show();
        }

        private void btnBaoCaoThang_Click(object sender, EventArgs e)
        {
            containerBaoCao.Controls.Clear();
            FormBaoCaoThang frmBaoCaoThang = new FormBaoCaoThang();
            frmBaoCaoThang.TopLevel = false;
            containerBaoCao.Controls.Add(frmBaoCaoThang);
            frmBaoCaoThang.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmBaoCaoThang.AutoScroll = true;
            frmBaoCaoThang.Dock = DockStyle.Fill;
            frmBaoCaoThang.Show();
        }

        private void containerBaoCao_Paint(object sender, PaintEventArgs e)
        {
            containerBaoCao.Controls.Clear();
            FormBaoCaoNgay frmBaoCaoNgay = new FormBaoCaoNgay();
            frmBaoCaoNgay.TopLevel = false;
            containerBaoCao.Controls.Add(frmBaoCaoNgay);
            frmBaoCaoNgay.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmBaoCaoNgay.AutoScroll = true;
            frmBaoCaoNgay.Dock = DockStyle.Fill;
            frmBaoCaoNgay.Show();
        }
    }
}
