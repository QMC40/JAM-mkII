using Microsoft.EntityFrameworkCore.Migrations;

namespace JAM_mkII.Migrations
{
    public partial class StartApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Disqualified",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PassedTest",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disqualified",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "PassedTest",
                table: "Applications");
        }
    }
}
