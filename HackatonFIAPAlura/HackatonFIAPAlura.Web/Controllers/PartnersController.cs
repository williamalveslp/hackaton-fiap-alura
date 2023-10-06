using HackatonFIAPAlura.Web.Models;
using HackatonFIAPAlura.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HackatonFIAPAlura.Web.Controllers;

public class PartnersController : Controller
{
    public static List<Partner> _parterns = new List<Partner>();

    public IActionResult List()
    {
        var partnerViewModels = _parterns.Select(p => new PartnerListViewModel
        {
            Id = p.Id,
            Name = p.Name,
            City = p.City,
            Specialist = p.Specialist
        });

        return View("List", partnerViewModels);
    }

    public IActionResult Enroll()
    {
        var viewModel = new EquipamentEnrollViewModel();
        return View(viewModel);
    }

    [HttpPost]
    [Route("parterns/save")]
    public IActionResult Save([FromBody] PartnerEnrollViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            _parterns.Add(new Partner(viewModel.Name, viewModel.City, viewModel.Specialist));
            return Ok();
        }

        return View("Home");
    }
}