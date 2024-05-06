using System.Data.Common;
using BootsTrackr.Models;
using BootsTrackr.Models.Trackers;
using Microsoft.EntityFrameworkCore;

namespace BootsTrackr.DataContext
{
    public class TrackerContext : DbContext
    {
        public TrackerContext(DbContextOptions<TrackerContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ATV> Atvs { get; set; }
        public DbSet<FutureRenew> FutureRenews { get; set; }
        public DbSet<IPT> Ipts { get; set; }
        public DbSet<PDS> Pdses { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<BaseTracker> BaseTrackers { get; set; }
    }
}