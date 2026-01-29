using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyTienGui.Data
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string ChucVu { get; set; }
        public string SoDienThoai { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public virtual ObservableCollection<GiaoDich>  GiaoDich { get; } = new();
        public virtual ObservableCollection< SoTietKiem> SoTietKiem { get; } = new();
        public virtual ObservableCollection<ThongKeChiTiet> ThongKeChiTiet { get; } = new();

    }
}
