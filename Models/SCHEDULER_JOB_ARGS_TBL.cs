using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class SCHEDULER_JOB_ARGS_TBL
{
    public string? OWNER { get; set; }

    public string? JOB_NAME { get; set; }

    public string? ARGUMENT_NAME { get; set; }

    public decimal? ARGUMENT_POSITION { get; set; }

    public string? ARGUMENT_TYPE { get; set; }

    public string? VALUE { get; set; }

    public string? OUT_ARGUMENT { get; set; }
}
