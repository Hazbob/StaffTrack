using System.Collections.Generic;
using System.Threading.Tasks;
using BootsTrackr.Models;
using BootsTrackr.Models.Request;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BootsTrackr.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        public Employee GetEmployee(int employeeId);
        public IEnumerable<Employee> GetAllEmployees();
        public Task<Employee> CreateEmployee(EmployeeCreationDTO employeeDetails);
        public Task RemoveEmployee(int employeeId);
    }
}