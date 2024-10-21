using EmployeeList.Models;

namespace EmployeeList.Repositories;
public class EmployeeRepository: IEmployeeRepository{


    public EmployeesContext employeesContext;

    public EmployeeRepository(EmployeesContext employeesContext){
        this.employeesContext=employeesContext;
    }

    public async Task<IEnumerable<Employee>> GetAllEmployees(){
        return employeesContext.Employees;
    }

    public async Task<Employee> GetEmployee(int id){
        return (from employee in employeesContext.Employees
            where employee.Id == id 
            select employee
        
        ).First();
    }

}