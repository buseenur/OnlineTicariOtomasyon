using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineTicariOtomasyon.Migrations
{
    /// <inheritdoc />
    public partial class mig_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Saat",
                table: "Faturalars",
                type: "Char(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<decimal>(
                name: "Toplam",
                table: "Faturalars",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Toplam",
                table: "Faturalars");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Saat",
                table: "Faturalars",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Char(5)",
                oldMaxLength: 5)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
