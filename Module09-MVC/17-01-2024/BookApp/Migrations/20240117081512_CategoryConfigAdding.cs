using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookApp.Migrations
{
    /// <inheritdoc />
    public partial class CategoryConfigAdding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Books",
                newName: "ImageURL");

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "Categories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "URL" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2647), "Genel kategorisine sahip ve kategorisiz kitaplar burada olacak", true, false, new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2660), "Genel", "genel" },
                    { 2, new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2664), "Bilim kurgu kitapları", true, false, new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2664), "Bilim Kurgu", "bilim-kurgu" },
                    { 3, new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2665), "Distopik kitaplar", true, false, new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2665), "Distopya", "distopya" },
                    { 4, new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2666), "Bilim ve Mühendislik Kitapları", true, false, new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2666), "Bilim Ve Mühendislik", "bilim-ve-muhendislik" },
                    { 5, new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2667), "Dünya tarihi ile ilgili kitaplar", true, false, new DateTime(2024, 1, 17, 11, 15, 12, 925, DateTimeKind.Local).AddTicks(2668), "Dünya Tarihi", "dunya-tarihi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Books",
                newName: "Image");

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");
        }
    }
}
