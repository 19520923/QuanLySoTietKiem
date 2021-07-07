using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SoTietKiem_DTO
    {
        private string maSoTietKiem;
        private string maKhachHang;
        private string maLoaiTietKiem;
        private string tenLoaiTietKiem;
        private DateTime ngayMoSo;
        private int soTienGuiTietKiem;
        private int soLanDaoHan;
        private int tienLai;
        private int soDu;
        private int trangThaiSo;

        public string MaSoTietKiem { get => maSoTietKiem; set => maSoTietKiem = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string MaLoaiTietKiem { get => maLoaiTietKiem; set => maLoaiTietKiem = value; }
        public string TenLoaiTietKiem { get => tenLoaiTietKiem; set => tenLoaiTietKiem = value; }
        public DateTime NgayMoSo { get => ngayMoSo; set => ngayMoSo = value; }
        public int SoTienGuiTietKiem { get => soTienGuiTietKiem; set => soTienGuiTietKiem = value; }
        public int SoLanDaoHan { get => soLanDaoHan; set => soLanDaoHan = value; }
        public int TienLai { get => tienLai; set => tienLai = value; }
        public int SoDu { get => soDu; set => soDu = value; }
        public int TrangThaiSo { get => trangThaiSo; set => trangThaiSo = value; }
    }

   
}
