using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Repository.Migrations
{
    public partial class updatetale2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Appointment_AspNetUsers_tbl_UserId",
                table: "tbl_Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Appointment_tbl_Department_tbl_DepartmentId",
                table: "tbl_Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Contacts_tbl_Hospital_HospitalId",
                table: "tbl_Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Rooms_tbl_Hospital_HospitalId",
                table: "tbl_Rooms");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Appointment_tbl_DepartmentId",
                table: "tbl_Appointment");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Appointment_tbl_UserId",
                table: "tbl_Appointment");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "tbl_RoomStatus");

            migrationBuilder.DropColumn(
                name: "StatusTypeId",
                table: "tbl_RoomStatus");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "tbl_RoomStatus");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "tbl_Contacts");

            migrationBuilder.DropColumn(
                name: "tbl_DepartmentId",
                table: "tbl_Appointment");

            migrationBuilder.DropColumn(
                name: "tbl_UserId",
                table: "tbl_Appointment");

            migrationBuilder.AlterColumn<long>(
                name: "HospitalId",
                table: "tbl_Rooms",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "HospitalId",
                table: "tbl_Contacts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PatientId",
                table: "tbl_Appointment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DoctorId",
                table: "tbl_Appointment",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<long>(
                name: "DepartmentId",
                table: "tbl_Appointment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Appointment_DepartmentId",
                table: "tbl_Appointment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Appointment_DoctorId",
                table: "tbl_Appointment",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Appointment_AspNetUsers_DoctorId",
                table: "tbl_Appointment",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Appointment_tbl_Department_DepartmentId",
                table: "tbl_Appointment",
                column: "DepartmentId",
                principalTable: "tbl_Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Contacts_tbl_Hospital_HospitalId",
                table: "tbl_Contacts",
                column: "HospitalId",
                principalTable: "tbl_Hospital",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Rooms_tbl_Hospital_HospitalId",
                table: "tbl_Rooms",
                column: "HospitalId",
                principalTable: "tbl_Hospital",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Appointment_AspNetUsers_DoctorId",
                table: "tbl_Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Appointment_tbl_Department_DepartmentId",
                table: "tbl_Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Contacts_tbl_Hospital_HospitalId",
                table: "tbl_Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Rooms_tbl_Hospital_HospitalId",
                table: "tbl_Rooms");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Appointment_DepartmentId",
                table: "tbl_Appointment");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Appointment_DoctorId",
                table: "tbl_Appointment");

            migrationBuilder.AddColumn<long>(
                name: "RoomId",
                table: "tbl_RoomStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StatusTypeId",
                table: "tbl_RoomStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "tbl_RoomStatus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<long>(
                name: "HospitalId",
                table: "tbl_Rooms",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "HospitalId",
                table: "tbl_Contacts",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "DepartmentId",
                table: "tbl_Contacts",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PatientId",
                table: "tbl_Appointment",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "DoctorId",
                table: "tbl_Appointment",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<long>(
                name: "DepartmentId",
                table: "tbl_Appointment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "tbl_DepartmentId",
                table: "tbl_Appointment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "tbl_UserId",
                table: "tbl_Appointment",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Appointment_tbl_DepartmentId",
                table: "tbl_Appointment",
                column: "tbl_DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Appointment_tbl_UserId",
                table: "tbl_Appointment",
                column: "tbl_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Appointment_AspNetUsers_tbl_UserId",
                table: "tbl_Appointment",
                column: "tbl_UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Appointment_tbl_Department_tbl_DepartmentId",
                table: "tbl_Appointment",
                column: "tbl_DepartmentId",
                principalTable: "tbl_Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Contacts_tbl_Hospital_HospitalId",
                table: "tbl_Contacts",
                column: "HospitalId",
                principalTable: "tbl_Hospital",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Rooms_tbl_Hospital_HospitalId",
                table: "tbl_Rooms",
                column: "HospitalId",
                principalTable: "tbl_Hospital",
                principalColumn: "Id");
        }
    }
}
