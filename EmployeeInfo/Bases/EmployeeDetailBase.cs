


using EmployeeInfo.Models;
using EmployeeInfo.Reposiotries;
using Microsoft.AspNetCore.Components;
namespace EmployeeInfo.Bases{
public class EmploueeDetailBase: ComponentBase{

    public Employee employee= new Employee();

    [Inject]
    public IEmployeeRepository employeeRepository{get;set;}

    [Parameter]
    public string id{get;set;}

    protected override async Task OnInitializedAsync(){
        id= id ?? "1";


        employee= await employeeRepository.GetEmployee(int.Parse(id));
    }


}
}