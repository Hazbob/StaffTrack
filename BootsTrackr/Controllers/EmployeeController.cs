using BootsTrackr.Errors;
using BootsTrackr.Interfaces.Services;
using BootsTrackr.Models;
using BootsTrackr.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace BootsTrackr.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        // GET
        [HttpGet("employee/{employeeId}")]
        public IActionResult GetEmployee([FromRoute] int employeeId)
        {
            try
            {
                var employee = _employeeService.GetEmployee(employeeId);
                return Ok(employee);
            }
            catch (EmployeeDoesNotExist ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            
        }

        [HttpGet("employees")]
        public IActionResult GetEmployees()
        {
            var employees = _employeeService.GetAllEmployees();
            return Ok(employees);
        }
        
        //POST
        [HttpPost("employee")]
        public IActionResult CreateEmployee(EmployeeCreationDTO body)
        {
            var employee = _employeeService.CreateEmployee(body);
            
            return Created("New employee added",employee);
        }
        
        //UPDATE
        
        //DELETE
     
        [HttpDelete("employee/{employeeId}")]
        public async Task<IActionResult> RemoveEmployee([FromRoute] int employeeId)
        {
            try
            {
                await _employeeService.RemoveEmployee(employeeId);
                return NoContent();
            }
            catch (EmployeeDoesNotExist ex)
            {
                return NotFound("Employee does not exist");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }
    
    }
}