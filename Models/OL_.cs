using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class OL_
{
    public string? OL_NAME { get; set; }

    public string? SQL_TEXT { get; set; }

    public decimal? TEXTLEN { get; set; }

    public Guid? SIGNATURE { get; set; }

    public decimal? HASH_VALUE { get; set; }

    public decimal? HASH_VALUE2 { get; set; }

    public string? CATEGORY { get; set; }

    public string? VERSION { get; set; }

    public string? CREATOR { get; set; }

    public DateTime? TIMESTAMP { get; set; }

    public decimal? FLAGS { get; set; }

    public decimal? HINTCOUNT { get; set; }

    public decimal? SPARE1 { get; set; }

    public string? SPARE2 { get; set; }
}
