using HackatonFIAPAlura.Web.Models;
using HackatonFIAPAlura.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HackatonFIAPAlura.Web.Controllers;

public class DonorsController : Controller
{   
    public static List<Schedule> _schedules = new List<Schedule>();

    public DonorsController()
    {
    }

    public IActionResult List()
    {
        return View();
    }

    public IActionResult Schedule()
    {
        return View();
    }

    [HttpPost]
    [Route("Donors/SaveSchedule")]
    public IActionResult SaveSchedule([FromBody] ScheduleEnrollViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            _schedules.Add(new Schedule(viewModel.Name, viewModel.PersonType, viewModel.Phone, viewModel.Email, viewModel.AvailableDate, viewModel.Description));
            return RedirectToAction("Confirmation");
        }

        return View("Schedule", viewModel);
    }

    public IActionResult Confirmation()
    {
        return View();
    }
}