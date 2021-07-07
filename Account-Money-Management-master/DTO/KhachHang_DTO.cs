using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private string maKhachHang;
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;
        private string soDienThoai;
        private string cmnd;
        private DateTime ngayCap;
        private string noiCap;

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string CMND { get => cmnd; set => cmnd = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }

        public KhachHang_DTO()
        {

        }
    }
}
