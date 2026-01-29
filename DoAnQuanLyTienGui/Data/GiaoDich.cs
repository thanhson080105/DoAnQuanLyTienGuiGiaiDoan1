using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;

namespace DoAnQuanLyTienGui.Data
{
    public class GiaoDich
    {
        public string MaGiaoDich { get; set; }
        public string MaSo { get; set; }
        public DateTime NgayGiaoDich { get; set; }
        public decimal SoTien { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public virtual ObservableCollection<ThongKeChiTiet> ThongKeChiTiet { get; } = new();

        public virtual LoaiGiaoDich LoaiGiaoDich { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
        public virtual KhachHang KhachHang { get; set; } = null!;
    }
}
