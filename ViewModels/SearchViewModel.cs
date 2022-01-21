using Microsoft.AspNetCore.Mvc.Rendering;
using ParkRec.Models;
using System.Collections.Generic;

namespace ParkRec.ViewModels
{
    public class SearchViewModel
    {
        public int ParkId { get; set; }
        public string ParkName { get; set; }
        public List<Tag> Tags { get; set; }

        public SearchViewModel(List<Tag> tags)
        {
            Tags = tags;
        }

        public SearchViewModel()
        {

        }
    }
}
