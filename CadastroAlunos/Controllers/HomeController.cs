using Microsoft.AspNetCore.Mvc;

namespace CadastroAluno.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}