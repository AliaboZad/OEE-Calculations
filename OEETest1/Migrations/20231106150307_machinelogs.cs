using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OEETest1.Migrations
{
    public partial class machinelogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Planed_dowentime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shifts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "machines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ShiftId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_machines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_machines_shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "shifts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "productions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total_parts_produced = table.Column<int>(type: "int", nullable: false),
                    Defective_parts = table.Column<int>(type: "int", nullable: false),
                    ShiftId = table.Column<int>(type: "int", nullable: true),
                    shiftsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productions_shifts_shiftsId",
                        column: x => x.shiftsId,
                        principalTable: "shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_machines_ShiftId",
                table: "machines",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_productions_shiftsId",
                table: "productions",
                column: "shiftsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "machines");

            migrationBuilder.DropTable(
                name: "productions");

            migrationBuilder.DropTable(
                name: "shifts");
        }
    }
}
