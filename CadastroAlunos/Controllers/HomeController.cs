using Microsoft.AspNetCore.Mvc;

namespace CadastroAluno.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Titulo = "Home";
            return View();
        }
    }
}