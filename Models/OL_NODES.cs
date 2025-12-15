using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class OL_NODES
{
    public string? OL_NAME { get; set; }

    public string? CATEGORY { get; set; }

    public decimal? NODE_ID { get; set; }

    public decimal? PARENT_ID { get; set; }

    public decimal? NODE_TYPE { get; set; }

    public decimal? NODE_TEXTLEN { get; set; }

    public decimal? NODE_TEXTOFF { get; set; }

    public string? NODE_NAME { get; set; }
}
