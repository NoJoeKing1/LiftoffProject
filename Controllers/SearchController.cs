using Microsoft.AspNetCore.Mvc;
using ParkRec.Data;
using ParkRec.Models;
using ParkRec.ViewModels;
using System.Collections.Generic;
using System.Linq;


namespace ParkRec.Controllers
{
    public class SearchController : Controller
    {
        private ParksDbContext context;

        public SearchController(ParksDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<Tag> tags = context.Tags.ToList();
            SearchViewModel searchViewModel = new SearchViewModel(tags);
            return View(searchViewModel);
        }

        public IActionResult Results(string parkName, string[] selectedTags)
        {
            List<Park> parks = context.Parks.ToList();
            /*List<Tag> tags = context.Tags.ToList();*/
            Park resultPark = null;
            List<Park> resultParks = new List<Park>();

            if(parkName != null)
            {
                foreach (Park park in parks)
                {
                    if (park.Name == parkName)
                    {
                        resultPark = park;
                        ViewBag.parks = resultPark;

                    }
                }
            }
            else
            {
                foreach (string tag in selectedTags)
                {
                    List<ParkTag> selectedParkTags = context.ParkTags
                        .Where(pt => pt.TagId == int.Parse(tag))
                        .ToList();
                    foreach(ParkTag parkTag in selectedParkTags)
                    {
                        List<Park> selectedParks = context.Parks
                        .Where(sp => sp.Id == parkTag.ParkId)
                        .ToList();
                        foreach(Park park in selectedParks)
                        {
                            if (!resultParks.Contains(park))
                            {
                                resultParks.Add(park);
                            }                            
                        }
                    }
                    
                }
                ViewBag.parks = resultParks;
            }

            return View("Results");
        }
    }
}
