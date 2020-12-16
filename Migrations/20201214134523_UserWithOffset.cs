using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsForum.Migrations
{
    public partial class UserWithOffset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimeZoneOffset",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeZoneOffset",
                table: "AspNetUsers");
        }
    }
}
