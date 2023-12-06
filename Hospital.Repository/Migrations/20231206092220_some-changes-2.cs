using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Repository.Migrations
{
    public partial class somechanges2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenderType",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "NationalityId",
                table: "AspNetUsers",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_Country",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Department",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Department_tbl_Department_ParentId",
                        column: x => x.ParentId,
                        principalTable: "tbl_Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_HospitalType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShowName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HospitalType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Insurance",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Insurance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Lab",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LabNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TestType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestCde = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BloodPressure = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Temprature = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TestResult = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Lab", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Lab_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_PayRoll",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NetSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    HourlySalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BounusSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Compenstion = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PayRoll", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_PayRoll_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_PayRoll_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StatusType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShowName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StatusType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_States", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_States_tbl_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "tbl_Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Appointment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: true),
                    DoctorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tbl_DepartmentId = table.Column<long>(type: "bigint", nullable: false),
                    tbl_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Appointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Appointment_AspNetUsers_tbl_UserId",
                        column: x => x.tbl_UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Appointment_tbl_Department_tbl_DepartmentId",
                        column: x => x.tbl_DepartmentId,
                        principalTable: "tbl_Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Bill",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InsuranceId = table.Column<long>(type: "bigint", nullable: false),
                    DoctorChage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MedicineChage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RoomChage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OperationeChage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumberOfDays = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NursingCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LabCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Advance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalBill = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Bill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Bill_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_Bill_tbl_Insurance_InsuranceId",
                        column: x => x.InsuranceId,
                        principalTable: "tbl_Insurance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_City",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_City_tbl_States_StateId",
                        column: x => x.StateId,
                        principalTable: "tbl_States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_TestPrice",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LabId = table.Column<long>(type: "bigint", nullable: false),
                    BillId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_TestPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_TestPrice_tbl_Bill_BillId",
                        column: x => x.BillId,
                        principalTable: "tbl_Bill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_TestPrice_tbl_Lab_LabId",
                        column: x => x.LabId,
                        principalTable: "tbl_Lab",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Hospital",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalTypeId = table.Column<long>(type: "bigint", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tbl_CityId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Hospital", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Hospital_tbl_City_tbl_CityId",
                        column: x => x.tbl_CityId,
                        principalTable: "tbl_City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Hospital_tbl_HospitalType_HospitalTypeId",
                        column: x => x.HospitalTypeId,
                        principalTable: "tbl_HospitalType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Supplier",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tbl_CityId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Supplier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Supplier_tbl_City_tbl_CityId",
                        column: x => x.tbl_CityId,
                        principalTable: "tbl_City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Contacts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalId = table.Column<long>(type: "bigint", nullable: true),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tbl_DepartmentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Contacts_tbl_Department_tbl_DepartmentId",
                        column: x => x.tbl_DepartmentId,
                        principalTable: "tbl_Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Contacts_tbl_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "tbl_Hospital",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: true),
                    RoomeType = table.Column<int>(type: "int", nullable: true),
                    HospitalId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Rooms_tbl_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "tbl_Hospital",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_RoomStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusTypeId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tbl_RoomsId = table.Column<int>(type: "int", nullable: false),
                    tbl_StatusTypeId = table.Column<long>(type: "bigint", nullable: false),
                    tbl_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_RoomStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_RoomStatus_AspNetUsers_tbl_UserId",
                        column: x => x.tbl_UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_RoomStatus_tbl_Rooms_tbl_RoomsId",
                        column: x => x.tbl_RoomsId,
                        principalTable: "tbl_Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_RoomStatus_tbl_StatusType_tbl_StatusTypeId",
                        column: x => x.tbl_StatusTypeId,
                        principalTable: "tbl_StatusType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Appointment_tbl_DepartmentId",
                table: "tbl_Appointment",
                column: "tbl_DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Appointment_tbl_UserId",
                table: "tbl_Appointment",
                column: "tbl_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Bill_InsuranceId",
                table: "tbl_Bill",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Bill_PatientId",
                table: "tbl_Bill",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_City_StateId",
                table: "tbl_City",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Contacts_HospitalId",
                table: "tbl_Contacts",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Contacts_tbl_DepartmentId",
                table: "tbl_Contacts",
                column: "tbl_DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Department_ParentId",
                table: "tbl_Department",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Hospital_HospitalTypeId",
                table: "tbl_Hospital",
                column: "HospitalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Hospital_tbl_CityId",
                table: "tbl_Hospital",
                column: "tbl_CityId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Lab_PatientId",
                table: "tbl_Lab",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PayRoll_EmployeeId",
                table: "tbl_PayRoll",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_PayRoll_UserId",
                table: "tbl_PayRoll",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Rooms_HospitalId",
                table: "tbl_Rooms",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RoomStatus_tbl_RoomsId",
                table: "tbl_RoomStatus",
                column: "tbl_RoomsId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RoomStatus_tbl_StatusTypeId",
                table: "tbl_RoomStatus",
                column: "tbl_StatusTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RoomStatus_tbl_UserId",
                table: "tbl_RoomStatus",
                column: "tbl_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_States_CountryId",
                table: "tbl_States",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Supplier_tbl_CityId",
                table: "tbl_Supplier",
                column: "tbl_CityId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_TestPrice_BillId",
                table: "tbl_TestPrice",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_TestPrice_LabId",
                table: "tbl_TestPrice",
                column: "LabId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Appointment");

            migrationBuilder.DropTable(
                name: "tbl_Contacts");

            migrationBuilder.DropTable(
                name: "tbl_PayRoll");

            migrationBuilder.DropTable(
                name: "tbl_RoomStatus");

            migrationBuilder.DropTable(
                name: "tbl_Supplier");

            migrationBuilder.DropTable(
                name: "tbl_TestPrice");

            migrationBuilder.DropTable(
                name: "tbl_Department");

            migrationBuilder.DropTable(
                name: "tbl_Rooms");

            migrationBuilder.DropTable(
                name: "tbl_StatusType");

            migrationBuilder.DropTable(
                name: "tbl_Bill");

            migrationBuilder.DropTable(
                name: "tbl_Lab");

            migrationBuilder.DropTable(
                name: "tbl_Hospital");

            migrationBuilder.DropTable(
                name: "tbl_Insurance");

            migrationBuilder.DropTable(
                name: "tbl_City");

            migrationBuilder.DropTable(
                name: "tbl_HospitalType");

            migrationBuilder.DropTable(
                name: "tbl_States");

            migrationBuilder.DropTable(
                name: "tbl_Country");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GenderType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "AspNetUsers");
        }
    }
}
