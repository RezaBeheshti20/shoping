using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Commant_infarstucter_EFCore.Migrations
{
    public partial class Commanet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commantes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Mesasseg = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    WebSoit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsConfirmad = table.Column<bool>(type: "bit", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    OwnerRecordId = table.Column<long>(type: "bigint", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    ParntId = table.Column<long>(type: "bigint", nullable: false),
                    CreationData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commantes_Commantes_ParntId",
                        column: x => x.ParntId,
                        principalTable: "Commantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commantes_ParntId",
                table: "Commantes",
                column: "ParntId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commantes");
        }
    }
}
