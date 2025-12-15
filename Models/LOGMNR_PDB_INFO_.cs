using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_PDB_INFO_
{
    public decimal LOGMNR_DID { get; set; }

    public decimal LOGMNR_MDH { get; set; }

    public string? PDB_NAME { get; set; }

    public decimal? PDB_ID { get; set; }

    public decimal? PDB_UID { get; set; }

    public decimal PLUGIN_SCN { get; set; }

    public decimal? UNPLUG_SCN { get; set; }

    public decimal? FLAGS { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }

    public DateTime? SPARE4 { get; set; }

    public string? PDB_GLOBAL_NAME { get; set; }
}
