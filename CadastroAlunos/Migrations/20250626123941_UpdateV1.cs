using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroAlunos.Migrations
{
    /// <inheritdoc />
    public partial class UpdateV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Alunos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Alunos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Alunos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Alunos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Alunos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Alunos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Alunos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Alunos");
        }
    }
}
