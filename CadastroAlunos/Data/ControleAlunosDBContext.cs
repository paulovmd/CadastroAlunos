using CadastroAlunos.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroAlunos.Data
{
    public class ControleAlunosDBContext : DbContext
    {
        public ControleAlunosDBContext(
              DbContextOptions<ControleAlunosDBContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Curso> Cursos { get; set; }
        
        public DbSet<NotaAluno> NotaAlunos { get; set; }

    }
}