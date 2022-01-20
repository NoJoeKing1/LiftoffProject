using Microsoft.AspNetCore.Mvc.Rendering;
using ParkRec.Models;
using System.Collections.Generic;

namespace ParkRec.ViewModels
{
    public class AddEventTagViewModel
    {

        public int ParkId { get; set; }
        public Park Park { get; set; }

        public List<SelectListItem> Tags { get; set; }

        public int TagId { get; set; }

        public AddEventTagViewModel(Park thePark, List<Tag> possibleTags)
        {
            Tags = new List<SelectListItem>();

            foreach (var tag in possibleTags)
            {
                Tags.Add(new SelectListItem
                {
                    Value = tag.Id.ToString(),
                    Text = tag.Name
                });
            }

            Park = thePark;
        }

        public AddEventTagViewModel()
        {
        }
    }
}
