using EmployeeList.Models;
namespace EmployeeList.Repositories;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllEmployees();
    Task<Employee> GetEmployee(int id);
}