using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuuHoangPhi.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Daily : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Daily",
                columns: table => new
                {
                    MaDaiLy = table.Column<string>(type: "TEXT", nullable: false),
                    TenDaiLy = table.Column<string>(type: "TEXT", nullable: false),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: false),
                    NguoiDaiDien = table.Column<string>(type: "TEXT", nullable: false),
                    DienThoai = table.Column<string>(type: "TEXT", nullable: false),
                    MaHTPP = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daily", x => x.MaDaiLy);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Daily");
        }
    }
}
