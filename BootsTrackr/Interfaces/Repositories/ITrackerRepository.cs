using BootsTrackr.Models.Request;
using BootsTrackr.Models.Trackers;

namespace BootsTrackr.Interfaces.Repositories
{
    public interface ITrackerRepository
    { 
        public IEnumerable<TEntity> GetEntitiesByEmployeeId<TEntity>(int employeeId) where TEntity : class;

        public Task AddEmployeeAtv(int employeeId, AddTrackerRequestDTO body);
        
        public Task AddEmployeeIpt(int employeeId, AddTrackerRequestDTO body);
        
        public Task AddEmployeePds(int employeeId, AddTrackerRequestDTO body);
        
        public Task AddEmployeeSale(int employeeId, AddTrackerRequestDTO body);
        
        public Task AddEmployeeFutureRenew(int employeeId, AddTrackerRequestDTO body);

    }
}