using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiTietKiem_DTO
    {
        private string maLoaiTietKiem;
        private string tenLoaiTietKiem;
        private int kyHan;
        private double laiSuat;

        public string MaLoaiTietKiem { get => maLoaiTietKiem; set => maLoaiTietKiem = value; }
        public string TenLoaiTietKiem { get => tenLoaiTietKiem; set => tenLoaiTietKiem = value; }
        public int KyHan { get => kyHan; set => kyHan = value; }
        public double LaiSuat { get => laiSuat; set => laiSuat = value; }
    }
}
