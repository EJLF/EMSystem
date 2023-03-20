using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMSystem.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmpId);
                    table.ForeignKey(
                        name: "FK_employees_departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "departments",
                        principalColumn: "DeptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "DeptId", "DeptName" },
                values: new object[,]
                {
                    { 1, "Information Technology" },
                    { 2, "Human Resources" },
                    { 3, "Marketing" },
                    { 4, "Network Administration" }
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmpId", "DOB", "DepartmentId", "Email", "Name", "Phone" },
                values: new object[] { 1, new DateTime(2023, 3, 19, 21, 33, 32, 575, DateTimeKind.Local).AddTicks(6927), 1, "earljoseph@gmial.com", "Earl Joseph Ferran", "09959632422" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmpId", "DOB", "DepartmentId", "Email", "Name", "Phone" },
                values: new object[] { 2, new DateTime(2023, 3, 19, 21, 33, 32, 575, DateTimeKind.Local).AddTicks(6941), 4, "batangQuipo@gmial.com", "Coco Martin", "09023213749" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmpId", "DOB", "DepartmentId", "Email", "Name", "Phone" },
                values: new object[] { 3, new DateTime(2023, 3, 19, 21, 33, 32, 575, DateTimeKind.Local).AddTicks(6943), 2, "lizasoberano@gmial.com", "Liza Soberano", "09023213749" });

            migrationBuilder.CreateIndex(
                name: "IX_employees_DepartmentId",
                table: "employees",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
