using EmployeeInfo.Models;


namespace EmployeeInfo.Reposiotries;

    public class EmployeeRepository: IEmployeeRepository{
        public EmployeesContext employeesContext;


        public EmployeeRepository(EmployeesContext employeesContext){
            this.employeesContext=employeesContext;
        }
        public async Task<IEnumerable<Employee>> GetAllEmployee(){
            return employeesContext.Employees;
        }

    public async Task<Employee> GetEmployee(int id)
    {
        return (from emloyee in employeesContext.Employees
            where emloyee.Id== id
            select emloyee
        ).First();
    }

   
}

