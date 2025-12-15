using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class REDO_LOG
{
    public decimal DBID { get; set; }

    public string? GLOBAL_DBNAME { get; set; }

    public string? DBUNAME { get; set; }

    public string? VERSION { get; set; }

    public decimal THREAD_ { get; set; }

    public decimal? RESETLOGS_SCN_BAS { get; set; }

    public decimal? RESETLOGS_SCN_WRP { get; set; }

    public decimal RESETLOGS_TIME { get; set; }

    public decimal? PRESETLOGS_SCN_BAS { get; set; }

    public decimal? PRESETLOGS_SCN_WRP { get; set; }

    public decimal PRESETLOGS_TIME { get; set; }

    public decimal SEQUENCE_ { get; set; }

    public decimal? DUPID { get; set; }

    public decimal? STATUS1 { get; set; }

    public decimal? STATUS2 { get; set; }

    public string? CREATE_TIME { get; set; }

    public string? CLOSE_TIME { get; set; }

    public string? DONE_TIME { get; set; }

    public decimal? FIRST_SCN_BAS { get; set; }

    public decimal? FIRST_SCN_WRP { get; set; }

    public decimal? FIRST_TIME { get; set; }

    public decimal? NEXT_SCN_BAS { get; set; }

    public decimal? NEXT_SCN_WRP { get; set; }

    public decimal? NEXT_TIME { get; set; }

    public decimal? FIRST_SCN { get; set; }

    public decimal? NEXT_SCN { get; set; }

    public decimal RESETLOGS_SCN { get; set; }

    public decimal? BLOCKS { get; set; }

    public decimal? BLOCK_SIZE { get; set; }

    public decimal? OLD_BLOCKS { get; set; }

    public DateTime? CREATE_DATE { get; set; }

    public decimal? ERROR1 { get; set; }

    public decimal? ERROR2 { get; set; }

    public string? FILENAME { get; set; }

    public decimal? TS1 { get; set; }

    public decimal? TS2 { get; set; }

    public decimal? ENDIAN { get; set; }

    public decimal? SPARE2 { get; set; }

    public decimal? SPARE3 { get; set; }

    public decimal? SPARE4 { get; set; }

    public DateTime? SPARE5 { get; set; }

    public string? SPARE6 { get; set; }

    public string? SPARE7 { get; set; }

    public decimal? TS3 { get; set; }

    public decimal PRESETLOGS_SCN { get; set; }

    public decimal? SPARE8 { get; set; }

    public decimal? SPARE9 { get; set; }

    public decimal? SPARE10 { get; set; }

    public decimal? OLD_STATUS1 { get; set; }

    public decimal? OLD_STATUS2 { get; set; }

    public string? OLD_FILENAME { get; set; }

    public decimal TENANT_KEY { get; set; }
}
