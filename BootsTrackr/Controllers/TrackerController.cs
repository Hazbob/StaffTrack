using BootsTrackr.Interfaces.Services;
using BootsTrackr.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace BootsTrackr.Controllers
{
    public class TrackerController : Controller
    {
        private readonly ITrackerService _trackerService;

        public TrackerController(ITrackerService trackerService)
        {
            _trackerService = trackerService;

        }
        
        //GET
        [HttpGet("{dataType}/{employeeId}")]
        public async Task<IActionResult> GetATVSByEmployeeId([FromRoute]int employeeId, [FromRoute]string dataType)
        {
            Console.WriteLine(dataType);
            IEnumerable<object> employeeData;
            switch (dataType.ToLower())
            {
                case "atv":
                    employeeData = _trackerService.GetATVsByEmployeeId(employeeId);
                    break;
                case "ipt":
                    employeeData = _trackerService.GetIPTsByEmployeeId(employeeId);
                    break;
                case "pds":
                    employeeData = _trackerService.GetPDSByEmployeeId(employeeId);
                    break;
                case "sale":
                    employeeData = _trackerService.GetSalesByEmployeeId(employeeId);
                    break;
                case "futurerenew":
                    employeeData = _trackerService.GetFutureRenewsByEmployeeId(employeeId);
                    break;
                default:
                    return BadRequest("Invalid data type");
            }

            
           return Ok(employeeData);
        }
        
        //POST
        [HttpPost("tracker/atv/{employeeId}")]
        public async Task<IActionResult> AddEmployeeAtv([FromRoute] int employeeId, [FromBody]AddTrackerRequestDTO body)
        {
            try
            {
               await _trackerService.AddEmployeeAtv(employeeId, body);
                return Ok("TrackerAdded");

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        [HttpPost("tracker/ipt/{employeeId}")]
        public async Task<IActionResult> AddEmployeeIpt([FromRoute] int employeeId, [FromBody]AddTrackerRequestDTO body)
        {
            await _trackerService.AddEmployeeIpt(employeeId, body);
            return Ok("TrackerAdded");
        }
        
        [HttpPost("tracker/pds/{employeeId}")]
        public async Task<IActionResult> AddEmployeePds([FromRoute] int employeeId, [FromBody]AddTrackerRequestDTO body)
        {
            await _trackerService.AddEmployeePds(employeeId, body);
            return Ok("TrackerAdded");
        }
        
        [HttpPost("tracker/futurerenew/{employeeId}")]
        public async Task<IActionResult> AddEmployeeFutureRenew([FromRoute] int employeeId, [FromBody]AddTrackerRequestDTO body)
        {
            await _trackerService.AddEmployeeFutureRenew(employeeId, body);
            return Ok("TrackerAdded");
        }
        
        [HttpPost("tracker/sale/{employeeId}")]
        public async Task<IActionResult> AddEmployeeSale([FromRoute] int employeeId, [FromBody]AddTrackerRequestDTO body)
        {
            await _trackerService.AddEmployeeSale(employeeId, body);
            return Ok("TrackerAdded");
        }
        
        
        //DELETE
        
        //UPDATE
    }
}