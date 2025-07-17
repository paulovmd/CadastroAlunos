using System.ComponentModel.DataAnnotations;

namespace CadastroAlunos.Models
{
    public class Aluno
    {        
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get;  set; } = string.Empty;
        
    }
}