namespace ParkRec.Models
{
    public class UserPark
    {
        public string UserId { get; set; }
        public int ParkId { get; set; }
        public Park Park { get; set; }

        public UserPark()
        {
        }
    }
}
