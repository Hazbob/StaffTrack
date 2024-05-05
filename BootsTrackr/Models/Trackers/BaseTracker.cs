namespace BootsTrackr.Models.Trackers
{
    public abstract class BaseTracker
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        private int _weekOfYear;
        public int WeekOfYear
        {
            get { return _weekOfYear; }
            set
            {
                if (value < 1 || value > 52)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Week of the year must be between 1 and 52.");
                }
                _weekOfYear = value;
            }
        }

        protected BaseTracker(int employeeId, int week)
        {
            EmployeeId = employeeId;
            WeekOfYear = week;
        }
    }
}