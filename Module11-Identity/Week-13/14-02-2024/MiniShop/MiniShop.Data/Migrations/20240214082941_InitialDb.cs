using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    Price = table.Column<decimal>(type: "real", nullable: false),
                    Properties = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0bb499c3-c88e-486f-9d72-4877c330256f", null, "Tüm yönetici yetkilerine sahip kullanıcıların rolü", "SuperAdmin", "SUPERADMIN" },
                    { "1d3c23a7-f284-443d-bff8-d491aec1cfec", null, "Sınırlı yönetici yetkilerine sahip kullanıcıların rolü", "Admin", "ADMIN" },
                    { "e50229d4-4a9f-422e-aa78-cf8b020b68d1", null, "Müşteri tipindeki kullanıcıların rolü", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "CreatedDate", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "71bbf388-ce4b-499b-916b-bc53c773dea4", 0, "Rasimpaşa Mh. Hancı Sk. No:4 Kadıköy", "İstanbul", "7cf952f7-5f08-459d-8620-8542f255a9f3", new DateTime(2024, 2, 14, 11, 29, 40, 851, DateTimeKind.Local).AddTicks(1992), new DateTime(1990, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Kadın", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAEJoLrEDf8ORHq9GRRLiCbhmh89BCFX85PQtfOlywxTiuEZrm5QQ3fF+ozGkNa3b6Dw==", "555-444-55-44", false, "da4030b7-e7ce-493c-87ca-82b07d16e3dc", false, "superadmin" },
                    { "87db35bb-eae1-4953-81e7-2c33b8ce462a", 0, "Rasimpaşa Mh. Hancı Sk. No:4 Kadıköy", "İstanbul", "297976e7-25ea-4d16-88c2-dd52d1ef9a39", new DateTime(2024, 2, 14, 11, 29, 40, 851, DateTimeKind.Local).AddTicks(2043), new DateTime(1993, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAENWE8qaY7iSt+aRI0Lk4GqByMSjBr7Z9P28enwSrGT1mmP3IHmNMzRHXdWOfXLQqMw==", "555-444-55-44", false, "ff62d9b7-1426-4b44-b351-345600a5d253", false, "admin" },
                    { "8c7aa113-fab9-4a80-9d57-c0215fd8210f", 0, "Rasimpaşa Mh. Hancı Sk. No:4 Kadıköy", "İstanbul", "66793806-f81b-47df-b825-027131d3a7f5", new DateTime(2024, 2, 14, 11, 29, 40, 851, DateTimeKind.Local).AddTicks(2058), new DateTime(1988, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "CUSTOMER", "AQAAAAIAAYagAAAAEDqalEb1BpHhrZiApKOcnsNUQOvOLZ9R6PNOObyAL/OXjCDgTic4ch+4V+UHcsvQsQ==", "555-444-55-44", false, "0a0b3f70-f28e-4afc-81c3-3bb526c92156", false, "customer" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 14, 11, 29, 41, 83, DateTimeKind.Local).AddTicks(1836), "TV kategorisi", true, false, new DateTime(2024, 2, 14, 11, 29, 41, 83, DateTimeKind.Local).AddTicks(1869), "Televizyon", "televizyon" },
                    { 2, new DateTime(2024, 2, 14, 11, 29, 41, 83, DateTimeKind.Local).AddTicks(1874), "Bilgisayar kategorisi", true, false, new DateTime(2024, 2, 14, 11, 29, 41, 83, DateTimeKind.Local).AddTicks(1875), "Bilgisayar", "bilgisayar" },
                    { 3, new DateTime(2024, 2, 14, 11, 29, 41, 83, DateTimeKind.Local).AddTicks(1876), "Elektronik Eşya kategorisi", true, false, new DateTime(2024, 2, 14, 11, 29, 41, 83, DateTimeKind.Local).AddTicks(1876), "Elektronik Eşya", "elektronik-esya" },
                    { 4, new DateTime(2024, 2, 14, 11, 29, 41, 83, DateTimeKind.Local).AddTicks(1878), "Beyaz Eşya kategorisi", true, false, new DateTime(2024, 2, 14, 11, 29, 41, 83, DateTimeKind.Local).AddTicks(1878), "Beyaz Eşya", "beyaz-esya" },
                    { 5, new DateTime(2024, 2, 14, 11, 29, 41, 83, DateTimeKind.Local).AddTicks(1879), "Telefon kategorisi", true, false, new DateTime(2024, 2, 14, 11, 29, 41, 83, DateTimeKind.Local).AddTicks(1880), "Telefon", "telefon" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Properties", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(574), "1.png", true, false, true, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(585), "IPhone 14", 59000m, "Harika bir telefon", "iphone-14" },
                    { 2, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(596), "2.png", true, false, false, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(597), "IPhone 14 Pro", 69000m, "Bu da harika bir telefon", "iphone-14-pro" },
                    { 3, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(599), "3.png", true, false, true, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(599), "Samsung S23", 49000m, "İdare eder", "samsung-s23" },
                    { 4, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(601), "4.png", true, false, true, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(601), "Xaomi Note 4", 39000m, "Harika bir telefon", "xaomi-note-4" },
                    { 5, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(603), "5.png", true, false, true, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(603), "MacBook Air M2", 52000m, "M2nin gücü", "macbook-air-m2" },
                    { 6, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(605), "6.png", true, false, false, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(605), "MacBook Pro M3", 79000m, "16 Gb ram", "macbook-pro-m3" },
                    { 7, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(606), "7.png", true, false, true, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(607), "Vestel Çamaşır Makinesi X65", 19000m, "Akıllı makine", "vestel-camasir-makinesi-x65" },
                    { 8, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(608), "8.png", true, false, false, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(609), "Arçelik Çamaşır Makinesi A-4", 21000m, "Süper hızlı makine", "arcelik-camasir-makinesi-a-4" },
                    { 9, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(610), "9.png", true, false, true, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(611), "Hoop Dijital Radyo X96", 1250m, "Klasik radyo keyfi", "hoop-dijital-radyo-x96" },
                    { 10, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(612), "10.png", true, false, true, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(621), "Xaomi Dijital Baskül", 2100m, "Kilonuzu kontrol edin", "xaomi-dijital-baskul" },
                    { 11, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(640), "11.png", true, false, true, new DateTime(2024, 2, 14, 11, 29, 41, 84, DateTimeKind.Local).AddTicks(641), "Blaupunkt AC69 Led TV", 9800m, "Android tv", "blaupunkt-ac69-led-tv" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0bb499c3-c88e-486f-9d72-4877c330256f", "71bbf388-ce4b-499b-916b-bc53c773dea4" },
                    { "1d3c23a7-f284-443d-bff8-d491aec1cfec", "87db35bb-eae1-4953-81e7-2c33b8ce462a" },
                    { "e50229d4-4a9f-422e-aa78-cf8b020b68d1", "87db35bb-eae1-4953-81e7-2c33b8ce462a" },
                    { "e50229d4-4a9f-422e-aa78-cf8b020b68d1", "8c7aa113-fab9-4a80-9d57-c0215fd8210f" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 5, 1 },
                    { 3, 2 },
                    { 5, 2 },
                    { 3, 3 },
                    { 5, 3 },
                    { 3, 4 },
                    { 5, 4 },
                    { 2, 5 },
                    { 3, 5 },
                    { 2, 6 },
                    { 3, 6 },
                    { 3, 7 },
                    { 4, 7 },
                    { 3, 8 },
                    { 4, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 4, 10 },
                    { 1, 11 },
                    { 3, 11 },
                    { 4, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
