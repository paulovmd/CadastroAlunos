using Microsoft.AspNetCore.Mvc;

namespace CadastroAlunos.Controllers
{
    public class AlunoController : Controller
    {
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
                    
        public IActionResult CadastroAluno()
        {
            ViewBag.Titulo = "Cadastro de Alunos";
            return View();
        }

    }
}