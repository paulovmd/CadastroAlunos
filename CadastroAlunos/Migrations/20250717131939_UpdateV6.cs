using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroAlunos.Migrations
{
    /// <inheritdoc />
    public partial class UpdateV6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotaAlunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdAluno = table.Column<int>(type: "INTEGER", nullable: false),
                    IdCurso = table.Column<int>(type: "INTEGER", nullable: false),
                    Nota = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaAlunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaAlunos_Alunos_IdAluno",
                        column: x => x.IdAluno,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotaAlunos_Cursos_IdCurso",
                        column: x => x.IdCurso,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotaAlunos_IdAluno",
                table: "NotaAlunos",
                column: "IdAluno");

            migrationBuilder.CreateIndex(
                name: "IX_NotaAlunos_IdCurso",
                table: "NotaAlunos",
                column: "IdCurso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotaAlunos");
        }
    }
}
