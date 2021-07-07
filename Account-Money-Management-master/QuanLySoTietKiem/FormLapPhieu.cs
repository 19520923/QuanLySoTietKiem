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

    public partial class FormLapPhieu : Form
    {
        public FormLapPhieu()
        {
            InitializeComponent();
        }

        private void btnLapPhieuGui_Click(object sender, EventArgs e)
        {
            containerLapPhieu.Controls.Clear();
            FormLapPhieuGui frmLapPhieuGui = new FormLapPhieuGui();
            frmLapPhieuGui.TopLevel = false;
            containerLapPhieu.Controls.Add(frmLapPhieuGui);
            frmLapPhieuGui.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmLapPhieuGui.AutoScroll = true;
            frmLapPhieuGui.Dock = DockStyle.Fill;
            frmLapPhieuGui.Show();
        }

        private void containerLapPhieu_Paint(object sender, PaintEventArgs e)
        {
            containerLapPhieu.Controls.Clear();
            FormLapPhieuGui frmLapPhieuGui = new FormLapPhieuGui();
            frmLapPhieuGui.TopLevel = false;
            containerLapPhieu.Controls.Add(frmLapPhieuGui);
            frmLapPhieuGui.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmLapPhieuGui.AutoScroll = true;
            frmLapPhieuGui.Dock = DockStyle.Fill;
            frmLapPhieuGui.Show();
        }

        private void btnLapPhieuRut_Click(object sender, EventArgs e)
        {
            containerLapPhieu.Controls.Clear();
            FormLapPhieuRut frmLapPhieuRut = new FormLapPhieuRut();
            frmLapPhieuRut.TopLevel = false;
            containerLapPhieu.Controls.Add(frmLapPhieuRut);
            frmLapPhieuRut.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmLapPhieuRut.AutoScroll = true;
            frmLapPhieuRut.Dock = DockStyle.Fill;
            frmLapPhieuRut.Show();
        }
    }
}
