using Microsoft.AspNetCore.Mvc;
using NationalParkRecommendation.ViewModels;

namespace NationalParkRecommendation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();

            return View(addUserViewModel);
        }
    }
}
