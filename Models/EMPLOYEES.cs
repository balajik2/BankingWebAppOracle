using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class EMPLOYEES
{
    public decimal EMPLOYEE_ID { get; set; }

    public string FIRST_NAME { get; set; } = null!;

    public string LAST_NAME { get; set; } = null!;

    public string? POSITION { get; set; }

    public decimal? SALARY { get; set; }

    public decimal? BRANCH_ID { get; set; }

    public virtual BRANCHES? BRANCH { get; set; }
}
