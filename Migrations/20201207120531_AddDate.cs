using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsForum.Migrations
{
    public partial class AddDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Comments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Comments");
        }
    }
}
