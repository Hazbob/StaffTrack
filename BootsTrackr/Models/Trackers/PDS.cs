namespace BootsTrackr.Models.Trackers
{
    public class PDS : BaseTracker
    {
        public int Quantity { get; set; }
        
        public PDS(int employeeId, int weekOfYear, int quantity) : base(employeeId, weekOfYear)
        {
            Quantity = quantity;
        }
    }
}