using BootsTrackr.Models.Request;
using BootsTrackr.Models.Trackers;

namespace BootsTrackr.Interfaces.Services
{
    public interface ITrackerService
    {
        public IEnumerable<ATV> GetATVsByEmployeeId(int employeeId);
        public IEnumerable<IPT> GetIPTsByEmployeeId(int employeeId);
        public IEnumerable<PDS> GetPDSByEmployeeId(int employeeId);
        public IEnumerable<Sale> GetSalesByEmployeeId(int employeeId);
        public IEnumerable<FutureRenew> GetFutureRenewsByEmployeeId(int employeeId);
        public Task AddEmployeeAtv(int employeeId, AddTrackerRequestDTO body);
        
        public Task AddEmployeeIpt(int employeeId, AddTrackerRequestDTO body);

        public Task AddEmployeePds(int employeeId, AddTrackerRequestDTO body);
        
        public Task AddEmployeeSale(int employeeId, AddTrackerRequestDTO body);
        
        public Task AddEmployeeFutureRenew(int employeeId, AddTrackerRequestDTO body);
    }
}