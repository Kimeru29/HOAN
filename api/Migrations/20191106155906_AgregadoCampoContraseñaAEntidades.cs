using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class AgregadoCampoContraseñaAEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contraseña",
                table: "Receptores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contraseña",
                table: "Emisores",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contraseña",
                table: "Receptores");

            migrationBuilder.DropColumn(
                name: "Contraseña",
                table: "Emisores");
        }
    }
}
