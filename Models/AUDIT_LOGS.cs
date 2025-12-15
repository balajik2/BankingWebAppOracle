using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class AUDIT_LOGS
{
    public decimal LOG_ID { get; set; }

    public string? ACTION { get; set; }

    public DateTime? ACTION_DATE { get; set; }

    public string? USER_NAME { get; set; }
}
