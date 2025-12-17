using System;
using System.Collections.Generic;

namespace BankingWebApp.BankingModels;

public partial class AuditLog
{
    public decimal LogId { get; set; }

    public string? Action { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? UserName { get; set; }
}
