using System;
using System.Collections.Generic;

namespace DatabaseTask.Core.Models;

public partial class Child
{
    public int ChildId { get; set; }

    public string FirstName { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public int EmployeeId { get; set; }
}
