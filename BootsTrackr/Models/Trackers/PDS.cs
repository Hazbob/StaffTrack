namespace BootsTrackr.Models.Trackers
{
    public class PDS : BaseTracker
    {
        public int Quantity { get; set; }
        
        public PDS(int employeeId, int week, int quantity) : base(employeeId, week)
        {
            Quantity = quantity;
        }
    }
}