using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ParkRec.Controllers
{
    [Authorize]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public AdministrationController(RoleManager<IdentityRole> rm)
        {
            roleManager = rm;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult */
    }
}
