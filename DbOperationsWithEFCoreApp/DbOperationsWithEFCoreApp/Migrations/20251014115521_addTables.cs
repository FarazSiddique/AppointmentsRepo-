using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DbOperationsWithEFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class addTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CellNo_Types",
                columns: table => new
                {
                    PHONE_CODE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PHONE_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellNo_Types", x => x.PHONE_CODE);
                });

            migrationBuilder.CreateTable(
                name: "Clinics_Types",
                columns: table => new
                {
                    clinic_Type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    clinic_Type_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics_Types", x => x.clinic_Type);
                });

            migrationBuilder.CreateTable(
                name: "HOLIDAYS",
                columns: table => new
                {
                    Holiday_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Holiday_date = table.Column<DateOnly>(type: "date", nullable: false),
                    Holiday_Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOLIDAYS", x => x.Holiday_id);
                });

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    clinic_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clinic_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clinic_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clinic_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clinic_LICENSE_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clinic_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clinic_Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clinic_URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clinic_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clinic_Alternate_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clinic_Tax_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Office_Manager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false),
                    PHONE_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clinic_Type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    PHONE_CODE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.clinic_Code);
                    table.ForeignKey(
                        name: "FK_Clinics_CellNo_Types_PHONE_CODE",
                        column: x => x.PHONE_CODE,
                        principalTable: "CellNo_Types",
                        principalColumn: "PHONE_CODE",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clinics_Clinics_Types_clinic_Type",
                        column: x => x.clinic_Type,
                        principalTable: "Clinics_Types",
                        principalColumn: "clinic_Type",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorLocations",
                columns: table => new
                {
                    LocationCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location_Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false),
                    clinic_Code = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorLocations", x => x.LocationCode);
                    table.ForeignKey(
                        name: "FK_DoctorLocations_Clinics_clinic_Code",
                        column: x => x.clinic_Code,
                        principalTable: "Clinics",
                        principalColumn: "clinic_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorsCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DoctorsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorsPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    License_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_Of_Birth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false),
                    clinic_Code = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorsCode);
                    table.ForeignKey(
                        name: "FK_Doctors_Clinics_clinic_Code",
                        column: x => x.clinic_Code,
                        principalTable: "Clinics",
                        principalColumn: "clinic_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReasonsAppointment",
                columns: table => new
                {
                    REASON_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    REASON_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false),
                    clinic_Code = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReasonsAppointment", x => x.REASON_ID);
                    table.ForeignKey(
                        name: "FK_ReasonsAppointment_Clinics_clinic_Code",
                        column: x => x.clinic_Code,
                        principalTable: "Clinics",
                        principalColumn: "clinic_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctor_Working_Days_Time",
                columns: table => new
                {
                    Doctor_Working_Days_Time_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weekday_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time_From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time_To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Break_Time_From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Break_Time_To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enable_Break = table.Column<bool>(type: "bit", nullable: false),
                    Date_From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    clinic_Code = table.Column<int>(type: "int", nullable: false),
                    LocationCode = table.Column<int>(type: "int", nullable: false),
                    DoctorsCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor_Working_Days_Time", x => x.Doctor_Working_Days_Time_ID);
                    table.ForeignKey(
                        name: "FK_Doctor_Working_Days_Time_Clinics_clinic_Code",
                        column: x => x.clinic_Code,
                        principalTable: "Clinics",
                        principalColumn: "clinic_Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctor_Working_Days_Time_DoctorLocations_LocationCode",
                        column: x => x.LocationCode,
                        principalTable: "DoctorLocations",
                        principalColumn: "LocationCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctor_Working_Days_Time_Doctors_DoctorsCode",
                        column: x => x.DoctorsCode,
                        principalTable: "Doctors",
                        principalColumn: "DoctorsCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoctorHoliday",
                columns: table => new
                {
                    DoctorHolidayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsWorkingDay = table.Column<bool>(type: "bit", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Holiday_id = table.Column<int>(type: "int", nullable: false),
                    clinic_Code = table.Column<int>(type: "int", nullable: false),
                    LocationCode = table.Column<int>(type: "int", nullable: false),
                    DoctorsCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HOLIDAYSHoliday_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorHoliday", x => x.DoctorHolidayId);
                    table.ForeignKey(
                        name: "FK_DoctorHoliday_Clinics_clinic_Code",
                        column: x => x.clinic_Code,
                        principalTable: "Clinics",
                        principalColumn: "clinic_Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorHoliday_DoctorLocations_LocationCode",
                        column: x => x.LocationCode,
                        principalTable: "DoctorLocations",
                        principalColumn: "LocationCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorHoliday_Doctors_DoctorsCode",
                        column: x => x.DoctorsCode,
                        principalTable: "Doctors",
                        principalColumn: "DoctorsCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorHoliday_HOLIDAYS_HOLIDAYSHoliday_id",
                        column: x => x.HOLIDAYSHoliday_id,
                        principalTable: "HOLIDAYS",
                        principalColumn: "Holiday_id");
                    table.ForeignKey(
                        name: "FK_DoctorHoliday_HOLIDAYS_Holiday_id",
                        column: x => x.Holiday_id,
                        principalTable: "HOLIDAYS",
                        principalColumn: "Holiday_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoctorYearlyHoliday",
                columns: table => new
                {
                    DoctorYearlyHolidayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Holiday_From = table.Column<DateOnly>(type: "date", nullable: false),
                    Holiday_To = table.Column<DateOnly>(type: "date", nullable: false),
                    Holiday_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Holiday_date = table.Column<DateOnly>(type: "date", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Holiday_id = table.Column<int>(type: "int", nullable: false),
                    clinic_Code = table.Column<int>(type: "int", nullable: false),
                    LocationCode = table.Column<int>(type: "int", nullable: false),
                    DoctorsCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorYearlyHoliday", x => x.DoctorYearlyHolidayId);
                    table.ForeignKey(
                        name: "FK_DoctorYearlyHoliday_Clinics_clinic_Code",
                        column: x => x.clinic_Code,
                        principalTable: "Clinics",
                        principalColumn: "clinic_Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorYearlyHoliday_DoctorLocations_LocationCode",
                        column: x => x.LocationCode,
                        principalTable: "DoctorLocations",
                        principalColumn: "LocationCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorYearlyHoliday_Doctors_DoctorsCode",
                        column: x => x.DoctorsCode,
                        principalTable: "Doctors",
                        principalColumn: "DoctorsCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorYearlyHoliday_HOLIDAYS_Holiday_id",
                        column: x => x.Holiday_id,
                        principalTable: "HOLIDAYS",
                        principalColumn: "Holiday_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CellNo_Types",
                columns: new[] { "PHONE_CODE", "Created_By", "Created_Date", "Is_Active", "PHONE_TYPE" },
                values: new object[,]
                {
                    { 5001, "Sumair", "2018-05-09 15:09:54.3030000", true, "HOME" },
                    { 5002, "Sumair", "2018-05-09 15:09:54.3030000", true, "OFFICE" },
                    { 5003, "Sumair", "2018-05-09 15:09:54.3030000", true, "CELL" }
                });

            migrationBuilder.InsertData(
                table: "Clinics_Types",
                columns: new[] { "clinic_Type", "clinic_Type_Description" },
                values: new object[,]
                {
                    { "G", "Group" },
                    { "I", "Individual" },
                    { "S", "Supplier" }
                });

            migrationBuilder.InsertData(
                table: "HOLIDAYS",
                columns: new[] { "Holiday_id", "Holiday_Title", "Holiday_date" },
                values: new object[,]
                {
                    { 1, "Kashmir Sloidarity Day", new DateOnly(2026, 2, 5) },
                    { 2, "Eid Fitar", new DateOnly(2026, 2, 21) },
                    { 3, "Labour Day", new DateOnly(2026, 5, 1) },
                    { 4, "Eid Azha", new DateOnly(2026, 5, 27) }
                });

            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "clinic_Code", "County", "Created_By", "Created_Date", "Email_Address", "Is_Active", "Location_Number", "Office_Manager", "PHONE_CODE", "PHONE_TYPE", "clinic_Address", "clinic_Alternate_Phone", "clinic_City", "clinic_LICENSE_NUMBER", "clinic_Name", "clinic_Phone", "clinic_State", "clinic_Tax_Id", "clinic_Type", "clinic_URL", "clinic_Zip" },
                values: new object[,]
                {
                    { 1, "LmK", "Sumair", "2018-05-09 15:09:54.3030000", "muhammadislam@carecloud.com", true, "", "", 5001, "", "Test", "", "Test", "MA64146", "Test", "", "Test", "", "I", "http://www.mhaqmd.com", "1" },
                    { 2, "LmK", "Sumair", "2018-05-09 15:09:54.3030000", "muhammadislam@carecloud.com", true, "", "", 5001, "", "Test", "", "Test", "MA64146", "MTBC Test", "", "Test", "", "I", "http://www.mhaqmd.com", "1" }
                });

            migrationBuilder.InsertData(
                table: "DoctorLocations",
                columns: new[] { "LocationCode", "Created_By", "Created_Date", "Is_Active", "LocationName", "Location_Address", "Location_City", "Location_State", "Location_Zip", "clinic_Code" },
                values: new object[,]
                {
                    { 1, null, null, false, "Karachi", null, null, null, null, 1 },
                    { 2, null, null, false, "Lahore", null, null, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorsCode", "Address", "City", "Created_By", "Created_Date", "Date_Of_Birth", "DoctorsName", "DoctorsPrefix", "Email_Address", "Gender", "Is_Active", "License_No", "State", "Zip", "clinic_Code" },
                values: new object[,]
                {
                    { "1", "", "", "", "", "", "Zafar", "", "", "", true, "", "", "", 1 },
                    { "2", "", "", "", "", "", "Sara", "", "", "", true, "", "", "", 1 },
                    { "3", "", "", "", "", "", "Iqbal", "", "", "", true, "", "", "", 1 }
                });

            migrationBuilder.InsertData(
                table: "ReasonsAppointment",
                columns: new[] { "REASON_ID", "Created_By", "Created_Date", "Is_Active", "REASON_NAME", "clinic_Code" },
                values: new object[,]
                {
                    { "1", "", "", true, "WELL VISIT", 1 },
                    { "2", "", "", true, "EMPLOYEE PHYSICAL", 1 },
                    { "3", "", "", true, "ACCIDENT CASE", 1 },
                    { "4", "", "", true, "INITIAL VISIT", 1 },
                    { "5", "", "", true, "VACCINATIONS", 1 }
                });

            migrationBuilder.InsertData(
                table: "DoctorHoliday",
                columns: new[] { "DoctorHolidayId", "Created_By", "Created_Date", "DoctorsCode", "HOLIDAYSHoliday_id", "Holiday_id", "IsWorkingDay", "LocationCode", "clinic_Code" },
                values: new object[,]
                {
                    { 1, "System", new DateOnly(2025, 10, 10), "1", null, 1, true, 1, 1 },
                    { 2, "System", new DateOnly(2025, 10, 10), "1", null, 1, false, 1, 1 },
                    { 3, "System", new DateOnly(2025, 10, 10), "1", null, 1, false, 1, 1 },
                    { 4, "System", new DateOnly(2025, 10, 10), "1", null, 1, true, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "DoctorYearlyHoliday",
                columns: new[] { "DoctorYearlyHolidayId", "Created_By", "Created_Date", "DoctorsCode", "Holiday_From", "Holiday_To", "Holiday_date", "Holiday_id", "Holiday_title", "LocationCode", "clinic_Code" },
                values: new object[,]
                {
                    { 1, "System", new DateOnly(2025, 10, 14), "1", new DateOnly(2026, 2, 5), new DateOnly(2026, 2, 5), new DateOnly(2026, 2, 5), 1, "Kashmir Sloidarity Day", 1, 1 },
                    { 2, "System", new DateOnly(2025, 10, 14), "1", new DateOnly(2026, 2, 21), new DateOnly(2026, 2, 21), new DateOnly(2026, 2, 21), 2, "Eid Fitar", 1, 1 },
                    { 3, "System", new DateOnly(2025, 10, 14), "1", new DateOnly(2026, 5, 27), new DateOnly(2026, 5, 27), new DateOnly(2026, 5, 27), 4, "Eid Azha", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Doctor_Working_Days_Time",
                columns: new[] { "Doctor_Working_Days_Time_ID", "Break_Time_From", "Break_Time_To", "Created_By", "Created_Date", "Date_From", "Date_To", "DoctorsCode", "Duration", "Enable_Break", "LocationCode", "Time_From", "Time_To", "Weekday_Id", "clinic_Code" },
                values: new object[] { 1, new DateTime(2025, 10, 14, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 8, 13, 30, 0, 0, DateTimeKind.Unspecified), "System", new DateOnly(2025, 10, 10), new DateTime(2025, 10, 14, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 14, 12, 30, 0, 0, DateTimeKind.Unspecified), "1", 60, true, 1, new DateTime(2025, 10, 14, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 14, 13, 30, 0, 0, DateTimeKind.Unspecified), "1", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_clinic_Type",
                table: "Clinics",
                column: "clinic_Type");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_PHONE_CODE",
                table: "Clinics",
                column: "PHONE_CODE");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Working_Days_Time_clinic_Code",
                table: "Doctor_Working_Days_Time",
                column: "clinic_Code");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Working_Days_Time_DoctorsCode",
                table: "Doctor_Working_Days_Time",
                column: "DoctorsCode");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Working_Days_Time_LocationCode",
                table: "Doctor_Working_Days_Time",
                column: "LocationCode");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorHoliday_clinic_Code",
                table: "DoctorHoliday",
                column: "clinic_Code");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorHoliday_DoctorsCode",
                table: "DoctorHoliday",
                column: "DoctorsCode");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorHoliday_Holiday_id",
                table: "DoctorHoliday",
                column: "Holiday_id");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorHoliday_HOLIDAYSHoliday_id",
                table: "DoctorHoliday",
                column: "HOLIDAYSHoliday_id");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorHoliday_LocationCode",
                table: "DoctorHoliday",
                column: "LocationCode");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorLocations_clinic_Code",
                table: "DoctorLocations",
                column: "clinic_Code");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_clinic_Code",
                table: "Doctors",
                column: "clinic_Code");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorYearlyHoliday_clinic_Code",
                table: "DoctorYearlyHoliday",
                column: "clinic_Code");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorYearlyHoliday_DoctorsCode",
                table: "DoctorYearlyHoliday",
                column: "DoctorsCode");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorYearlyHoliday_Holiday_id",
                table: "DoctorYearlyHoliday",
                column: "Holiday_id");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorYearlyHoliday_LocationCode",
                table: "DoctorYearlyHoliday",
                column: "LocationCode");

            migrationBuilder.CreateIndex(
                name: "IX_ReasonsAppointment_clinic_Code",
                table: "ReasonsAppointment",
                column: "clinic_Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor_Working_Days_Time");

            migrationBuilder.DropTable(
                name: "DoctorHoliday");

            migrationBuilder.DropTable(
                name: "DoctorYearlyHoliday");

            migrationBuilder.DropTable(
                name: "ReasonsAppointment");

            migrationBuilder.DropTable(
                name: "DoctorLocations");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "HOLIDAYS");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "CellNo_Types");

            migrationBuilder.DropTable(
                name: "Clinics_Types");
        }
    }
}
