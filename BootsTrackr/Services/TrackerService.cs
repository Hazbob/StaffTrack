using BootsTrackr.Interfaces.Repositories;
using BootsTrackr.Interfaces.Services;
using BootsTrackr.Models.Request;
using BootsTrackr.Models.Trackers;

namespace BootsTrackr.Services
{
    public class TrackerService : ITrackerService
    {
        private readonly ITrackerRepository _trackerRepository;

        public TrackerService(ITrackerRepository trackerRepository)
        {
            _trackerRepository = trackerRepository;
        }

        //GET
        public IEnumerable<ATV> GetATVsByEmployeeId(int employeeId)
        {
            var atvs =_trackerRepository.GetEntitiesByEmployeeId<ATV>(employeeId);
            return atvs;
        }

        public IEnumerable<IPT> GetIPTsByEmployeeId(int employeeId)
        {
            var ipts =_trackerRepository.GetEntitiesByEmployeeId<IPT>(employeeId);
            return ipts;
        }

        public IEnumerable<PDS> GetPDSByEmployeeId(int employeeId)
        {
            var pds = _trackerRepository.GetEntitiesByEmployeeId<PDS>(employeeId);
            return pds;
        }

        public IEnumerable<Sale> GetSalesByEmployeeId(int employeeId)
        {
            var sales = _trackerRepository.GetEntitiesByEmployeeId<Sale>(employeeId);
            return sales;
        }

        public IEnumerable<FutureRenew> GetFutureRenewsByEmployeeId(int employeeId)
        {
            var futureRenews = _trackerRepository.GetEntitiesByEmployeeId<FutureRenew>(employeeId);
            return futureRenews;
        }
        
        
        //POST
        public async  Task AddEmployeeAtv(int employeeId, AddTrackerRequestDTO body)
        {
            await _trackerRepository.AddEmployeeAtv(employeeId, body);
        }

        public async Task AddEmployeeIpt(int employeeId, AddTrackerRequestDTO body)
        {
            await _trackerRepository.AddEmployeeIpt(employeeId, body);
        }

        public async Task AddEmployeePds(int employeeId, AddTrackerRequestDTO body)
        {
            await _trackerRepository.AddEmployeePds(employeeId, body);
        }

        public async Task AddEmployeeSale(int employeeId, AddTrackerRequestDTO body)
        {
            await _trackerRepository.AddEmployeeSale(employeeId, body);

        }

        public async Task AddEmployeeFutureRenew(int employeeId, AddTrackerRequestDTO body)
        {
            await _trackerRepository.AddEmployeeFutureRenew(employeeId, body);

        }
    }
}