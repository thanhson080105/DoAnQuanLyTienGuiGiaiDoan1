using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyTienGui.Data
{
    public class LoaiGiaoDich
    {
        public int MaGiaoDich { get; set; }
        public string LoaiGD { get; set; }


        public virtual ObservableCollection<GiaoDich> GiaoDich { get; } = new();
        public virtual ObservableCollection<ThongKeChiTiet> ThongKeChiTiet { get; } = new();
    }
}
