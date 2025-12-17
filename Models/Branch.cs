using System;
using System.Collections.Generic;

namespace BankingWebApp.BankingModels;

public partial class Branch
{
    public decimal BranchId { get; set; }

    public string BranchName { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string? ManagerName { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
