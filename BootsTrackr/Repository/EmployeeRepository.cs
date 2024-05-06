using BootsTrackr.DataContext;
using BootsTrackr.Errors;
using BootsTrackr.Interfaces.Repositories;
using BootsTrackr.Models;
using BootsTrackr.Models.Request;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BootsTrackr.Repository
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly TrackerContext _context;

        public EmployeeRepository(TrackerContext context)
        {
            _context = context;
        }
        
        
        public Employee GetEmployee(int employeeId)
        {
           Employee? employee = _context.Employees.FirstOrDefault(emp => emp.Id == employeeId);
           if (employee is null)
           {
               throw new EmployeeDoesNotExist();
           }

           return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            var employees = _context.Employees.ToList();
            if (employees.Count == 0)
            {
                throw new EmployeeDoesNotExist(); //todo implement custom error for no employees
            }

            return employees;
        }

        public async Task<Employee> CreateEmployee(EmployeeCreationDTO employeeDetails)
        {
            if (employeeDetails.FirstName.IsNullOrEmpty() || employeeDetails.LastName.IsNullOrEmpty())
            {
                throw new ArgumentNullException("employeeDetails");
            }

            var newEmployee = new Employee()
            {
                FirstName = employeeDetails.FirstName,
                LastName = employeeDetails.LastName
            };

            await _context.Employees.AddAsync(newEmployee);
            await _context.SaveChangesAsync();

            return newEmployee;

        }

        public async Task RemoveEmployee(int employeeId)
        {
            
            var employee = await _context.Employees.FirstOrDefaultAsync(emp => emp.Id == employeeId);
            if (employee is null)
            {
                throw new EmployeeDoesNotExist();
            }
            
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }
    }
}