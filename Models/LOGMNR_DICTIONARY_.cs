using System;
using System.Collections.Generic;

namespace BankingWebApp.Models;

public partial class LOGMNR_DICTIONARY_
{
    public string? DB_NAME { get; set; }

    public decimal? DB_ID { get; set; }

    public string? DB_CREATED { get; set; }

    public string? DB_DICT_CREATED { get; set; }

    public decimal? DB_DICT_SCN { get; set; }

    public byte[]? DB_THREAD_MAP { get; set; }

    public decimal? DB_TXN_SCNBAS { get; set; }

    public decimal? DB_TXN_SCNWRP { get; set; }

    public decimal? DB_RESETLOGS_CHANGE_ { get; set; }

    public string? DB_RESETLOGS_TIME { get; set; }

    public string? DB_VERSION_TIME { get; set; }

    public string? DB_REDO_TYPE_ID { get; set; }

    public string? DB_REDO_RELEASE { get; set; }

    public string? DB_CHARACTER_SET { get; set; }

    public string? DB_VERSION { get; set; }

    public string? DB_STATUS { get; set; }

    public string? DB_GLOBAL_NAME { get; set; }

    public decimal? DB_DICT_MAXOBJECTS { get; set; }

    public decimal DB_DICT_OBJECTCOUNT { get; set; }

    public decimal? LOGMNR_UID { get; set; }

    public decimal? LOGMNR_FLAGS { get; set; }

    public string? PDB_NAME { get; set; }

    public decimal? PDB_ID { get; set; }

    public decimal? PDB_UID { get; set; }

    public decimal? PDB_DBID { get; set; }

    public Guid? PDB_GUID { get; set; }

    public decimal? PDB_CREATE_SCN { get; set; }

    public decimal? PDB_COUNT { get; set; }

    public string? PDB_GLOBAL_NAME { get; set; }

    public decimal? FED_ROOT_CON_ID_ { get; set; }
}
