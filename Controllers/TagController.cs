using Microsoft.AspNetCore.Mvc;
using ParkRec.Data;
using ParkRec.Models;
using ParkRec.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ParkRec.Controllers
{
    public class TagController : Controller
    {
        private ParksDbContext context;

        public TagController(ParksDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<Tag> tags = context.Tags.ToList();

            return View(tags);  
        }
        public IActionResult Add()
        {
            Tag tag = new Tag();

            return View(tag);
        }

        [HttpPost]
        public IActionResult Add(Tag tag)
        {
            if (ModelState.IsValid)
            {
                context.Tags.Add(tag);
                context.SaveChanges();
                return Redirect("/Tag/");
            }

            return View("Add", tag);   
        }

        public IActionResult AddPark(int id)
        {
            Park thePark = context.Parks.Find(id);
            List<Tag> possibleTags = context.Tags.ToList();

            AddParkTagViewModel viewModel = new AddParkTagViewModel(thePark, possibleTags);

            return View(viewModel); 
        }

        [HttpPost]
        public IActionResult AddPark(AddParkTagViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                int parkId = viewModel.ParkId;
                int tagId = viewModel.TagId;

                List<ParkTag> existingItems = context.ParkTags
                    .Where(pt=>pt.ParkId == parkId)
                    .Where(pt=>pt.TagId == tagId)
                    .ToList();

                if(existingItems.Count == 0)
                {
                    ParkTag parkTag = new ParkTag
                    {
                        ParkId = parkId,
                        TagId = tagId
                    };

                    context.ParkTags.Add(parkTag);
                    context.SaveChanges();
                }

                return Redirect("Park/Detail/" + parkId);
            }

            return View(viewModel);
        }
    }
}
