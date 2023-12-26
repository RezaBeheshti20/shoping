using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace M_invantori.Infarastucher.EFcor.Migrations
{
    public partial class InvantoriyyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INvantoriyy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    UnitParice = table.Column<double>(type: "float", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    CurrentCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INvantoriyy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oprations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Opration = table.Column<bool>(type: "bit", nullable: false),
                    Count = table.Column<long>(type: "bigint", nullable: false),
                    OprationId = table.Column<long>(type: "bigint", nullable: false),
                    OprationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentCount = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    InvantoriyId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oprations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oprations_INvantoriyy_Id",
                        column: x => x.Id,
                        principalTable: "INvantoriyy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oprations");

            migrationBuilder.DropTable(
                name: "INvantoriyy");
        }
    }
}
