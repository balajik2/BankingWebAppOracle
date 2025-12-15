using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class ROLLING_DATABASES
{
    public decimal? RDBID { get; set; }

    public decimal? ATTRIBUTES { get; set; }

    public decimal? ATTRIBUTES2 { get; set; }

    public string? DBUN { get; set; }

    public decimal? DBID { get; set; }

    public decimal? PROD_RSCN { get; set; }

    public decimal? PROD_RID { get; set; }

    public decimal? PROD_SCN { get; set; }

    public decimal? CONS_RSCN { get; set; }

    public decimal? CONS_RID { get; set; }

    public decimal? CONS_SCN { get; set; }

    public decimal? ENGINE_STATUS { get; set; }

    public string? VERSION { get; set; }

    public decimal? REDO_SOURCE { get; set; }

    public DateTime? UPDATE_TIME { get; set; }

    public decimal? REVISION { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }
}
