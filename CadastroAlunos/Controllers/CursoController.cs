using Microsoft.AspNetCore.Mvc;

namespace CadastroAlunos.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Titulo = "Curso";
            ViewBag.LinkAcao = "/Curso/CadastroCurso";
            return View();
        }

        public IActionResult CadastroCurso()
        {
            ViewBag.Titulo = "Cadastro de Cursos";
            return View();
        }  

    }
}