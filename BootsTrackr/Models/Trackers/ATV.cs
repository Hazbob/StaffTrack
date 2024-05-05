namespace BootsTrackr.Models.Trackers
{
    public class ATV : BaseTracker
    {
        public double Amount { get; set; }

        public ATV(int employeeId, int week, double amount) : base(employeeId, week)
        {
            Amount = amount;
        }
    }
}