using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuGuiTien_DTO
    {
        private string maPhieuGui;
        private string maSoTietKiem;
        private int soTienGui;
        private DateTime ngayGui;

        public string MaPhieuGui { get => maPhieuGui; set => maPhieuGui = value; }
        public string MaSoTietKiem { get => maSoTietKiem; set => maSoTietKiem = value; }
        public int SoTienGui { get => soTienGui; set => soTienGui = value; }
        public DateTime NgayGui { get => ngayGui; set => ngayGui = value; }
    }
}
