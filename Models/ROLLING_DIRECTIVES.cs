using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class ROLLING_DIRECTIVES
{
    public decimal? DIRECTID { get; set; }

    public decimal? PHASE { get; set; }

    public decimal? TASKID { get; set; }

    public string? FEATURE { get; set; }

    public string? DESCRIPTION { get; set; }

    public decimal? TARGET { get; set; }

    public string? FLAGS { get; set; }

    public decimal? OPCODE { get; set; }

    public string? P1 { get; set; }

    public string? P2 { get; set; }

    public string? P3 { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }
}
