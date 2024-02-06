using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nexu_SMS.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdmissionNoTable",
                columns: table => new
                {
                    admissionNo = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionNoTable", x => x.admissionNo);
                });

            migrationBuilder.CreateTable(
                name: "Class_Table",
                columns: table => new
                {
                    ClassId = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    ClassName = table.Column<string>(name: "Class Name", type: "nvarchar(max)", nullable: false),
                    Schedule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Teacherid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Student = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class_Table", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Student_Attendance_Table",
                columns: table => new
                {
                    attendanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    studentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Attendance_Table", x => x.attendanceId);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    FirstName = table.Column<string>(name: "First Name", type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(name: "Last Name", type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(name: "E-mail", type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Class = table.Column<int>(type: "int", nullable: false),
                    Section = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher_Attendance_Table",
                columns: table => new
                {
                    attendanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    teacherId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher_Attendance_Table", x => x.attendanceId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    teacherId = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    teacherFirstName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    teacherLastName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    dateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    teacherGender = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    teacherSubjectTaught = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    teacherEmail = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    teacherPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    teacherAddress = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    teacherClass = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.teacherId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    userName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    password = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    role = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmissionNoTable");

            migrationBuilder.DropTable(
                name: "Class_Table");

            migrationBuilder.DropTable(
                name: "Student_Attendance_Table");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "Teacher_Attendance_Table");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
