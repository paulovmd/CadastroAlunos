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
            ViewBag.Titulo = "Cadastro de Alunos";
            return View();
        }

        /*Método Responsável por incluir um novo Aluno.
        Esse método utiliza o verbo POST para enviar os dados
        do formulário de cadastro e redireciona para o página
        principal após ser realizado.*/
        [HttpPost]    
        public IActionResult IncluirAluno(Aluno aluno)
        {   
            //Redireciona para o página Index da área do Cadastro de Alunos
            return View("Index");
        }
        


    }
}