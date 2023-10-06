using HackatonFIAPAlura.Web.Models;
using HackatonFIAPAlura.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HackatonFIAPAlura.Web.Controllers
{
    public class SchoolsController : Controller
    {
        public static List<School> _parterns = new List<School>();
        public IActionResult List()
        {
            var partnerViewModels = _parterns.Select(p => new SchoolListViewModel
            {
                Id = p.Id,
                City = p.City,
                SchoolName = p.SchoolName
            });

            return View("List", partnerViewModels);
        }

        public IActionResult Enroll()
        {
            var viewModel = new SchoolEnrollViewModel();
            return View(viewModel);
        }

        [HttpPost]
        [Route("schools/save")]
        public IActionResult Save([FromBody] SchoolEnrollViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _parterns.Add(new School(viewModel.SchoolName, viewModel.City));
                return Ok();
            }

            return View("Home");
        }
    }
}
