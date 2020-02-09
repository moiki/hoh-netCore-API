using Microsoft.EntityFrameworkCore.Migrations;

namespace hohsys.API.Migrations
{
    public partial class ComentsToAbstract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Clinics",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(60)",
                oldMaxLength: 60,
                oldComment: "Name of the clinic");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Clinics",
                type: "character varying(60)",
                maxLength: 60,
                nullable: false,
                comment: "Name of the clinic",
                oldClrType: typeof(string),
                oldMaxLength: 60,
                oldNullable: true);
        }
    }
}
