using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class ROLLING_PLAN
{
    public decimal? INSTID { get; set; }

    public decimal? BATCHID { get; set; }

    public decimal? DIRECTID { get; set; }

    public decimal? TASKID { get; set; }

    public decimal? REVISION { get; set; }

    public decimal? PHASE { get; set; }

    public decimal? STATUS { get; set; }

    public decimal? PROGRESS { get; set; }

    public decimal? SOURCE { get; set; }

    public decimal? TARGET { get; set; }

    public decimal? RFLAGS { get; set; }

    public decimal? OPCODE { get; set; }

    public string? P1 { get; set; }

    public string? P2 { get; set; }

    public string? P3 { get; set; }

    public string? P4 { get; set; }

    public string? DESCRIPTION { get; set; }

    public decimal? EXEC_STATUS { get; set; }

    public string? EXEC_INFO { get; set; }

    public DateTime? EXEC_TIME { get; set; }

    public DateTime? FINISH_TIME { get; set; }

    public decimal? POST_STATUS { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public string? SPARE3 { get; set; }
}
