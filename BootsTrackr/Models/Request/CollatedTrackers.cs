namespace BootsTrackr.Models.Trackers
{
    public class CollatedTrackersDTO
    {
        public int EmployeeId { get; set; }
        public int WeekOfYear { get; set; }
        public int? FrQuantity { get; set; }
        public double? IptAmount { get; set; }
        public int? PdsQuantity { get; set; }
        public double? SaleAmount { get; set; }
        public double? AtvAmount { get; set; }
    }
}