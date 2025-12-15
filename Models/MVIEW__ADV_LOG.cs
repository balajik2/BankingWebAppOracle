using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Log all calls to summary advisory functions
/// </summary>
public partial class MVIEW__ADV_LOG
{
    public decimal RUNID_ { get; set; }

    public decimal? FILTERID_ { get; set; }

    public DateTime? RUN_BEGIN { get; set; }

    public DateTime? RUN_END { get; set; }

    public decimal? RUN_TYPE { get; set; }

    public string? UNAME { get; set; }

    public decimal STATUS { get; set; }

    public string? MESSAGE { get; set; }

    public decimal? COMPLETED { get; set; }

    public decimal? TOTAL { get; set; }

    public string? ERROR_CODE { get; set; }

    public virtual ICollection<MVIEW__ADV_AJG> MVIEW__ADV_AJG { get; set; } = new List<MVIEW__ADV_AJG>();

    public virtual ICollection<MVIEW__ADV_CLIQUE> MVIEW__ADV_CLIQUE { get; set; } = new List<MVIEW__ADV_CLIQUE>();

    public virtual ICollection<MVIEW__ADV_ELIGIBLE> MVIEW__ADV_ELIGIBLE { get; set; } = new List<MVIEW__ADV_ELIGIBLE>();

    public virtual ICollection<MVIEW__ADV_INFO> MVIEW__ADV_INFO { get; set; } = new List<MVIEW__ADV_INFO>();

    public virtual ICollection<MVIEW__ADV_JOURNAL> MVIEW__ADV_JOURNAL { get; set; } = new List<MVIEW__ADV_JOURNAL>();

    public virtual ICollection<MVIEW__ADV_LEVEL> MVIEW__ADV_LEVEL { get; set; } = new List<MVIEW__ADV_LEVEL>();

    public virtual ICollection<MVIEW__ADV_OUTPUT> MVIEW__ADV_OUTPUT { get; set; } = new List<MVIEW__ADV_OUTPUT>();

    public virtual ICollection<MVIEW__ADV_ROLLUP> MVIEW__ADV_ROLLUP { get; set; } = new List<MVIEW__ADV_ROLLUP>();
}
