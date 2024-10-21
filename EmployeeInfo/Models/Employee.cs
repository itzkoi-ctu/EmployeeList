using System;
using System.Collections.Generic;

namespace EmployeeInfo.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public int EducationId { get; set; }

    public int DepartmentId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual Education Education { get; set; } = null!;
}
