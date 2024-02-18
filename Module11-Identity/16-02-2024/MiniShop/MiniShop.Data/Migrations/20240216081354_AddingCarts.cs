using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingCarts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c819781-483a-449f-a273-a6f26f1bb57d", "10dc4375-2061-4a74-b5f4-f6e44d82bac8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8f9d33f3-3822-4ddb-b97e-882b44f905e4", "10dc4375-2061-4a74-b5f4-f6e44d82bac8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d3a3fabd-12c7-494e-905c-c15159610d3d", "1bf02711-9b9b-4d42-b467-0c8387f59955" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c819781-483a-449f-a273-a6f26f1bb57d", "c4ea2279-92f8-41dc-be39-5291095730af" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c819781-483a-449f-a273-a6f26f1bb57d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f9d33f3-3822-4ddb-b97e-882b44f905e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3a3fabd-12c7-494e-905c-c15159610d3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10dc4375-2061-4a74-b5f4-f6e44d82bac8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bf02711-9b9b-4d42-b467-0c8387f59955");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4ea2279-92f8-41dc-be39-5291095730af");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CartId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
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
                    { "0c7ba16d-1713-4d32-a209-6b43e173e4a1", null, "Müşteri tipindeki kullanıcıların rolü", "Customer", "CUSTOMER" },
                    { "4572c2ae-d397-44a4-87d7-ad9f5d74b506", null, "Sınırlı yönetici yetkilerine sahip kullanıcıların rolü", "Admin", "ADMIN" },
                    { "94e4587f-04c9-4418-9105-51ccc0ab9bf3", null, "Tüm yönetici yetkilerine sahip kullanıcıların rolü", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "CreatedDate", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "958f5a41-d54e-44d3-8ec5-690fbdbf530a", 0, "Rasimpaşa Mh. Hancı Sk. No:4 Kadıköy", "İstanbul", "2b0bb1ca-d5d6-4345-bdf6-6ef24caad858", new DateTime(2024, 2, 16, 11, 13, 53, 752, DateTimeKind.Local).AddTicks(5322), new DateTime(1988, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "CUSTOMER", "AQAAAAIAAYagAAAAEP3tvJmW2jhZy2kOnyLIltlKcZIDV3q1C06nhHDWn9eh9IecFHzbK5BYuAc9C+5gKA==", "555-444-55-44", false, "aab18d9b-1beb-4e6a-b8d5-5c7d20b63ee4", false, "customer" },
                    { "95bbdd4c-31bf-4afe-ba34-c5fa1c195671", 0, "Rasimpaşa Mh. Hancı Sk. No:4 Kadıköy", "İstanbul", "810ae74a-e864-4200-848b-52ff8d0185c4", new DateTime(2024, 2, 16, 11, 13, 53, 752, DateTimeKind.Local).AddTicks(5193), new DateTime(1990, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Kadın", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAEOfSlhezzhd829VAG82JpqkpBOzNWlD92X/Zaebo0WXLFPQ91tNT60REKNuiyXB9fw==", "555-444-55-44", false, "81b6133e-350f-4fa2-898c-19e590874b84", false, "superadmin" },
                    { "da2e34b3-e548-42f9-9445-519aa408fdc7", 0, "Rasimpaşa Mh. Hancı Sk. No:4 Kadıköy", "İstanbul", "937ab39c-a711-4f67-a28e-79d9d21ffb37", new DateTime(2024, 2, 16, 11, 13, 53, 752, DateTimeKind.Local).AddTicks(5292), new DateTime(1993, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEEJa0MmdYKuviXWD80Ate2BxGz6Gigq+6v/OwpmkU6GEjbfVzwozp7fl4irP0TNLlQ==", "555-444-55-44", false, "2ef0bfa5-7202-40e4-a462-cebdf1479672", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(1338), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(1356), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(1358), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(1359), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(1361), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8564), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8576), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8579), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8580), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8582), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8584), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8586), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8587), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8590), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8592), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8593), new DateTime(2024, 2, 16, 11, 13, 53, 970, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0c7ba16d-1713-4d32-a209-6b43e173e4a1", "958f5a41-d54e-44d3-8ec5-690fbdbf530a" },
                    { "94e4587f-04c9-4418-9105-51ccc0ab9bf3", "95bbdd4c-31bf-4afe-ba34-c5fa1c195671" },
                    { "0c7ba16d-1713-4d32-a209-6b43e173e4a1", "da2e34b3-e548-42f9-9445-519aa408fdc7" },
                    { "4572c2ae-d397-44a4-87d7-ad9f5d74b506", "da2e34b3-e548-42f9-9445-519aa408fdc7" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 16, 11, 13, 53, 969, DateTimeKind.Local).AddTicks(4810), "95bbdd4c-31bf-4afe-ba34-c5fa1c195671" },
                    { 2, new DateTime(2024, 2, 16, 11, 13, 53, 969, DateTimeKind.Local).AddTicks(4845), "da2e34b3-e548-42f9-9445-519aa408fdc7" },
                    { 3, new DateTime(2024, 2, 16, 11, 13, 53, 969, DateTimeKind.Local).AddTicks(4847), "958f5a41-d54e-44d3-8ec5-690fbdbf530a" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0c7ba16d-1713-4d32-a209-6b43e173e4a1", "958f5a41-d54e-44d3-8ec5-690fbdbf530a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "94e4587f-04c9-4418-9105-51ccc0ab9bf3", "95bbdd4c-31bf-4afe-ba34-c5fa1c195671" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0c7ba16d-1713-4d32-a209-6b43e173e4a1", "da2e34b3-e548-42f9-9445-519aa408fdc7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4572c2ae-d397-44a4-87d7-ad9f5d74b506", "da2e34b3-e548-42f9-9445-519aa408fdc7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c7ba16d-1713-4d32-a209-6b43e173e4a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4572c2ae-d397-44a4-87d7-ad9f5d74b506");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94e4587f-04c9-4418-9105-51ccc0ab9bf3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "958f5a41-d54e-44d3-8ec5-690fbdbf530a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95bbdd4c-31bf-4afe-ba34-c5fa1c195671");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da2e34b3-e548-42f9-9445-519aa408fdc7");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c819781-483a-449f-a273-a6f26f1bb57d", null, "Müşteri tipindeki kullanıcıların rolü", "Customer", "CUSTOMER" },
                    { "8f9d33f3-3822-4ddb-b97e-882b44f905e4", null, "Sınırlı yönetici yetkilerine sahip kullanıcıların rolü", "Admin", "ADMIN" },
                    { "d3a3fabd-12c7-494e-905c-c15159610d3d", null, "Tüm yönetici yetkilerine sahip kullanıcıların rolü", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "CreatedDate", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10dc4375-2061-4a74-b5f4-f6e44d82bac8", 0, "Rasimpaşa Mh. Hancı Sk. No:4 Kadıköy", "İstanbul", "530d4ff3-f04e-43a7-b1bf-3c0a49999ab5", new DateTime(2024, 2, 16, 10, 33, 54, 471, DateTimeKind.Local).AddTicks(4015), new DateTime(1993, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEG4A4lr0eyCYF3YbBdOZpKZ7nVmVKnVzVoOKrPxmK2YzuTxWsfm59BYSLTdlHPgPNw==", "555-444-55-44", false, "fae23c35-5fd3-4bad-9142-3096fe6f2ba9", false, "admin" },
                    { "1bf02711-9b9b-4d42-b467-0c8387f59955", 0, "Rasimpaşa Mh. Hancı Sk. No:4 Kadıköy", "İstanbul", "5f84d344-ca7f-4876-9939-35a89a99e6cc", new DateTime(2024, 2, 16, 10, 33, 54, 471, DateTimeKind.Local).AddTicks(3977), new DateTime(1990, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Kadın", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAEPOTtj/JO4t6eQiiep10lhoVSqfyM+yW/5w5l8PgQFbJLYesVXpIb1wR0uVTt7QiEg==", "555-444-55-44", false, "cca1f127-32a7-425b-a56a-344253711efa", false, "superadmin" },
                    { "c4ea2279-92f8-41dc-be39-5291095730af", 0, "Rasimpaşa Mh. Hancı Sk. No:4 Kadıköy", "İstanbul", "d33fa7c8-e228-427f-8d13-e976720fb48f", new DateTime(2024, 2, 16, 10, 33, 54, 471, DateTimeKind.Local).AddTicks(4023), new DateTime(1988, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "CUSTOMER", "AQAAAAIAAYagAAAAEO9raGHH8RJeDmV/HBcA/+eEJxypGwaLDfM7szZ/86shB703TfbvHVmLJ4bevFsCJw==", "555-444-55-44", false, "3542efec-c73e-4f04-b7d4-a2d24b3a4fc7", false, "customer" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 720, DateTimeKind.Local).AddTicks(7416), new DateTime(2024, 2, 16, 10, 33, 54, 720, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 720, DateTimeKind.Local).AddTicks(7446), new DateTime(2024, 2, 16, 10, 33, 54, 720, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 720, DateTimeKind.Local).AddTicks(7448), new DateTime(2024, 2, 16, 10, 33, 54, 720, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 720, DateTimeKind.Local).AddTicks(7449), new DateTime(2024, 2, 16, 10, 33, 54, 720, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 720, DateTimeKind.Local).AddTicks(7450), new DateTime(2024, 2, 16, 10, 33, 54, 720, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5961), new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5977), new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5979), new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5981), new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5983), new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5985), new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5987), new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5989), new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5990), new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(5992), new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(6018), new DateTime(2024, 2, 16, 10, 33, 54, 721, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3c819781-483a-449f-a273-a6f26f1bb57d", "10dc4375-2061-4a74-b5f4-f6e44d82bac8" },
                    { "8f9d33f3-3822-4ddb-b97e-882b44f905e4", "10dc4375-2061-4a74-b5f4-f6e44d82bac8" },
                    { "d3a3fabd-12c7-494e-905c-c15159610d3d", "1bf02711-9b9b-4d42-b467-0c8387f59955" },
                    { "3c819781-483a-449f-a273-a6f26f1bb57d", "c4ea2279-92f8-41dc-be39-5291095730af" }
                });
        }
    }
}
