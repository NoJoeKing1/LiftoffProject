using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ParkRec.Data;
using ParkRec.Models;
using ParkRec.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ParkRec.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly UserManager<IdentityUser> _UserManager;

        private ParksDbContext context;

        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> _userManager, ParksDbContext dbContext)
        {
            _logger = logger;
            _UserManager = _userManager;
            context = dbContext;
        }
        
        public IActionResult Index()
        {
            string userId = _UserManager.GetUserId(HttpContext.User);
            if(userId != null)
            {
                List<Park> parks = context.Parks.ToList();
                List<Park> savedParks = new List<Park>();
                List<UserPark> savedUserParks = context.UserParks
                    .Where(up => up.UserId == userId)
                    .ToList();

                foreach(Park park in parks)
                {
                    foreach(UserPark savedUserPark in savedUserParks)
                    {
                        if(savedUserPark.ParkId == park.Id)
                        {
                            savedParks.Add(park);
                        }
                    }
                }

                return View(savedParks);
                
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
