using Microsoft.AspNetCore.Mvc;

namespace HackatonFIAPAlura.Web.Controllers
{
    public class EquipamentsController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
