using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class schimbNota2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Note",
                table: "Information",
                newName: "Teza");

            migrationBuilder.AddColumn<int>(
                name: "Nota1",
                table: "Information",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nota2",
                table: "Information",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nota3",
                table: "Information",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nota1",
                table: "Information");

            migrationBuilder.DropColumn(
                name: "Nota2",
                table: "Information");

            migrationBuilder.DropColumn(
                name: "Nota3",
                table: "Information");

            migrationBuilder.RenameColumn(
                name: "Teza",
                table: "Information",
                newName: "Note");
        }
    }
}
