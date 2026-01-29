using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DoAnQuanLyTienGui.Data
{
    public class QLTGDbcontext : DbContext
    {
        public DbSet<LoaiGiaoDich> LoaiGiaoDich { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<GiaoDich> GiaoDich { get; set; }
        public DbSet<SoTietKiem> SoTietKiem { get; set; }
        public DbSet<ThongKeChiTiet> ThongKeChiTiet { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLTienGuiConnection"].ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // --- 1. Cấu hình Khóa Chính ---
            modelBuilder.Entity<LoaiGiaoDich>().HasKey(l => l.MaGiaoDich);
            modelBuilder.Entity<KhachHang>().HasKey(k => k.MaKH);
            modelBuilder.Entity<NhanVien>().HasKey(n => n.MaNV);
            modelBuilder.Entity<GiaoDich>().HasKey(g => g.MaGiaoDich);
            modelBuilder.Entity<SoTietKiem>().HasKey(s => s.MaSo);
            modelBuilder.Entity<ThongKeChiTiet>().HasNoKey();

            // --- 2. Loại bỏ các thuộc tính gây lỗi (Ignore) ---
            // Sửa lỗi cho LoaiGiaoDich (Lỗi bạn vừa gặp)
            modelBuilder.Entity<LoaiGiaoDich>().Ignore(l => l.ThongKeChiTiet);

            // Sửa lỗi cho KhachHang và GiaoDich (Các lỗi trước đó)
            modelBuilder.Entity<KhachHang>().Ignore(k => k.ThongKeChiTiet);
            modelBuilder.Entity<GiaoDich>().Ignore(g => g.ThongKeChiTiet);

            // Phòng hờ lỗi cho NhanVien và SoTietKiem nếu chúng cũng có thuộc tính này
            modelBuilder.Entity<NhanVien>().Ignore(n => n.ThongKeChiTiet);
            modelBuilder.Entity<SoTietKiem>().Ignore(s => s.ThongKeChiTiet);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}

