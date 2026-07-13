using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Class09.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfClasses = table.Column<int>(type: "int", nullable: false),
                    IsActiveCourse = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActiveCourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Courses_ActiveCourseId",
                        column: x => x.ActiveCourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "IsActiveCourse", "Name", "NumberOfClasses" },
                values: new object[,]
                {
                    { 1, false, "C# basic", 40 },
                    { 2, false, "C# Advanced", 60 },
                    { 3, false, "Database development and design", 28 },
                    { 4, false, "ASP.NET Mvc", 40 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActiveCourseId", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(1999, 7, 13, 20, 22, 8, 980, DateTimeKind.Local).AddTicks(7207), "Bob", "Bobski" },
                    { 2, 4, new DateTime(1989, 7, 13, 20, 22, 8, 982, DateTimeKind.Local).AddTicks(5748), "Jill", "Jilski" },
                    { 3, 4, new DateTime(1981, 7, 13, 20, 22, 8, 982, DateTimeKind.Local).AddTicks(5779), "John", "Doe" },
                    { 4, 4, new DateTime(2009, 7, 13, 20, 22, 8, 982, DateTimeKind.Local).AddTicks(5783), "Jane", "Doe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ActiveCourseId",
                table: "Students",
                column: "ActiveCourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
