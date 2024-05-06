namespace BootsTrackr.Models.Trackers
{
    public class Sale : BaseTracker
    {
        public double Amount { get; set; }
        
        public Sale (int employeeId, int weekOfYear, double amount) : base(employeeId, weekOfYear)
        {
            Amount = amount;
        }
    }
}