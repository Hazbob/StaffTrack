using System.Collections.Generic;
using System.Threading.Tasks;
using BootsTrackr.Interfaces.Repositories;
using BootsTrackr.Interfaces.Services;
using BootsTrackr.Models;
using BootsTrackr.Models.Request;

namespace BootsTrackr.Services
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public Employee GetEmployee(int employeeId)
        {
            var employee = _employeeRepository.GetEmployee(employeeId);
          
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            var employees = _employeeRepository.GetAllEmployees();
            return employees;
        }

        public Employee CreateEmployee(EmployeeCreationDTO body)
        {
            var employee = _employeeRepository.CreateEmployee(body);
            return employee.Result;
        }

        public async Task RemoveEmployee(int employeeId)
        {
            await _employeeRepository.RemoveEmployee(employeeId);
        }
    }
}