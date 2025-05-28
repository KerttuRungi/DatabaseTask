using System;
using System.Collections.Generic;

namespace DatabaseTask.Core.Models;

public partial class Employee
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int EmployeeId { get; set; }

    public int AccessId { get; set; }

    public string Department { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string IdCode { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public int Position { get; set; }
}
