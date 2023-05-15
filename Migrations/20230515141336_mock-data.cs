using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace personnel_access_control.Migrations
{
    /// <inheritdoc />
    public partial class mockdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CompanyBranches",
                columns: new[] { "CompanyBranchId", "Location" },
                values: new object[,]
                {
                    { 1, "Argentina" },
                    { 2, "Brasil" },
                    { 3, "España" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { 2, "Delfina", 1, "Torres" },
                    { 3, "Bianca", 1, "Perez" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyBranches",
                keyColumn: "CompanyBranchId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompanyBranches",
                keyColumn: "CompanyBranchId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompanyBranches",
                keyColumn: "CompanyBranchId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);
        }
    }
}
