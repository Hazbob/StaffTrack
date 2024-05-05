namespace BootsTrackr.Models.Trackers
{
    public class FutureRenew : BaseTracker
    {
        public int Quantity { get; set; }

        public FutureRenew(int employeeId, int week, int quantity) : base(employeeId, week)
        {
            Quantity = quantity;
        }
    }
}