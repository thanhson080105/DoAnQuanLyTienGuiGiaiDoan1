using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyTienGui.Data
{
    public class SoTietKiem
    {
        public string MaSo { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public decimal SoTienGui { get; set; }
        public DateTime NgayGui { get; set; }
        public int KyHan { get; set; } = 0;
        public virtual ObservableCollection<ThongKeChiTiet> ThongKeChiTiet { get; } = new();
        public virtual NhanVien NhanVien { get; set; } = null!;
        public virtual KhachHang KhachHang { get; set; } = null!;
    }
}
