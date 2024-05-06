namespace BootsTrackr.Models.Trackers
{
    public class FutureRenew : BaseTracker
    {
        public int Quantity { get; set; }

        public FutureRenew(int employeeId, int weekOfYear, int quantity) : base(employeeId, weekOfYear)
        {
            Quantity = quantity;
        }
    }
}