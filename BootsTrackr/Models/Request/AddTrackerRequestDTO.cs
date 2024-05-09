namespace BootsTrackr.Models.Request
{
    public class AddTrackerRequestDTO
    {
        public double Amount { get; set; } = 0;
        public int WeekOfYear { get; set; } = 0;
        public int Quantity { get; set; } = 0;
    }
}