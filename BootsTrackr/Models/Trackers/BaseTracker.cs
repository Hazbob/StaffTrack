namespace BootsTrackr.Models.Trackers
{
    public abstract class BaseTracker
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int WeekOfYear { get; set; } 

        protected BaseTracker(int employeeId, int weekOfYear)
        {
            EmployeeId = employeeId;
            WeekOfYear = weekOfYear;
        }
    }
}