using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroAlunos.Models
{
    public class NotaAluno
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Aluno))]
        public int IdAluno { get; set; }

        [ForeignKey(nameof(Curso))]
        public int IdCurso { get; set; }

        public decimal Nota { get; set; }

        /*Utilizado apenas para definir os relacionamentos
        entre as entidades*/
        public Aluno Aluno { get; set; }   

        public Curso Curso { get; set; } 

    }


}