using Microsoft.AspNetCore.Mvc;
using OfficeHoursCalc.Interfaces;
using OfficeHoursCalc.Models;

namespace OfficeHoursCalc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly IEntryService _entryService;
        public HomeController(IUserService userService, IEntryService entryService)
        {
            _userService = userService;
            _entryService = entryService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userService.GetCurrentUserAsync();
            if (user == null)
            {
                ViewData["Message"] = "Could not get data.";
                return View();
            }

            var entries = _entryService.GetAllByUserId(user.Id);
            ViewData["Title"] = "Home";
            ViewData["Entries"] = entries;
            return View(user);
        }
    }
}
