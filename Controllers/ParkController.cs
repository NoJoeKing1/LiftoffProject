using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkRec.Data;
using ParkRec.Models;
using ParkRec.ViewModels;
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

        [AllowAnonymous]
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
                    Description = addParkViewModel.Description,
                    ImageLink = addParkViewModel.ImageLink
                };

                context.Parks.Add(newPark);
                context.SaveChanges();

                return Redirect("/Park/Index");
            }
            
            return View(addParkViewModel);
        }

        public IActionResult Detail(int id)
        {
            Park thePark = context.Parks
                .Single(p=>p.Id == id);

            List<ParkTag> parkTags = context.ParkTags
                .Where(pt=>pt.ParkId == id)
                .Include(pt=>pt.Tag)
                .ToList();

            ParkDetailViewModel viewModel = new ParkDetailViewModel(thePark, parkTags);
            return View(viewModel);
        }
    }
}
