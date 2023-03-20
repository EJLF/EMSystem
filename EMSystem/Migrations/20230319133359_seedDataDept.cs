using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMSystem.Migrations
{
    public partial class seedDataDept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "EmpId",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2023, 3, 19, 21, 33, 58, 737, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "EmpId",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2023, 3, 19, 21, 33, 58, 737, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "EmpId",
                keyValue: 3,
                column: "DOB",
                value: new DateTime(2023, 3, 19, 21, 33, 58, 737, DateTimeKind.Local).AddTicks(4216));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "EmpId",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2023, 3, 19, 21, 33, 32, 575, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "EmpId",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2023, 3, 19, 21, 33, 32, 575, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "EmpId",
                keyValue: 3,
                column: "DOB",
                value: new DateTime(2023, 3, 19, 21, 33, 32, 575, DateTimeKind.Local).AddTicks(6943));
        }
    }
}
