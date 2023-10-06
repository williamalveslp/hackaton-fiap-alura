using HackatonFIAPAlura.Web.Models;
using HackatonFIAPAlura.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HackatonFIAPAlura.Web.Controllers;

public class EquipamentsController : Controller
{
    public static List<Equipment> _equipaments = new List<Equipment>();
 
    public EquipamentsController()
    {
    }
    public IActionResult List()
    {
        var partnerViewModels = _equipaments.Select(p => new EquipamentListViewModel
        {
            Id = p.Id,
            DonorName = p.DonorName,
            EquipmentName = p.EquipmentName,
            IsAPiece = p.IsAPiece,
            IsInGoodCondition = p.IsInGoodCondition
        });

        return View("List", partnerViewModels);
    }

    public IActionResult Enroll()
    {
        var viewModel = new EquipamentEnrollViewModel();
        return View(viewModel);
    }

    [HttpPost]
    [Route("Equipaments/SaveEquipament")]
    public IActionResult SaveEquipament([FromBody] EquipamentEnrollViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            _equipaments.Add(new Equipment(viewModel.EquipmentName, viewModel.IsInGoodCondition, viewModel.IsAPiece, viewModel.DonorName));
            return Ok();
        }

        return View("Home");
    }
}