using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniveraStoreCase.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryBrands",
                columns: new[] { "Id", "Brand", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, "Volkswagen", 0, false },
                    { 2, "Fiat", 0, false },
                    { 3, "Renault", 0, false },
                    { 4, "Ford", 0, false },
                    { 5, "Ferrari", 0, false },
                    { 6, "Skoda", 0, false },
                    { 7, "Man", 0, false },
                    { 8, "Audi", 0, false }
                });

            migrationBuilder.InsertData(
                table: "CategoryColors",
                columns: new[] { "Id", "Color", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, "Beyaz", 0, false },
                    { 2, "Siyah", 0, false },
                    { 3, "Gri", 0, false },
                    { 4, "Mavi", 0, false },
                    { 5, "Sarı", 0, false }
                });

            migrationBuilder.InsertData(
                table: "CategoryFuelTypes",
                columns: new[] { "Id", "FuelType", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, "Benzin", 0, false },
                    { 2, "Dizel", 0, false },
                    { 3, "LPG", 0, false },
                    { 4, "Hibrit", 0, false },
                    { 5, "Elektrik", 0, false }
                });

            migrationBuilder.InsertData(
                table: "CategoryVehicleTypes",
                columns: new[] { "Id", "ProductId", "Status", "VehicleType" },
                values: new object[,]
                {
                    { 1, 0, false, "Hususi" },
                    { 2, 0, false, "Ticari" },
                    { 3, 0, false, "Kamyonet" },
                    { 4, 0, false, "Spor" }
                });

            migrationBuilder.InsertData(
                table: "CategoryYears",
                columns: new[] { "Id", "ProductId", "Status", "Year" },
                values: new object[,]
                {
                    { 1, 0, false, 1990 },
                    { 2, 0, false, 1991 },
                    { 3, 0, false, 1992 },
                    { 4, 0, false, 1993 },
                    { 5, 0, false, 1994 },
                    { 6, 0, false, 1995 },
                    { 7, 0, false, 1996 },
                    { 8, 0, false, 1997 },
                    { 9, 0, false, 1998 },
                    { 10, 0, false, 1999 },
                    { 11, 0, false, 2000 },
                    { 12, 0, false, 2001 },
                    { 13, 0, false, 2002 },
                    { 14, 0, false, 2003 },
                    { 15, 0, false, 2004 },
                    { 16, 0, false, 2005 },
                    { 17, 0, false, 2006 },
                    { 18, 0, false, 2007 },
                    { 19, 0, false, 2008 },
                    { 20, 0, false, 2009 },
                    { 21, 0, false, 2010 },
                    { 22, 0, false, 2011 },
                    { 23, 0, false, 2012 },
                    { 24, 0, false, 2013 },
                    { 25, 0, false, 2014 },
                    { 26, 0, false, 2015 },
                    { 27, 0, false, 2016 },
                    { 28, 0, false, 2017 },
                    { 29, 0, false, 2018 },
                    { 30, 0, false, 2019 },
                    { 31, 0, false, 2020 },
                    { 32, 0, false, 2021 },
                    { 33, 0, false, 2022 },
                    { 34, 0, false, 2023 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryBrands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryBrands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryBrands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryBrands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoryBrands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoryBrands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CategoryBrands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CategoryBrands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CategoryColors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryColors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryColors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryColors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoryColors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoryFuelTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryFuelTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryFuelTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryFuelTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoryFuelTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoryVehicleTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryVehicleTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryVehicleTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryVehicleTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CategoryYears",
                keyColumn: "Id",
                keyValue: 34);
        }
    }
}
