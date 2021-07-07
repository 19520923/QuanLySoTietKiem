using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoNgay_DTO
    {
        private string maChiTietNgay;
        private string maLoaiTietKiem;
        private int tongThu;
        private int tongChi;
        private int chenhLech;
        private DateTime ngayLap;

        public string MaChiTietNgay { get => maChiTietNgay; set => maChiTietNgay = value; }
        public string MaLoaiTietKiem { get => maLoaiTietKiem; set => maLoaiTietKiem = value; }
        public int TongThu { get => tongThu; set => tongThu = value; }
        public int TongChi { get => tongChi; set => tongChi = value; }
        public int ChenhLech { get => chenhLech; set => chenhLech = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
    }
}
