namespace BootsTrackr.Models.Trackers
{
    public class ATV : BaseTracker
    {
        public double Amount { get; set; }

        public ATV(int employeeId, int weekOfYear, double amount) : base(employeeId, weekOfYear)
        {
            Amount = amount;
        }
    }
}