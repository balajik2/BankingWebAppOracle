using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

/// <summary>
/// Table for storing canonical form of Clique queries
/// </summary>
public partial class MVIEW__ADV_CLIQUE
{
    public decimal CLIQUEID_ { get; set; }

    public decimal RUNID_ { get; set; }

    public decimal CLIQUEDESLEN { get; set; }

    public byte[] CLIQUEDES { get; set; } = null!;

    public decimal HASHVALUE { get; set; }

    public decimal FREQUENCY { get; set; }

    public decimal BYTECOST { get; set; }

    public decimal ROWSIZE { get; set; }

    public decimal NUMROWS { get; set; }

    public virtual MVIEW__ADV_LOG RUNID_Navigation { get; set; } = null!;
}
