namespace BootsTrackr.Models.Trackers
{
    public class Sale : BaseTracker
    {
        public double Amount { get; set; }
        
        public Sale (int employeeId, int week, double amount) : base(employeeId, week)
        {
            Amount = amount;
        }
    }
}