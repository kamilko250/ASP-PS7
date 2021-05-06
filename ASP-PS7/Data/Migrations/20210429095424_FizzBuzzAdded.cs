using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_PS7.Data.Migrations
{
    public partial class FizzBuzzAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FizzBuzzes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FizzBuzzes", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FizzBuzzes");
        }
    }
}
