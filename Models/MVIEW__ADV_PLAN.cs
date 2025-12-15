using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Private plan table for estimate_mview_size operations
/// </summary>
public partial class MVIEW__ADV_PLAN
{
    public string? STATEMENT_ID { get; set; }

    public DateTime? TIMESTAMP { get; set; }

    public string? REMARKS { get; set; }

    public string? OPERATION { get; set; }

    public string? OPTIONS { get; set; }

    public string? OBJECT_NODE { get; set; }

    public string? OBJECT_OWNER { get; set; }

    public string? OBJECT_NAME { get; set; }

    public decimal? OBJECT_INSTANCE { get; set; }

    public string? OBJECT_TYPE { get; set; }

    public string? OPTIMIZER { get; set; }

    public decimal? SEARCH_COLUMNS { get; set; }

    public decimal? ID { get; set; }

    public decimal? PARENT_ID { get; set; }

    public decimal? POSITION { get; set; }

    public decimal? COST { get; set; }

    public decimal? CARDINALITY { get; set; }

    public decimal? BYTES { get; set; }

    public string? OTHER_TAG { get; set; }

    public string? PARTITION_START { get; set; }

    public string? PARTITION_STOP { get; set; }

    public decimal? PARTITION_ID { get; set; }

    public string? OTHER { get; set; }

    public string? DISTRIBUTION { get; set; }

    public decimal? CPU_COST { get; set; }

    public decimal? IO_COST { get; set; }

    public decimal? TEMP_SPACE { get; set; }
}
