using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniveraStoreCase.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "CategoryYears",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryBrandId", "CategoryColorId", "CategoryFuelTypeId", "CategoryVehicleTypeId", "CategoryYearId", "Description", "Name", "Price", "PublishDate", "Status" },
                values: new object[,]
                {
                    { 1, 6, 1, 1, 1, 15, "Sahibinden Temiz Skoda Fabia, Kazasız. 2004 model tdi 75hp.", "Satılık Skoda Fabia", 175000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 2, 2, 1, 1, 1, 17, "2006 Model az kullanılmış Fiat Punto", "Satılık Fiat Punto", 250000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 3, 1, 1, 2, 1, 11, "2000 Model hasarsız Merceses", "Satılık Mercedes E200", 700000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 4, 8, 2, 1, 1, 26, "2015 Model satılık Audi A8", "Satılık Audi A8", 750000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 5, 8, 2, 1, 1, 24, "2013 Model satılık Audi A6", "Satılık Audi A6", 650000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 6, 3, 3, 4, 1, 1, "Uygun fiyatlı Renault Clio", "Satılık Renault Clio", 350000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 7, 4, 3, 2, 2, 1, "Ford Transit hasarsız, ay yakıt harcar.", "Satılık Ford Transit", 450000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 8, 3, 4, 3, 2, 19, "2008 Model Reanult Kangoo satılıktır.", "Satılık Renault Kangoo", 150000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 9, 4, 4, 3, 1, 1, "Doktordan temiz Ford Fiesta satılık", "Satılık Ford Fiesta", 200000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 10, 7, 4, 1, 3, 27, "Satılık Man marka Kamyon 2016 model.", "Satılık Man TGA", 1750000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 11, 5, 5, 1, 4, 1, "Satılık Ferrari 812 GTS. Spor model.", "Satılık Ferrari 812 GTS.", 17500000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 12, 1, 5, 5, 1, 22, "2011 model VolksWagen Golf satılık. ", "Satılık Volkswagen Golf", 600000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 13, 1, 5, 5, 1, 1, "Wolskwagen passat hasar kayıtsız.", "Satılık Volkswagen Passat", 800000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 14, 1, 1, 1, 1, 1, "110 beygir Volkswage Polo satılık araç.", "Satılık Volkswagen Polo", 380000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 15, 6, 1, 1, 1, 29, "Üst sınıf Skoda Superb 2018 model satılık araç.", "Satılık Skoda Superb", 550000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "CategoryYears",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 4);
        }
    }
}
