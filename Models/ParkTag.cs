namespace ParkRec.Models
{
    public class ParkTag
    {
        public int ParkId { get; set; }
        public Park Park { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public ParkTag()
        {
        }
    }
}
