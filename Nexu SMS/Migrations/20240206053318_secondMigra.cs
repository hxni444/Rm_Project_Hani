using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nexu_SMS.Migrations
{
    /// <inheritdoc />
    public partial class secondMigra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Attendance_Table_students_studentId",
                table: "Student_Attendance_Table");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Attendance_Table_Teachers_teacherId",
                table: "Teacher_Attendance_Table");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_Attendance_Table_teacherId",
                table: "Teacher_Attendance_Table");

            migrationBuilder.DropIndex(
                name: "IX_Student_Attendance_Table_studentId",
                table: "Student_Attendance_Table");

            migrationBuilder.AlterColumn<string>(
                name: "teacherId",
                table: "Teacher_Attendance_Table",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "studentId",
                table: "Student_Attendance_Table",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "teacherId",
                table: "Teacher_Attendance_Table",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "studentId",
                table: "Student_Attendance_Table",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Attendance_Table_teacherId",
                table: "Teacher_Attendance_Table",
                column: "teacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Attendance_Table_studentId",
                table: "Student_Attendance_Table",
                column: "studentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Attendance_Table_students_studentId",
                table: "Student_Attendance_Table",
                column: "studentId",
                principalTable: "students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Attendance_Table_Teachers_teacherId",
                table: "Teacher_Attendance_Table",
                column: "teacherId",
                principalTable: "Teachers",
                principalColumn: "teacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
