using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Summary advisor tuning parameters
/// </summary>
public partial class MVIEW__ADV_PARAMETERS
{
    public string PARAMETER_NAME { get; set; } = null!;

    public decimal PARAMETER_TYPE { get; set; }

    public string? STRING_VALUE { get; set; }

    public DateTime? DATE_VALUE { get; set; }

    public decimal? NUMERICAL_VALUE { get; set; }
}
