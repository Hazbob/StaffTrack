using System.Collections.Generic;
using System.Threading.Tasks;
using BootsTrackr.Models;
using BootsTrackr.Models.Request;

namespace BootsTrackr.Interfaces.Services
{
    public interface IEmployeeService
    {
        public Employee GetEmployee(int employeeId);

        public IEnumerable<Employee> GetAllEmployees();

        public Employee CreateEmployee(EmployeeCreationDTO body);

        public Task RemoveEmployee(int employeeId);
    }
}