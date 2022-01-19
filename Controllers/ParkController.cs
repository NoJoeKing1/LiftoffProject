using Microsoft.AspNetCore.Mvc;
using NationalParkRecommendation.Data;
using NationalParkRecommendation.Models;
using NationalParkRecommendation.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace NationalParkRecommendation.Controllers
{
    public class ParkController : Controller
    {
        private ParksDbContext context;

        public ParkController(ParksDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<Park> parks = context.Parks.ToList();
            return View(parks);
        }

        public IActionResult Add()
        {
            AddParkViewModel addParkViewModel = new AddParkViewModel(); 
            return View(addParkViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddParkViewModel addParkViewModel)
        {
            if (ModelState.IsValid)
            {
                Park newPark = new Park
                {
                    Name = addParkViewModel.Name,
                    Location = addParkViewModel.Location,
                    Description = addParkViewModel.Description
                };

                context.Parks.Add(newPark);
                context.SaveChanges();

                return Redirect("/Park/Index");
            }
            
            return View(addParkViewModel);
        }
    }
}
