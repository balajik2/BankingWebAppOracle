using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class REDO_DB
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

    public decimal? SEQNO_RCV_CUR { get; set; }

    public decimal? SEQNO_RCV_LO { get; set; }

    public decimal? SEQNO_RCV_HI { get; set; }

    public decimal? SEQNO_DONE_CUR { get; set; }

    public decimal? SEQNO_DONE_LO { get; set; }

    public decimal? SEQNO_DONE_HI { get; set; }

    public decimal? GAP_SEQNO { get; set; }

    public decimal? GAP_RET { get; set; }

    public decimal? GAP_DONE { get; set; }

    public decimal? APPLY_SEQNO { get; set; }

    public decimal? APPLY_DONE { get; set; }

    public decimal? PURGE_DONE { get; set; }

    public decimal? HAS_CHILD { get; set; }

    public decimal? ERROR1 { get; set; }

    public decimal? STATUS { get; set; }

    public DateTime? CREATE_DATE { get; set; }

    public decimal? TS1 { get; set; }

    public decimal? TS2 { get; set; }

    public decimal? GAP_NEXT_SCN { get; set; }

    public decimal? GAP_NEXT_TIME { get; set; }

    public decimal? CURSCN_TIME { get; set; }

    public decimal RESETLOGS_SCN { get; set; }

    public decimal PRESETLOGS_SCN { get; set; }

    public decimal? GAP_RET2 { get; set; }

    public decimal? CURLOG { get; set; }

    public decimal? ENDIAN { get; set; }

    public decimal? ENQIDX { get; set; }

    public decimal? SPARE4 { get; set; }

    public DateTime? SPARE5 { get; set; }

    public string? SPARE6 { get; set; }

    public string? SPARE7 { get; set; }

    public decimal? TS3 { get; set; }

    public decimal? CURBLKNO { get; set; }

    public decimal? SPARE8 { get; set; }

    public decimal? SPARE9 { get; set; }

    public decimal? SPARE10 { get; set; }

    public decimal? SPARE11 { get; set; }

    public decimal? SPARE12 { get; set; }

    public decimal TENANT_KEY { get; set; }
}
