namespace ParkRec.Models
{
    public class UserPark
    {
        public int ParkId { get; set; }
        public Park Park { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }

        public UserPark()
        {
        }
    }
}
