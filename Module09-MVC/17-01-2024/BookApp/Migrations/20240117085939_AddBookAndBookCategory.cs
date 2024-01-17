using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookApp.Migrations
{
    /// <inheritdoc />
    public partial class AddBookAndBookCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "BookCategories");

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "Books",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Books",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ImageURL",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Abstract",
                table: "Books",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories",
                columns: new[] { "BookID", "CategoryID" });

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
                    { 1, "", new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(8132), "ogrenci-kiz-1.png", true, false, true, new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(8139), "Öğrenci Kız", 99, 145m, 120, "ogrenci-kiz-1" },
                    { 2, "", new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(8148), "homo-deus-2.png", true, false, true, new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(8149), "Homo Deus", 299, 215m, 20, "homo-deus-2" },
                    { 3, "", new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(8151), "efendi-uyaniyor-3.png", true, false, false, new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(8151), "Efendi Uyanıyor", 316, 185m, 78, "efendi-uyaniyor-3" },
                    { 4, "", new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(8152), "evrenin-sonundaki-restoran-3.png", true, false, true, new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(8152), "Evrenin Sonundaki Restoran", 149, 153m, 76, "evrenin-sonundaki-restoran" },
                    { 5, "", new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(8154), "beyaz-kurt-5.png", true, false, true, new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(8154), "Beyaz Kurt", 123, 223m, 156, "beyaz-kurt" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(6764), new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(6783), new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(6785), new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(6786), new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(6787), new DateTime(2024, 1, 17, 11, 59, 38, 932, DateTimeKind.Local).AddTicks(6787) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories");

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookID", "CategoryID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookID", "CategoryID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookID", "CategoryID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookID", "CategoryID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookID", "CategoryID" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookID", "CategoryID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookID", "CategoryID" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookID", "CategoryID" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookID", "CategoryID" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookID", "CategoryID" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookID", "CategoryID" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookID", "CategoryID" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookID", "CategoryID" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "ImageURL",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "Abstract",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "BookCategories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2647), new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2664), new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2665), new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2666), new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2667), new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2668) });
        }
    }
}
