using CadastroAlunos.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroAlunos.Data
{
    public class CadastroAlunosDBContext : DbContext
    {
        public CadastroAlunosDBContext(
              DbContextOptions<CadastroAlunosDBContext> options) : base(options)
        {
            
        }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Curso> Cursos { get; set; }

    }
}