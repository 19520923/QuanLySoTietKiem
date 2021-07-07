using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoThang_DTO
    {
        private string maChiTietThang;
        private DateTime ngayMoSo;
        private string maSoTietKiem;
        private string maLoaiTietKiem;
        private int soMo;
        private int soDong;
        private int chenhLech;       

        public string MaChiTietThang { get => maChiTietThang; set => maChiTietThang = value; }
        public DateTime NgayMoSo { get => ngayMoSo; set => ngayMoSo = value; }
        public string MaSoTietKiem { get => maSoTietKiem; set => maSoTietKiem = value; }
        public string MaLoaiTietKiem { get => maLoaiTietKiem; set => maLoaiTietKiem = value; }
        public int SoMo { get => soMo; set => soMo = value; }
        public int SoDong { get => soDong; set => soDong = value; }
        public int ChenhLech { get => chenhLech; set => chenhLech = value; }
    }
}
