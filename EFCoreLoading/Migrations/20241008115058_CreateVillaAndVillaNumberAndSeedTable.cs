﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreLoading.Migrations
{
    /// <inheritdoc />
    public partial class CreateVillaAndVillaNumberAndSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VillaAmenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaAmenities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VillaAmenities_Villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Royal Villa", 200.0 },
                    { 2, "Premium Pool Villa", 300.0 },
                    { 3, "luxury Villa", 400.0 }
                });

            migrationBuilder.InsertData(
                table: "VillaAmenities",
                columns: new[] { "Id", "Name", "VillaId" },
                values: new object[,]
                {
                    { 1, "Private Pool", 1 },
                    { 2, "Microwave", 1 },
                    { 3, "Private Balcony", 1 },
                    { 4, "1 king bed and 1 sofa bed", 1 },
                    { 5, "Private Plunge Pool", 2 },
                    { 6, "Microwave and mini refrigerator", 2 },
                    { 7, "Private Pool", 3 },
                    { 8, "Jacuzzi", 3 },
                    { 9, "Private Balcony", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VillaAmenities_VillaId",
                table: "VillaAmenities",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaAmenities");

            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}
