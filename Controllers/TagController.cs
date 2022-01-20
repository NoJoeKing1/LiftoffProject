using Microsoft.AspNetCore.Mvc;
using ParkRec.Data;
using ParkRec.Models;
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
    }
}
