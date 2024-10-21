using EmployeeInfo.Models;

namespace EmployeeInfo.Reposiotries{
    public interface IEmployeeRepository{
        Task <IEnumerable<Employee>> GetAllEmployee();

        Task <Employee> GetEmployee(int id);
    }
}