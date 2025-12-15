using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class MVIEW_EXCEPTIONS
{
    public decimal? RUNID { get; set; }

    public string? OWNER { get; set; }

    public string? TABLE_NAME { get; set; }

    public string? DIMENSION_NAME { get; set; }

    public string? RELATIONSHIP { get; set; }

    public string? BAD_ROWID { get; set; }
}
