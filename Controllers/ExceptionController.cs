using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    public class ExceptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
