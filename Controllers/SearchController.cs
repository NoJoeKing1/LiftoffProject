using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkRec.Data;
using ParkRec.Models;
using ParkRec.ViewModels;
using System.Collections.Generic;
using System.Linq;


namespace ParkRec.Controllers
{
    [Authorize]
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
            List<Park> resultParks = new List<Park>();

            if(parkName != null)
            {
                foreach (Park park in parks)
                {
                    if (park.Name == parkName)
                    {
                        Park resultPark = park;
                        resultParks.Add(resultPark);

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
            }
            ResultsViewModel viewModel = new ResultsViewModel(resultParks);
            return View("Results", viewModel);
        }

        
    }
}
