using System.Collections.Generic;
using BootsTrackr.Models.Trackers;

namespace BootsTrackr.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Sale>? Sales { get; set; }
        public ICollection<FutureRenew>? FutureRenews { get; set; }
        public ICollection<IPT>? Ipts { get; set; }
        public ICollection<PDS>? Pdses { get; set; }
        public ICollection<ATV>? Atvs { get; set; }
    }
}