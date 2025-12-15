using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_LOG_
{
    public decimal SESSION_ { get; set; }

    public decimal THREAD_ { get; set; }

    public decimal SEQUENCE_ { get; set; }

    public decimal FIRST_CHANGE_ { get; set; }

    public decimal? NEXT_CHANGE_ { get; set; }

    public DateTime? FIRST_TIME { get; set; }

    public DateTime? NEXT_TIME { get; set; }

    public string? FILE_NAME { get; set; }

    public decimal? STATUS { get; set; }

    public string? INFO { get; set; }

    public DateTime? TIMESTAMP { get; set; }

    public string? DICT_BEGIN { get; set; }

    public string? DICT_END { get; set; }

    public string? STATUS_INFO { get; set; }

    public decimal DB_ID { get; set; }

    public decimal RESETLOGS_CHANGE_ { get; set; }

    public decimal RESET_TIMESTAMP { get; set; }

    public decimal? PREV_RESETLOGS_CHANGE_ { get; set; }

    public decimal? PREV_RESET_TIMESTAMP { get; set; }

    public decimal? BLOCKS { get; set; }

    public decimal? BLOCK_SIZE { get; set; }

    public decimal? FLAGS { get; set; }

    public decimal? CONTENTS { get; set; }

    public decimal? RECID { get; set; }

    public decimal? RECSTAMP { get; set; }

    public decimal? MARK_DELETE_TIMESTAMP { get; set; }

    public decimal? SPARE1 { get; set; }

    public decimal? SPARE2 { get; set; }

    public decimal? SPARE3 { get; set; }

    public decimal? SPARE4 { get; set; }

    public decimal? SPARE5 { get; set; }
}
