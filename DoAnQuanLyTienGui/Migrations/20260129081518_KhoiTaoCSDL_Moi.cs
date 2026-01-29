using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnQuanLyTienGui.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL_Moi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "LoaiGiaoDich",
                columns: table => new
                {
                    MaGiaoDich = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiGD = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiGiaoDich", x => x.MaGiaoDich);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenDangNhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "GiaoDich",
                columns: table => new
                {
                    MaGiaoDich = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaSo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayGiaoDich = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiGiaoDichMaGiaoDich = table.Column<int>(type: "int", nullable: false),
                    NhanVienMaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KhachHangMaKH = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoDich", x => x.MaGiaoDich);
                    table.ForeignKey(
                        name: "FK_GiaoDich_KhachHang_KhachHangMaKH",
                        column: x => x.KhachHangMaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH");
                    table.ForeignKey(
                        name: "FK_GiaoDich_LoaiGiaoDich_LoaiGiaoDichMaGiaoDich",
                        column: x => x.LoaiGiaoDichMaGiaoDich,
                        principalTable: "LoaiGiaoDich",
                        principalColumn: "MaGiaoDich");
                    table.ForeignKey(
                        name: "FK_GiaoDich_NhanVien_NhanVienMaNV",
                        column: x => x.NhanVienMaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV");
                });

            migrationBuilder.CreateTable(
                name: "SoTietKiem",
                columns: table => new
                {
                    MaSo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTienGui = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayGui = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KyHan = table.Column<int>(type: "int", nullable: false),
                    NhanVienMaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KhachHangMaKH = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoTietKiem", x => x.MaSo);
                    table.ForeignKey(
                        name: "FK_SoTietKiem_KhachHang_KhachHangMaKH",
                        column: x => x.KhachHangMaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH");
                    table.ForeignKey(
                        name: "FK_SoTietKiem_NhanVien_NhanVienMaNV",
                        column: x => x.NhanVienMaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV");
                });

            migrationBuilder.CreateTable(
                name: "ThongKeChiTiet",
                columns: table => new
                {
                    MaSo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTienGui = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayGui = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KyHan = table.Column<int>(type: "int", nullable: false),
                    MaGiaoDich = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayGiaoDich = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiGD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhanVienMaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GiaoDichMaGiaoDich = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KhachHangMaKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoTietKiemMaSo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoaiGiaoDichMaGiaoDich = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ThongKeChiTiet_GiaoDich_GiaoDichMaGiaoDich",
                        column: x => x.GiaoDichMaGiaoDich,
                        principalTable: "GiaoDich",
                        principalColumn: "MaGiaoDich");
                    table.ForeignKey(
                        name: "FK_ThongKeChiTiet_KhachHang_KhachHangMaKH",
                        column: x => x.KhachHangMaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH");
                    table.ForeignKey(
                        name: "FK_ThongKeChiTiet_LoaiGiaoDich_LoaiGiaoDichMaGiaoDich",
                        column: x => x.LoaiGiaoDichMaGiaoDich,
                        principalTable: "LoaiGiaoDich",
                        principalColumn: "MaGiaoDich");
                    table.ForeignKey(
                        name: "FK_ThongKeChiTiet_NhanVien_NhanVienMaNV",
                        column: x => x.NhanVienMaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV");
                    table.ForeignKey(
                        name: "FK_ThongKeChiTiet_SoTietKiem_SoTietKiemMaSo",
                        column: x => x.SoTietKiemMaSo,
                        principalTable: "SoTietKiem",
                        principalColumn: "MaSo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GiaoDich_KhachHangMaKH",
                table: "GiaoDich",
                column: "KhachHangMaKH");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoDich_LoaiGiaoDichMaGiaoDich",
                table: "GiaoDich",
                column: "LoaiGiaoDichMaGiaoDich");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoDich_NhanVienMaNV",
                table: "GiaoDich",
                column: "NhanVienMaNV");

            migrationBuilder.CreateIndex(
                name: "IX_SoTietKiem_KhachHangMaKH",
                table: "SoTietKiem",
                column: "KhachHangMaKH");

            migrationBuilder.CreateIndex(
                name: "IX_SoTietKiem_NhanVienMaNV",
                table: "SoTietKiem",
                column: "NhanVienMaNV");

            migrationBuilder.CreateIndex(
                name: "IX_ThongKeChiTiet_GiaoDichMaGiaoDich",
                table: "ThongKeChiTiet",
                column: "GiaoDichMaGiaoDich");

            migrationBuilder.CreateIndex(
                name: "IX_ThongKeChiTiet_KhachHangMaKH",
                table: "ThongKeChiTiet",
                column: "KhachHangMaKH");

            migrationBuilder.CreateIndex(
                name: "IX_ThongKeChiTiet_LoaiGiaoDichMaGiaoDich",
                table: "ThongKeChiTiet",
                column: "LoaiGiaoDichMaGiaoDich");

            migrationBuilder.CreateIndex(
                name: "IX_ThongKeChiTiet_NhanVienMaNV",
                table: "ThongKeChiTiet",
                column: "NhanVienMaNV");

            migrationBuilder.CreateIndex(
                name: "IX_ThongKeChiTiet_SoTietKiemMaSo",
                table: "ThongKeChiTiet",
                column: "SoTietKiemMaSo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThongKeChiTiet");

            migrationBuilder.DropTable(
                name: "GiaoDich");

            migrationBuilder.DropTable(
                name: "SoTietKiem");

            migrationBuilder.DropTable(
                name: "LoaiGiaoDich");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
