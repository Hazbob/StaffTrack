namespace BootsTrackr.Models.Trackers
{
    public class IPT : BaseTracker
    {
        public double Amount { get; set; }
        
        public IPT(int employeeId, int weekOfYear, double amount) : base(employeeId, weekOfYear)
        {
            Amount = amount;
        }
     
    }
}