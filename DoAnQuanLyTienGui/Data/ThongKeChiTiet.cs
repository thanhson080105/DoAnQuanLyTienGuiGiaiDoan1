using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyTienGui.Data
{
    public class ThongKeChiTiet
    {
        public string MaSo { get; set; }
        public string MaKH { get; set; }
        public decimal SoTienGui { get; set; }
        public DateTime NgayGui { get; set; }
        public int KyHan { get; set; }
        public string MaGiaoDich { get; set; }
        public DateTime NgayGiaoDich { get; set; }
        public decimal SoTien { get; set; }
        public string MaNV { get; set; }
        public string LoaiGD { get; set; }


        public virtual NhanVien NhanVien { get; set; } = null!;
        public virtual GiaoDich GiaoDich { get; set; } = null!;
        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual SoTietKiem SoTietKiem { get; set; } = null!;
        public virtual LoaiGiaoDich LoaiGiaoDich { get; set; } = null!;

    }
}
