using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HouseRentingSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Route("/Admin/AdminController/Index/{id?}")]
    [Authorize(Roles = "Administrator")]
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
