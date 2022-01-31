using Microsoft.AspNetCore.Identity;
using ParkRec.Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace ParkRec.ViewModels
{
    public class ParkDetailViewModel
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string ImageLink { get; set; }

        
        public string TagText { get; set; }

        public ParkDetailViewModel(Park thePark, List<ParkTag> parkTags)
        {
            ParkId = thePark.Id;
            Name = thePark.Name;
            Location = thePark.Location;
            Description = thePark.Description;
            ImageLink = thePark.ImageLink;

            TagText = "";

            for (var i = 0; i < parkTags.Count; i++)
            {
                TagText += "#" + parkTags[i].Tag.Name;

                if (i < parkTags.Count - 1)
                {
                    TagText += ", ";
                }
            }
        }

        
    }
}
