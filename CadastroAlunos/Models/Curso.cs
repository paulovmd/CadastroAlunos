using System.ComponentModel.DataAnnotations;

namespace CadastroAlunos.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;
    }
}