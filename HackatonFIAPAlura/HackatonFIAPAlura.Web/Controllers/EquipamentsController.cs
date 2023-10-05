using HackatonFIAPAlura.Web.Models;
using HackatonFIAPAlura.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HackatonFIAPAlura.Web.Controllers;

public class EquipamentsController : Controller
{
    public static List<Equipment> _schedules = new List<Equipment>();
 
    public EquipamentsController()
    {
    }

    public IActionResult List()
    {
        return View();
    }

    public IActionResult Enroll()
    {
        var viewModel = new EquipamentViewModel();
        return View(viewModel);
    }

    [HttpPost]
    [Route("Equipaments/SaveEquipament")]
    public IActionResult SaveEquipament([FromBody] EquipamentViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            _schedules.Add(new Equipment(viewModel.EquipmentName, viewModel.IsInGoodCondition, viewModel.IsAPiece, viewModel.DonorName));
            return RedirectToAction("Confirmation");
        }

        return View("Home");
    }

    public IActionResult Confirmation()
    {
        return View();
    }
}