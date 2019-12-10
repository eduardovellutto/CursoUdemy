using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class planilha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Curso",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "User",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Curso",
                table: "User");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "User");
        }
    }
}
