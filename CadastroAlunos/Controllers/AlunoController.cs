using CadastroAlunos.Data;
using CadastroAlunos.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroAlunos.Controllers
{
    public class AlunoController : Controller
    {   
        /*Declaração referente a instância de conexão com
        o banco de dados, para que possamos realizar as operações
        de inclusão, alteração, exclusão e buscas.*/        
        private ControleAlunosDBContext cadastroAlunosDBContext;

        public AlunoController(ControleAlunosDBContext context)
        {
            cadastroAlunosDBContext = context;
        }

        public IActionResult Index()
        {
            /*O ViewBag é um recurso do Asp.NET quando é
            preciso declarar variáveis SIMPLES que precisam
            exibir valores mais básicos na página, como 
            por exemplo, alterar o nome do título de uma página*/
            ViewBag.Titulo = "Aluno";
            ViewBag.LinkAcao = "/Aluno/CadastroAluno";
            return View();
        }

        /*
            Este método é utilizado para chamar o formulário
            de cadastro de aluno. Neste caso, chamando a página,
            CadastroAluno.cshtml
        */
        public IActionResult CadastroAluno()
        {
            /*O ViewBag é um recurso do Asp.net Core utilizado para declarar variáveis
            que precisam ser utilizadas entre o Código C# e as páginas cshtml. Desta forma,
            ao declarar a variável no código C# podemos utilizar elas nas páginas da aplicação.*/
            ViewBag.Titulo = "Cadastro de Alunos";
            ViewBag.Acao = "IncluirAluno";
            return View();
        }

        /*Método Responsável por incluir um novo Aluno. Esse método utiliza o verbo POST 
        para enviar os dadosdo formulário de cadastro e redireciona para o página
        principal após ser realizado.*/
        /*Todo parâmetro que for uma entidade DEVE ser marcado antes do tipo com
        o [FromForm] para informar que os dados serão passados através de um formulário.*/
        [HttpPost]    
        public IActionResult IncluirAluno([FromForm]Aluno aluno)
        {   
            //Redireciona para o página Index da área do Cadastro de Alunos
            return View("Index");
        }
        


    }
}