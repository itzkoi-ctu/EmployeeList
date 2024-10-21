using EmployeeList.Models;
using EmployeeList.Repositories;
using Microsoft.AspNetCore.Components;


namespace EmployeeList.Bases;


public class EmployeeDetail: ComponentBase{
    public Employee employee = new Employee();
    [Inject]

    public IEmployeeRepository employeeRepository{get; set;}
    [Parameter]
    public string Id{get;set;}
      protected override async Task OnInitializedAsync(){
        Id= Id?? "1";
        Console.WriteLine("=========="+Id);
        employee = await employeeRepository.GetEmployee(int.Parse(Id));

    }



}