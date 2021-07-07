using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThamSo_DTO
    {
        private int tienGuiToiThieu;
        private int tienGuiThemToiThieu;
        private int thoiGianGuiToiThieu;

        public int TienGuiToiThieu { get => tienGuiToiThieu; set => tienGuiToiThieu = value; }
        public int TienGuiThemToiThieu { get => tienGuiThemToiThieu; set => tienGuiThemToiThieu = value; }
        public int ThoiGianGuiToiThieu { get => thoiGianGuiToiThieu; set => thoiGianGuiToiThieu = value; }
    }
}
