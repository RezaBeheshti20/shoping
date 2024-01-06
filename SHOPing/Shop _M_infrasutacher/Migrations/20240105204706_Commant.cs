using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop__M_infrasutacher.Migrations
{
    public partial class Commant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    PictureAlt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PictureTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PicturTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreationData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slid",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pictur = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PicturAlt = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PicturTitel = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Heding = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BtnText = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false),
                    CreationData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PictureAlt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PictureTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PicturTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoreyId = table.Column<long>(type: "bigint", nullable: false),
                    IsInStok = table.Column<bool>(type: "bit", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreationData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategory_CategoreyId",
                        column: x => x.CategoreyId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commantes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Mesasseg = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IsConfirmad = table.Column<bool>(type: "bit", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    CreationData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commantes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPictur",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Pictur = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PicturAlt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PicturTitel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false),
                    CreationData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPictur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPictur_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commantes_ProductId",
                table: "Commantes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPictur_ProductId",
                table: "ProductPictur",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoreyId",
                table: "Products",
                column: "CategoreyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commantes");

            migrationBuilder.DropTable(
                name: "ProductPictur");

            migrationBuilder.DropTable(
                name: "Slid");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductCategory");
        }
    }
}
