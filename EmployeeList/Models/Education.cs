using System;
using System.Collections.Generic;

namespace EmployeeList.Models;

public partial class Education
{
    public int Id { get; set; }

    public string EducationLevel { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
