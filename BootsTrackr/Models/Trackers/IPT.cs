namespace BootsTrackr.Models.Trackers
{
    public class IPT : BaseTracker
    {
        public double Amount { get; set; }
        
        public IPT(int employeeId, int week, double amount) : base(employeeId, week)
        {
            Amount = amount;
        }
     
    }
}