using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyTienGui.Data
{
    public class LoaiGiaoDich
    {
        [Key]
        public int Id { get; set; }

        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

        public ICollection<GiaoDich> GiaoDichs { get; set; }
    }


}
