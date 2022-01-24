using Microsoft.AspNetCore.Mvc;
using ParkRec.Data;

namespace ParkRec.Controllers
{
    public class SavePark : Controller
    {
        private ParksDbContext context;

        public SavePark(ParksDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult SavePark()
        {

        }
    }
