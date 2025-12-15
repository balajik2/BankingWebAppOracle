using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class AQ__QUEUE_TABLES
{
    public string SCHEMA { get; set; } = null!;

    public string NAME { get; set; } = null!;

    public decimal UDATA_TYPE { get; set; }

    public decimal OBJNO { get; set; }

    public decimal FLAGS { get; set; }

    public decimal SORT_COLS { get; set; }

    public string? TIMEZONE { get; set; }

    public string? TABLE_COMMENT { get; set; }
}
