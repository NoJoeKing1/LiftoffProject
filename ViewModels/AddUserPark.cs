using ParkRec.Models;

namespace ParkRec.ViewModels
{
    public class AddUserPark
    {
        public int ParkId { get; set; }
        public Park Park { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}
