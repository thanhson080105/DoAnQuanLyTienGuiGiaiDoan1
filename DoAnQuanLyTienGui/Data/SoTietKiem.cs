using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyTienGui.Data
{
    public class SoTietKiem
    {
        [Key]
        public int Id { get; set; }         // Khóa chính

        public string MaSo { get; set; }
        public DateTime NgayMoSo { get; set; }
        public decimal SoDu { get; set; }
        public decimal LaiSuat { get; set; }
        public int KyHan { get; set; }

        public int KhachHangId { get; set; }
        public KhachHang KhachHang { get; set; }

        public ICollection<GiaoDich> GiaoDichs { get; set; }
    }


}
