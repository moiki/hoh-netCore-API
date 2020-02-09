using Microsoft.EntityFrameworkCore.Migrations;

namespace hohsys.API.Migrations
{
    public partial class userModification1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fullname",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "lastname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lastname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "name",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "fullname",
                table: "AspNetUsers",
                type: "text",
                nullable: true);
        }
    }
}
