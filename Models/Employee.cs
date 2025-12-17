using System;
using System.Collections.Generic;

namespace BankingWebApp.BankingModels;

public partial class Employee
{
    public decimal EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Position { get; set; }

    public decimal? Salary { get; set; }

    public decimal? BranchId { get; set; }

    public virtual Branch? Branch { get; set; }
}
