using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNRC_DBNAME_UID_MAP
{
    public string GLOBAL_NAME { get; set; } = null!;

    public decimal? LOGMNR_UID { get; set; }

    public decimal? FLAGS { get; set; }

    public string? PDB_NAME { get; set; }

    public decimal LOGMNR_MDH { get; set; }
}
