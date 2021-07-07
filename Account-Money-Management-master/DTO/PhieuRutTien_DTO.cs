using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuRutTien_DTO
    {
        private string maPhieuRut;
        private string maSoTietKiem;
        private int soTienRut;
        private DateTime ngayRut;

        public string MaPhieuRut { get => maPhieuRut; set => maPhieuRut = value; }
        public string MaSoTietKiem { get => maSoTietKiem; set => maSoTietKiem = value; }
        public int SoTienRut { get => soTienRut; set => soTienRut = value; }
        public DateTime NgayRut { get => ngayRut; set => ngayRut = value; }
    }
}
