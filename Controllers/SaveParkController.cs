using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ParkRec.Data;
using ParkRec.Models;
using System.Collections.Generic;
using System.Linq;

namespace ParkRec.Controllers
{
    public class SaveParkController : Controller
    {
        private ParksDbContext context;

        private readonly UserManager<IdentityUser> _UserManager;

        public SaveParkController(ParksDbContext dbContext, UserManager<IdentityUser> _userManager)
        {
            context = dbContext;
           _UserManager = _userManager;
        }
        
        [Authorize]
        [HttpPost]
        public IActionResult Save(int parkId)
        {
            string userId = _UserManager.GetUserId(HttpContext.User);
            List<UserPark> existingItems = context.UserParks
                    .Where(up => up.ParkId == parkId)
                    .Where(up => up.UserId == userId)
                    .ToList();
            if (existingItems.Count == 0)
            {
                UserPark userPark = new UserPark
                {
                    UserId = userId,
                    ParkId = parkId
                };
                context.UserParks.Add(userPark);
                context.SaveChanges();
            }
            

            return Redirect("/Park/Detail/" + parkId);
        }
    }
}
