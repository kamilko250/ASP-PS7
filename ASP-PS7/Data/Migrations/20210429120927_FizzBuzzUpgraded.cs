using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_PS7.Data.Migrations
{
    public partial class FizzBuzzUpgraded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "FizzBuzzes",
                type: "varchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "FizzBuzzes");
        }
    }
}
