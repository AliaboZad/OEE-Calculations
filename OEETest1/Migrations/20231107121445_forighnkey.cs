using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OEETest1.Migrations
{
    public partial class forighnkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_machines_shifts_ShiftId",
                table: "machines");

            migrationBuilder.DropForeignKey(
                name: "FK_productions_shifts_shiftsId",
                table: "productions");

            migrationBuilder.DropColumn(
                name: "ShiftId",
                table: "productions");

            migrationBuilder.RenameColumn(
                name: "shiftsId",
                table: "productions",
                newName: "ShiftsId");

            migrationBuilder.RenameIndex(
                name: "IX_productions_shiftsId",
                table: "productions",
                newName: "IX_productions_ShiftsId");

            migrationBuilder.RenameColumn(
                name: "ShiftId",
                table: "machines",
                newName: "ShiftsId");

            migrationBuilder.RenameIndex(
                name: "IX_machines_ShiftId",
                table: "machines",
                newName: "IX_machines_ShiftsId");

            migrationBuilder.AlterColumn<int>(
                name: "ShiftsId",
                table: "productions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_machines_shifts_ShiftsId",
                table: "machines",
                column: "ShiftsId",
                principalTable: "shifts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_productions_shifts_ShiftsId",
                table: "productions",
                column: "ShiftsId",
                principalTable: "shifts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_machines_shifts_ShiftsId",
                table: "machines");

            migrationBuilder.DropForeignKey(
                name: "FK_productions_shifts_ShiftsId",
                table: "productions");

            migrationBuilder.RenameColumn(
                name: "ShiftsId",
                table: "productions",
                newName: "shiftsId");

            migrationBuilder.RenameIndex(
                name: "IX_productions_ShiftsId",
                table: "productions",
                newName: "IX_productions_shiftsId");

            migrationBuilder.RenameColumn(
                name: "ShiftsId",
                table: "machines",
                newName: "ShiftId");

            migrationBuilder.RenameIndex(
                name: "IX_machines_ShiftsId",
                table: "machines",
                newName: "IX_machines_ShiftId");

            migrationBuilder.AlterColumn<int>(
                name: "shiftsId",
                table: "productions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShiftId",
                table: "productions",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_machines_shifts_ShiftId",
                table: "machines",
                column: "ShiftId",
                principalTable: "shifts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_productions_shifts_shiftsId",
                table: "productions",
                column: "shiftsId",
                principalTable: "shifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
