using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class SQLPLUS_PRODUCT_PROFILE
{
    public string PRODUCT { get; set; } = null!;

    public string? USERID { get; set; }

    public string? ATTRIBUTE { get; set; }

    public string? SCOPE { get; set; }

    public decimal? NUMERIC_VALUE { get; set; }

    public string? CHAR_VALUE { get; set; }

    public DateTime? DATE_VALUE { get; set; }

    public string? LONG_VALUE { get; set; }
}
