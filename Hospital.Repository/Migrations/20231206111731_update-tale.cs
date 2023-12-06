using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Repository.Migrations
{
    public partial class updatetale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Hospital_tbl_HospitalType_HospitalTypeId",
                table: "tbl_Hospital");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "tbl_Hospital");

            migrationBuilder.AlterColumn<long>(
                name: "HospitalTypeId",
                table: "tbl_Hospital",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Hospital_tbl_HospitalType_HospitalTypeId",
                table: "tbl_Hospital",
                column: "HospitalTypeId",
                principalTable: "tbl_HospitalType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Hospital_tbl_HospitalType_HospitalTypeId",
                table: "tbl_Hospital");

            migrationBuilder.AlterColumn<long>(
                name: "HospitalTypeId",
                table: "tbl_Hospital",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "CityId",
                table: "tbl_Hospital",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Hospital_tbl_HospitalType_HospitalTypeId",
                table: "tbl_Hospital",
                column: "HospitalTypeId",
                principalTable: "tbl_HospitalType",
                principalColumn: "Id");
        }
    }
}
