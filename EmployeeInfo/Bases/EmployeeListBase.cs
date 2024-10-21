using EmployeeInfo.Models;
using EmployeeInfo.Reposiotries;
using Microsoft.AspNetCore.Components;


namespace EmployeeInfo.Bases{
    public class EmployeeListBase:  ComponentBase{
        [Inject]

        public IEmployeeRepository employeeRepository{get;set;}


        public IEnumerable<Employee> employees{get;set;}



    protected override async Task OnInitializedAsync(){
        employees= await employeeRepository.GetAllEmployee();
    }
    }
}