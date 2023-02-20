using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniveraStoreCase.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryColors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryFuelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryVehicleTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryVehicleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryYears",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryYears", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(16,2)", precision: 16, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CategoryBrandId = table.Column<int>(type: "int", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryVehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    CategoryFuelTypeId = table.Column<int>(type: "int", nullable: false),
                    CategoryYearId = table.Column<int>(type: "int", nullable: false),
                    CategoryColorId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_CategoryBrands_CategoryBrandId",
                        column: x => x.CategoryBrandId,
                        principalTable: "CategoryBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_CategoryColors_CategoryColorId",
                        column: x => x.CategoryColorId,
                        principalTable: "CategoryColors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_CategoryFuelTypes_CategoryFuelTypeId",
                        column: x => x.CategoryFuelTypeId,
                        principalTable: "CategoryFuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_CategoryVehicleTypes_CategoryVehicleTypeId",
                        column: x => x.CategoryVehicleTypeId,
                        principalTable: "CategoryVehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_CategoryYears_CategoryYearId",
                        column: x => x.CategoryYearId,
                        principalTable: "CategoryYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryBrandId",
                table: "Products",
                column: "CategoryBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryColorId",
                table: "Products",
                column: "CategoryColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryFuelTypeId",
                table: "Products",
                column: "CategoryFuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryVehicleTypeId",
                table: "Products",
                column: "CategoryVehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryYearId",
                table: "Products",
                column: "CategoryYearId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CategoryBrands");

            migrationBuilder.DropTable(
                name: "CategoryColors");

            migrationBuilder.DropTable(
                name: "CategoryFuelTypes");

            migrationBuilder.DropTable(
                name: "CategoryVehicleTypes");

            migrationBuilder.DropTable(
                name: "CategoryYears");
        }
    }
}
