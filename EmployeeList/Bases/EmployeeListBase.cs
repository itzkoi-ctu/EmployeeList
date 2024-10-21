using EmployeeList.Models;
using EmployeeList.Repositories;

using Microsoft.AspNetCore.Components;

namespace EmployeeList.Bases;

public class EmployeeListBase: ComponentBase{
    [Inject]


    public IEmployeeRepository employeeRepository{get; set;}
    public IEnumerable<Employee> employees{get;set;}

    protected override async Task OnInitializedAsync(){
        employees = await employeeRepository.GetAllEmployees();
    }
}