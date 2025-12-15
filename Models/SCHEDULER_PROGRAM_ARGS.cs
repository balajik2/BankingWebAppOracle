using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class SCHEDULER_PROGRAM_ARGS
{
    public string OWNER { get; set; } = null!;

    public string PROGRAM_NAME { get; set; } = null!;

    public string? ARGUMENT_NAME { get; set; }

    public decimal ARGUMENT_POSITION { get; set; }

    public string? ARGUMENT_TYPE { get; set; }

    public string? METADATA_ATTRIBUTE { get; set; }

    public string? DEFAULT_VALUE { get; set; }

    public string? OUT_ARGUMENT { get; set; }
}
