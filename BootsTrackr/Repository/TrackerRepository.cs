using System.Linq.Expressions;
using System.Net.Mail;
using BootsTrackr.DataContext;
using BootsTrackr.Interfaces.Repositories;
using BootsTrackr.Models;
using BootsTrackr.Models.Request;
using BootsTrackr.Models.Trackers;

namespace BootsTrackr.Repository
{
    public class TrackerRepository : ITrackerRepository
    {
        private readonly TrackerContext _context;

        public TrackerRepository(TrackerContext context)
        {
            _context = context;
        }
        
        public IEnumerable<TEntity> GetEntitiesByEmployeeId<TEntity>(int employeeId) where TEntity : class
        {
            var dbSet = _context.Set<TEntity>();
    
            // Create a lambda expression representing the property access
            var property = typeof(TEntity).GetProperty("EmployeeId");
            var parameter = Expression.Parameter(typeof(TEntity), "entity");
            var propertyAccess = Expression.Property(parameter, property);
            var filter = Expression.Equal(propertyAccess, Expression.Constant(employeeId));

            // Create a lambda expression representing the filtering condition
            var lambda = Expression.Lambda<Func<TEntity, bool>>(filter, parameter);

            // Use the Where method with the lambda expression
            var entities = dbSet.Where(lambda);

            return entities;
        }

        


        public async Task AddEmployeeAtv(int employeeId, AddTrackerRequestDTO body)
        {
            var newAtv = new ATV(employeeId, body.WeekOfYear, body.Amount);
            await _context.Atvs.AddAsync(newAtv);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeeIpt(int employeeId, AddTrackerRequestDTO body)
        {
            var newIpt = new IPT(employeeId, body.WeekOfYear, body.Quantity);
            await _context.Ipts.AddAsync(newIpt);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeePds(int employeeId, AddTrackerRequestDTO body)
        {
            var newPds = new PDS(employeeId, body.WeekOfYear, body.Quantity);
            await _context.Pdses.AddAsync(newPds);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeeSale(int employeeId, AddTrackerRequestDTO body)
        {
            Console.WriteLine(body.Amount);
            var newSale = new Sale(employeeId, body.WeekOfYear, body.Amount);
            Console.WriteLine(newSale.Amount);
            await _context.Sales.AddAsync(newSale);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeeFutureRenew(int employeeId, AddTrackerRequestDTO body)
        {
            var newFutureRenew = new FutureRenew(employeeId, body.WeekOfYear, body.Quantity);
            await _context.FutureRenews.AddAsync(newFutureRenew);
            await _context.SaveChangesAsync();
        }

    }
}