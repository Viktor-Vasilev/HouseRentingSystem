using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        public async Task<IActionResult> All()
        {


            return View();
        }
    }
}
