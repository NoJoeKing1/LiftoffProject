using ParkRec.Models;
using System.Collections.Generic;

namespace ParkRec.ViewModels
{
    public class AddUserPark
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public Park Park { get; set; }
        public int ParkId { get; set; }
        
    }
}
