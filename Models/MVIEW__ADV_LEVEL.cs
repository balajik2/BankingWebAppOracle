using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Level definition
/// </summary>
public partial class MVIEW__ADV_LEVEL
{
    public decimal RUNID_ { get; set; }

    public decimal LEVELID_ { get; set; }

    public decimal? DIMOBJ_ { get; set; }

    public decimal FLAGS { get; set; }

    public decimal TBLOBJ_ { get; set; }

    public byte[] COLUMNLIST { get; set; } = null!;

    public string? LEVELNAME { get; set; }

    public virtual ICollection<MVIEW__ADV_ROLLUP> MVIEW__ADV_ROLLUPMVIEW__ADV_LEVEL { get; set; } = new List<MVIEW__ADV_ROLLUP>();

    public virtual ICollection<MVIEW__ADV_ROLLUP> MVIEW__ADV_ROLLUPMVIEW__ADV_LEVELNavigation { get; set; } = new List<MVIEW__ADV_ROLLUP>();

    public virtual MVIEW__ADV_LOG RUNID_Navigation { get; set; } = null!;
}
