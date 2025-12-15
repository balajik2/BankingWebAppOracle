using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Output table for dimension validations
/// </summary>
public partial class MVIEW__ADV_EXCEPTIONS
{
    public decimal? RUNID_ { get; set; }

    public string? OWNER { get; set; }

    public string? TABLE_NAME { get; set; }

    public string? DIMENSION_NAME { get; set; }

    public string? RELATIONSHIP { get; set; }

    public string? BAD_ROWID { get; set; }

    public virtual MVIEW__ADV_LOG? RUNID_Navigation { get; set; }
}
