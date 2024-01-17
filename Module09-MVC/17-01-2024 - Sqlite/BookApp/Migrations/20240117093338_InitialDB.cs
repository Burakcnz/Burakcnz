using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => new { x.BookID, x.CategoryID });
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Abstract = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    URL = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: false),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    PageCount = table.Column<int>(type: "INTEGER", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "getdate()"),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "getdate()"),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    URL = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "getdate()"),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "getdate()"),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookID", "CategoryID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 2, 5 },
                    { 3, 2 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 3 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 4 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "Abstract", "CreatedDate", "ImageURL", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "PageCount", "Price", "Stock", "URL" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(7258), "ogrenci-kiz-1.png", true, false, true, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(7260), "Öğrenci Kız", 99, 145m, 120, "ogrenci-kiz-1" },
                    { 2, "", new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(7269), "homo-deus-2.png", true, false, true, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(7270), "Homo Deus", 299, 215m, 20, "homo-deus-2" },
                    { 3, "", new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(7272), "efendi-uyaniyor-3.png", true, false, false, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(7272), "Efendi Uyanıyor", 316, 185m, 78, "efendi-uyaniyor-3" },
                    { 4, "", new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(7274), "evrenin-sonundaki-restoran-3.png", true, false, true, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(7274), "Evrenin Sonundaki Restoran", 149, 153m, 76, "evrenin-sonundaki-restoran" },
                    { 5, "", new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(7275), "beyaz-kurt-5.png", true, false, true, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(7276), "Beyaz Kurt", 123, 223m, 156, "beyaz-kurt" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "URL" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(6172), "Genel kategorisine sahip ve kategorisiz kitaplar burada olacak", true, false, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(6185), "Genel", "genel" },
                    { 2, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(6188), "Bilim kurgu kitapları", true, false, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(6189), "Bilim Kurgu", "bilim-kurgu" },
                    { 3, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(6190), "Distopik kitaplar", true, false, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(6190), "Distopya", "distopya" },
                    { 4, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(6191), "Bilim ve Mühendislik Kitapları", true, false, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(6192), "Bilim Ve Mühendislik", "bilim-ve-muhendislik" },
                    { 5, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(6192), "Dünya tarihi ile ilgili kitaplar", true, false, new DateTime(2024, 1, 17, 12, 33, 38, 718, DateTimeKind.Local).AddTicks(6193), "Dünya Tarihi", "dunya-tarihi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
