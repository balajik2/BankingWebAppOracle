using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class OL_HINTS
{
    public string? OL_NAME { get; set; }

    public decimal? HINT_ { get; set; }

    public string? CATEGORY { get; set; }

    public decimal? HINT_TYPE { get; set; }

    public string? HINT_TEXT { get; set; }

    public decimal? STAGE_ { get; set; }

    public decimal? NODE_ { get; set; }

    public string? TABLE_NAME { get; set; }

    public decimal? TABLE_TIN { get; set; }

    public decimal? TABLE_POS { get; set; }

    public decimal? REF_ID { get; set; }

    public string? USER_TABLE_NAME { get; set; }

    public decimal? COST { get; set; }

    public decimal? CARDINALITY { get; set; }

    public decimal? BYTES { get; set; }

    public decimal? HINT_TEXTOFF { get; set; }

    public decimal? HINT_TEXTLEN { get; set; }

    public string? JOIN_PRED { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? HINT_STRING { get; set; }
}
