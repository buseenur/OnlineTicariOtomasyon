using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineTicariOtomasyon.Migrations
{
    /// <inheritdoc />
    public partial class mig_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KargoDetays",
                columns: table => new
                {
                    KargoDetayid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Aciklama = table.Column<string>(type: "Varchar(300)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TakipKodu = table.Column<string>(type: "Varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Personel = table.Column<string>(type: "Varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Alici = table.Column<string>(type: "Varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tarih = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KargoDetays", x => x.KargoDetayid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KargoTakips",
                columns: table => new
                {
                    KargoTakipid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TakipKodu = table.Column<string>(type: "Varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Aciklama = table.Column<string>(type: "Varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TarihZaman = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KargoTakips", x => x.KargoTakipid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KargoDetays");

            migrationBuilder.DropTable(
                name: "KargoTakips");
        }
    }
}
