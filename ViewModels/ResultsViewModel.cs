using ParkRec.Models;
using System.Collections.Generic;

namespace ParkRec.ViewModels
{
    public class ResultsViewModel
    {
        public List<Park> ParkResults { get; set; }

        public ResultsViewModel(List<Park> parks)
        {
            ParkResults = parks;
        }
    }
}
