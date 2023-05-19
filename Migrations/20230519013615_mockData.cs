using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace personnel_access_control.Migrations
{
    /// <inheritdoc />
    public partial class mockData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyBranches",
                columns: table => new
                {
                    CompanyBranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBranches", x => x.CompanyBranchId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Accesses",
                columns: table => new
                {
                    AccessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccessType = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CompanyBranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accesses", x => x.AccessId);
                    table.ForeignKey(
                        name: "FK_Accesses_CompanyBranches_CompanyBranchId",
                        column: x => x.CompanyBranchId,
                        principalTable: "CompanyBranches",
                        principalColumn: "CompanyBranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accesses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { 1, "Lucas", 0, "Rodriguez" },
                    { 2, "Delfina", 1, "Torres" },
                    { 3, "Bianca", 1, "Perez" },
                    { 4, "Juan", 0, "Gonzalez" },
                    { 5, "Sofia", 1, "Lopez" },
                    { 6, "Diego", 0, "Fernandez" },
                    { 7, "Valentina", 1, "Silva" },
                    { 8, "Mateo", 0, "Hernandez" },
                    { 9, "Isabella", 1, "Gomez" },
                    { 10, "Martin", 0, "Pereira" },
                    { 11, "Camila", 1, "Rojas" },
                    { 12, "Joaquin", 0, "Luna" },
                    { 13, "Mia", 1, "Fuentes" },
                    { 14, "Facundo", 0, "Mendoza" },
                    { 15, "Valeria", 1, "Castillo" },
                    { 16, "Ignacio", 0, "Navarro" },
                    { 17, "Luz", 1, "Santos" },
                    { 18, "Emilio", 0, "Paz" },
                    { 19, "Catalina", 1, "Cardenas" },
                    { 20, "Sebastian", 0, "Ramos" }
                });

            migrationBuilder.InsertData(
                table: "Accesses",
                columns: new[] { "AccessId", "AccessDateTime", "AccessType", "CompanyBranchId", "EmployeeId" },
                values: new object[,]
                {
                    { 30, new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 1 },
                    { 31, new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 5 },
                    { 32, new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 10 },
                    { 33, new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 3 },
                    { 34, new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 7 },
                    { 35, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 15 },
                    { 36, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 12 },
                    { 37, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 18 },
                    { 38, new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 6 },
                    { 39, new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 9 },
                    { 40, new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 18 },
                    { 41, new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 4 },
                    { 42, new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 15 },
                    { 43, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 8 },
                    { 44, new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 9 },
                    { 45, new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 13 },
                    { 46, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 1 },
                    { 47, new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 5 },
                    { 48, new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 },
                    { 49, new DateTime(2022, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 20 },
                    { 50, new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 3 },
                    { 51, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 17 },
                    { 52, new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 11 },
                    { 53, new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 12 },
                    { 54, new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 16 },
                    { 55, new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 7 },
                    { 56, new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 19 },
                    { 57, new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 6 },
                    { 58, new DateTime(2022, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 14 },
                    { 59, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 2 },
                    { 60, new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 8 },
                    { 61, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 6 },
                    { 62, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 19 },
                    { 63, new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 13 },
                    { 64, new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 14 },
                    { 65, new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 20 },
                    { 66, new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 8 },
                    { 67, new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 4 },
                    { 68, new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 1 },
                    { 69, new DateTime(2022, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 10 },
                    { 70, new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 5 },
                    { 71, new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 11 },
                    { 72, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 17 },
                    { 73, new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 15 },
                    { 74, new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 12 },
                    { 75, new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 7 },
                    { 76, new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 9 },
                    { 77, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 16 },
                    { 78, new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 3 },
                    { 79, new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 18 },
                    { 80, new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 2 },
                    { 81, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 12 },
                    { 82, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 19 },
                    { 83, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 5 },
                    { 84, new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 11 },
                    { 85, new DateTime(2022, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 17 },
                    { 86, new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 6 },
                    { 87, new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 3 },
                    { 88, new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 9 },
                    { 89, new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 20 },
                    { 90, new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 14 },
                    { 91, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 18 },
                    { 92, new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 4 },
                    { 93, new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 7 },
                    { 94, new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 16 },
                    { 95, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 2 },
                    { 96, new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 10 },
                    { 97, new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15 },
                    { 98, new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 8 },
                    { 99, new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 },
                    { 100, new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 19 },
                    { 101, new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 14 },
                    { 102, new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 20 },
                    { 103, new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 6 },
                    { 104, new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 10 },
                    { 105, new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 17 },
                    { 106, new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 5 },
                    { 107, new DateTime(2022, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 108, new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 19 },
                    { 109, new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 2 },
                    { 110, new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 16 },
                    { 111, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 18 },
                    { 112, new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 3 },
                    { 113, new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 7 },
                    { 114, new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 16 },
                    { 115, new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 12 },
                    { 116, new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 9 },
                    { 117, new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 13 },
                    { 118, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 4 },
                    { 119, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 11 },
                    { 120, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 8 },
                    { 121, new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 15 },
                    { 122, new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 2 },
                    { 123, new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 5 },
                    { 124, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 8 },
                    { 125, new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 19 },
                    { 126, new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 10 },
                    { 127, new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 12 },
                    { 128, new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 16 },
                    { 129, new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 1 },
                    { 130, new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 18 },
                    { 131, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 20 },
                    { 132, new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 3 },
                    { 133, new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 6 },
                    { 134, new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 16 },
                    { 135, new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 7 },
                    { 136, new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 14 },
                    { 137, new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 4 },
                    { 138, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 17 },
                    { 139, new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 9 },
                    { 140, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 13 },
                    { 141, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 5 },
                    { 142, new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 17 },
                    { 143, new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 9 },
                    { 144, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 3 },
                    { 145, new DateTime(2022, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 16 },
                    { 146, new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 8 },
                    { 147, new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 12 },
                    { 148, new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 1 },
                    { 149, new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 19 },
                    { 150, new DateTime(2022, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 18 },
                    { 151, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 20 },
                    { 152, new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 2 },
                    { 153, new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 6 },
                    { 154, new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 16 },
                    { 155, new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 },
                    { 156, new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 15 },
                    { 157, new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 11 },
                    { 158, new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 },
                    { 159, new DateTime(2022, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 7 },
                    { 160, new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 9 },
                    { 161, new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 5 },
                    { 181, new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 6 },
                    { 182, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 9 },
                    { 183, new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 17 },
                    { 184, new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 },
                    { 185, new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 19 },
                    { 186, new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 15 },
                    { 187, new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10 },
                    { 188, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 4 },
                    { 189, new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 8 },
                    { 190, new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 18 },
                    { 191, new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 14 },
                    { 192, new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 2 },
                    { 193, new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 7 },
                    { 194, new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 16 },
                    { 195, new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 12 },
                    { 196, new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 20 },
                    { 197, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 3 },
                    { 198, new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 6 },
                    { 199, new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, 17 },
                    { 200, new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 13 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accesses_CompanyBranchId",
                table: "Accesses",
                column: "CompanyBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Accesses_EmployeeId",
                table: "Accesses",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accesses");

            migrationBuilder.DropTable(
                name: "CompanyBranches");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
