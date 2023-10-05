using Microsoft.AspNetCore.Mvc;

namespace HackatonFIAPAlura.Web.Controllers
{
    public class SchoolsController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
