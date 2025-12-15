using System;
using System.Collections.Generic;
using BankingWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BankingWebApp.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ACCOUNTS> ACCOUNTS { get; set; }

    public virtual DbSet<AQ__INTERNET_AGENTS> AQ__INTERNET_AGENTS { get; set; }

    public virtual DbSet<AQ__INTERNET_AGENT_PRIVS> AQ__INTERNET_AGENT_PRIVS { get; set; }

    public virtual DbSet<AQ__KEY_SHARD_MAP> AQ__KEY_SHARD_MAP { get; set; }

    public virtual DbSet<AQ__QUEUES> AQ__QUEUES { get; set; }

    public virtual DbSet<AQ__QUEUE_TABLES> AQ__QUEUE_TABLES { get; set; }

    public virtual DbSet<AQ__SCHEDULES> AQ__SCHEDULES { get; set; }

    public virtual DbSet<AUDIT_LOGS> AUDIT_LOGS { get; set; }

    public virtual DbSet<BRANCHES> BRANCHES { get; set; }

    public virtual DbSet<CARDS> CARDS { get; set; }

    public virtual DbSet<CUSTOMERS> CUSTOMERS { get; set; }

    public virtual DbSet<CUSTOMER_CONTACTS> CUSTOMER_CONTACTS { get; set; }

    public virtual DbSet<EMPLOYEES> EMPLOYEES { get; set; }

    public virtual DbSet<HELP> HELP { get; set; }

    public virtual DbSet<LOANS> LOANS { get; set; }

    public virtual DbSet<LOGMNRC_CONCOL_GG> LOGMNRC_CONCOL_GG { get; set; }

    public virtual DbSet<LOGMNRC_CON_GG> LOGMNRC_CON_GG { get; set; }

    public virtual DbSet<LOGMNRC_DBNAME_UID_MAP> LOGMNRC_DBNAME_UID_MAP { get; set; }

    public virtual DbSet<LOGMNRC_GSBA> LOGMNRC_GSBA { get; set; }

    public virtual DbSet<LOGMNRC_GSII> LOGMNRC_GSII { get; set; }

    public virtual DbSet<LOGMNRC_GTCS> LOGMNRC_GTCS { get; set; }

    public virtual DbSet<LOGMNRC_GTLO> LOGMNRC_GTLO { get; set; }

    public virtual DbSet<LOGMNRC_INDCOL_GG> LOGMNRC_INDCOL_GG { get; set; }

    public virtual DbSet<LOGMNRC_IND_GG> LOGMNRC_IND_GG { get; set; }

    public virtual DbSet<LOGMNRC_SEQ_GG> LOGMNRC_SEQ_GG { get; set; }

    public virtual DbSet<LOGMNRC_SHARD_TS> LOGMNRC_SHARD_TS { get; set; }

    public virtual DbSet<LOGMNRC_TS> LOGMNRC_TS { get; set; }

    public virtual DbSet<LOGMNRC_TSPART> LOGMNRC_TSPART { get; set; }

    public virtual DbSet<LOGMNRC_USER> LOGMNRC_USER { get; set; }

    public virtual DbSet<LOGMNRGGC_GTCS> LOGMNRGGC_GTCS { get; set; }

    public virtual DbSet<LOGMNRGGC_GTLO> LOGMNRGGC_GTLO { get; set; }

    public virtual DbSet<LOGMNRP_CTAS_PART_MAP> LOGMNRP_CTAS_PART_MAP { get; set; }

    public virtual DbSet<LOGMNRT_MDDL_> LOGMNRT_MDDL_ { get; set; }

    public virtual DbSet<LOGMNR_AGE_SPILL_> LOGMNR_AGE_SPILL_ { get; set; }

    public virtual DbSet<LOGMNR_ATTRCOL_> LOGMNR_ATTRCOL_ { get; set; }

    public virtual DbSet<LOGMNR_ATTRIBUTE_> LOGMNR_ATTRIBUTE_ { get; set; }

    public virtual DbSet<LOGMNR_CCOL_> LOGMNR_CCOL_ { get; set; }

    public virtual DbSet<LOGMNR_CDEF_> LOGMNR_CDEF_ { get; set; }

    public virtual DbSet<LOGMNR_COLTYPE_> LOGMNR_COLTYPE_ { get; set; }

    public virtual DbSet<LOGMNR_COL_> LOGMNR_COL_ { get; set; }

    public virtual DbSet<LOGMNR_CONTAINER_> LOGMNR_CONTAINER_ { get; set; }

    public virtual DbSet<LOGMNR_CON_> LOGMNR_CON_ { get; set; }

    public virtual DbSet<LOGMNR_DICTIONARY_> LOGMNR_DICTIONARY_ { get; set; }

    public virtual DbSet<LOGMNR_DICTSTATE_> LOGMNR_DICTSTATE_ { get; set; }

    public virtual DbSet<LOGMNR_DID_> LOGMNR_DID_ { get; set; }

    public virtual DbSet<LOGMNR_ENC_> LOGMNR_ENC_ { get; set; }

    public virtual DbSet<LOGMNR_ERROR_> LOGMNR_ERROR_ { get; set; }

    public virtual DbSet<LOGMNR_FILTER_> LOGMNR_FILTER_ { get; set; }

    public virtual DbSet<LOGMNR_GLOBAL_> LOGMNR_GLOBAL_ { get; set; }

    public virtual DbSet<LOGMNR_GT_TAB_INCLUDE_> LOGMNR_GT_TAB_INCLUDE_ { get; set; }

    public virtual DbSet<LOGMNR_GT_USER_INCLUDE_> LOGMNR_GT_USER_INCLUDE_ { get; set; }

    public virtual DbSet<LOGMNR_GT_XID_INCLUDE_> LOGMNR_GT_XID_INCLUDE_ { get; set; }

    public virtual DbSet<LOGMNR_ICOL_> LOGMNR_ICOL_ { get; set; }

    public virtual DbSet<LOGMNR_IDNSEQ_> LOGMNR_IDNSEQ_ { get; set; }

    public virtual DbSet<LOGMNR_INDCOMPART_> LOGMNR_INDCOMPART_ { get; set; }

    public virtual DbSet<LOGMNR_INDPART_> LOGMNR_INDPART_ { get; set; }

    public virtual DbSet<LOGMNR_INDSUBPART_> LOGMNR_INDSUBPART_ { get; set; }

    public virtual DbSet<LOGMNR_IND_> LOGMNR_IND_ { get; set; }

    public virtual DbSet<LOGMNR_KOPM_> LOGMNR_KOPM_ { get; set; }

    public virtual DbSet<LOGMNR_LOBFRAG_> LOGMNR_LOBFRAG_ { get; set; }

    public virtual DbSet<LOGMNR_LOB_> LOGMNR_LOB_ { get; set; }

    public virtual DbSet<LOGMNR_LOGMNR_BUILDLOG> LOGMNR_LOGMNR_BUILDLOG { get; set; }

    public virtual DbSet<LOGMNR_LOG_> LOGMNR_LOG_ { get; set; }

    public virtual DbSet<LOGMNR_NTAB_> LOGMNR_NTAB_ { get; set; }

    public virtual DbSet<LOGMNR_OBJ_> LOGMNR_OBJ_ { get; set; }

    public virtual DbSet<LOGMNR_OPQTYPE_> LOGMNR_OPQTYPE_ { get; set; }

    public virtual DbSet<LOGMNR_PARAMETER_> LOGMNR_PARAMETER_ { get; set; }

    public virtual DbSet<LOGMNR_PARTOBJ_> LOGMNR_PARTOBJ_ { get; set; }

    public virtual DbSet<LOGMNR_PDB_INFO_> LOGMNR_PDB_INFO_ { get; set; }

    public virtual DbSet<LOGMNR_PROCESSED_LOG_> LOGMNR_PROCESSED_LOG_ { get; set; }

    public virtual DbSet<LOGMNR_PROFILE_PLSQL_STATS_> LOGMNR_PROFILE_PLSQL_STATS_ { get; set; }

    public virtual DbSet<LOGMNR_PROFILE_TABLE_STATS_> LOGMNR_PROFILE_TABLE_STATS_ { get; set; }

    public virtual DbSet<LOGMNR_PROPS_> LOGMNR_PROPS_ { get; set; }

    public virtual DbSet<LOGMNR_REFCON_> LOGMNR_REFCON_ { get; set; }

    public virtual DbSet<LOGMNR_RESTART_CKPT_> LOGMNR_RESTART_CKPT_ { get; set; }

    public virtual DbSet<LOGMNR_RESTART_CKPT_TXINFO_> LOGMNR_RESTART_CKPT_TXINFO_ { get; set; }

    public virtual DbSet<LOGMNR_SEED_> LOGMNR_SEED_ { get; set; }

    public virtual DbSet<LOGMNR_SESSION_> LOGMNR_SESSION_ { get; set; }

    public virtual DbSet<LOGMNR_SESSION_ACTIONS_> LOGMNR_SESSION_ACTIONS_ { get; set; }

    public virtual DbSet<LOGMNR_SESSION_EVOLVE_> LOGMNR_SESSION_EVOLVE_ { get; set; }

    public virtual DbSet<LOGMNR_SHARD_TS> LOGMNR_SHARD_TS { get; set; }

    public virtual DbSet<LOGMNR_SPILL_> LOGMNR_SPILL_ { get; set; }

    public virtual DbSet<LOGMNR_SUBCOLTYPE_> LOGMNR_SUBCOLTYPE_ { get; set; }

    public virtual DbSet<LOGMNR_TABCOMPART_> LOGMNR_TABCOMPART_ { get; set; }

    public virtual DbSet<LOGMNR_TABPART_> LOGMNR_TABPART_ { get; set; }

    public virtual DbSet<LOGMNR_TABSUBPART_> LOGMNR_TABSUBPART_ { get; set; }

    public virtual DbSet<LOGMNR_TAB_> LOGMNR_TAB_ { get; set; }

    public virtual DbSet<LOGMNR_TS_> LOGMNR_TS_ { get; set; }

    public virtual DbSet<LOGMNR_TYPE_> LOGMNR_TYPE_ { get; set; }

    public virtual DbSet<LOGMNR_UID_> LOGMNR_UID_ { get; set; }

    public virtual DbSet<LOGMNR_USER_> LOGMNR_USER_ { get; set; }

    public virtual DbSet<LOGSTDBY_APPLY_MILESTONE> LOGSTDBY_APPLY_MILESTONE { get; set; }

    public virtual DbSet<LOGSTDBY_APPLY_PROGRESS> LOGSTDBY_APPLY_PROGRESS { get; set; }

    public virtual DbSet<LOGSTDBY_EDS_TABLES> LOGSTDBY_EDS_TABLES { get; set; }

    public virtual DbSet<LOGSTDBY_EVENTS> LOGSTDBY_EVENTS { get; set; }

    public virtual DbSet<LOGSTDBY_FLASHBACK_SCN> LOGSTDBY_FLASHBACK_SCN { get; set; }

    public virtual DbSet<LOGSTDBY_HISTORY> LOGSTDBY_HISTORY { get; set; }

    public virtual DbSet<LOGSTDBY_PARAMETERS> LOGSTDBY_PARAMETERS { get; set; }

    public virtual DbSet<LOGSTDBY_PLSQL> LOGSTDBY_PLSQL { get; set; }

    public virtual DbSet<LOGSTDBY_SCN> LOGSTDBY_SCN { get; set; }

    public virtual DbSet<LOGSTDBY_SKIP> LOGSTDBY_SKIP { get; set; }

    public virtual DbSet<LOGSTDBY_SKIP_SUPPORT> LOGSTDBY_SKIP_SUPPORT { get; set; }

    public virtual DbSet<LOGSTDBY_SKIP_TRANSACTION> LOGSTDBY_SKIP_TRANSACTION { get; set; }

    public virtual DbSet<MVIEW_EVALUATIONS> MVIEW_EVALUATIONS { get; set; }

    public virtual DbSet<MVIEW_EXCEPTIONS> MVIEW_EXCEPTIONS { get; set; }

    public virtual DbSet<MVIEW_FILTER> MVIEW_FILTER { get; set; }

    public virtual DbSet<MVIEW_FILTERINSTANCE> MVIEW_FILTERINSTANCE { get; set; }

    public virtual DbSet<MVIEW_LOG> MVIEW_LOG { get; set; }

    public virtual DbSet<MVIEW_RECOMMENDATIONS> MVIEW_RECOMMENDATIONS { get; set; }

    public virtual DbSet<MVIEW_WORKLOAD> MVIEW_WORKLOAD { get; set; }

    public virtual DbSet<MVIEW__ADV_AJG> MVIEW__ADV_AJG { get; set; }

    public virtual DbSet<MVIEW__ADV_BASETABLE> MVIEW__ADV_BASETABLE { get; set; }

    public virtual DbSet<MVIEW__ADV_CLIQUE> MVIEW__ADV_CLIQUE { get; set; }

    public virtual DbSet<MVIEW__ADV_ELIGIBLE> MVIEW__ADV_ELIGIBLE { get; set; }

    public virtual DbSet<MVIEW__ADV_EXCEPTIONS> MVIEW__ADV_EXCEPTIONS { get; set; }

    public virtual DbSet<MVIEW__ADV_FILTER> MVIEW__ADV_FILTER { get; set; }

    public virtual DbSet<MVIEW__ADV_FILTERINSTANCE> MVIEW__ADV_FILTERINSTANCE { get; set; }

    public virtual DbSet<MVIEW__ADV_FJG> MVIEW__ADV_FJG { get; set; }

    public virtual DbSet<MVIEW__ADV_GC> MVIEW__ADV_GC { get; set; }

    public virtual DbSet<MVIEW__ADV_INFO> MVIEW__ADV_INFO { get; set; }

    public virtual DbSet<MVIEW__ADV_JOURNAL> MVIEW__ADV_JOURNAL { get; set; }

    public virtual DbSet<MVIEW__ADV_LEVEL> MVIEW__ADV_LEVEL { get; set; }

    public virtual DbSet<MVIEW__ADV_LOG> MVIEW__ADV_LOG { get; set; }

    public virtual DbSet<MVIEW__ADV_OUTPUT> MVIEW__ADV_OUTPUT { get; set; }

    public virtual DbSet<MVIEW__ADV_PARAMETERS> MVIEW__ADV_PARAMETERS { get; set; }

    public virtual DbSet<MVIEW__ADV_PLAN> MVIEW__ADV_PLAN { get; set; }

    public virtual DbSet<MVIEW__ADV_PRETTY> MVIEW__ADV_PRETTY { get; set; }

    public virtual DbSet<MVIEW__ADV_ROLLUP> MVIEW__ADV_ROLLUP { get; set; }

    public virtual DbSet<MVIEW__ADV_SQLDEPEND> MVIEW__ADV_SQLDEPEND { get; set; }

    public virtual DbSet<MVIEW__ADV_TEMP> MVIEW__ADV_TEMP { get; set; }

    public virtual DbSet<MVIEW__ADV_WORKLOAD> MVIEW__ADV_WORKLOAD { get; set; }

    public virtual DbSet<OL_> OL_ { get; set; }

    public virtual DbSet<OL_HINTS> OL_HINTS { get; set; }

    public virtual DbSet<OL_NODES> OL_NODES { get; set; }

    public virtual DbSet<PAYMENTS> PAYMENTS { get; set; }

    public virtual DbSet<PRODUCT_PRIVS> PRODUCT_PRIVS { get; set; }

    public virtual DbSet<REDO_DB> REDO_DB { get; set; }

    public virtual DbSet<REDO_LOG> REDO_LOG { get; set; }

    public virtual DbSet<REPL_SUPPORT_MATRIX> REPL_SUPPORT_MATRIX { get; set; }

    public virtual DbSet<REPL_VALID_COMPAT> REPL_VALID_COMPAT { get; set; }

    public virtual DbSet<ROLLING_CONNECTIONS> ROLLING_CONNECTIONS { get; set; }

    public virtual DbSet<ROLLING_DATABASES> ROLLING_DATABASES { get; set; }

    public virtual DbSet<ROLLING_DIRECTIVES> ROLLING_DIRECTIVES { get; set; }

    public virtual DbSet<ROLLING_EVENTS> ROLLING_EVENTS { get; set; }

    public virtual DbSet<ROLLING_PARAMETERS> ROLLING_PARAMETERS { get; set; }

    public virtual DbSet<ROLLING_PLAN> ROLLING_PLAN { get; set; }

    public virtual DbSet<ROLLING_STATISTICS> ROLLING_STATISTICS { get; set; }

    public virtual DbSet<ROLLING_STATUS> ROLLING_STATUS { get; set; }

    public virtual DbSet<SCHEDULER_JOB_ARGS> SCHEDULER_JOB_ARGS { get; set; }

    public virtual DbSet<SCHEDULER_JOB_ARGS_TBL> SCHEDULER_JOB_ARGS_TBL { get; set; }

    public virtual DbSet<SCHEDULER_PROGRAM_ARGS> SCHEDULER_PROGRAM_ARGS { get; set; }

    public virtual DbSet<SCHEDULER_PROGRAM_ARGS_TBL> SCHEDULER_PROGRAM_ARGS_TBL { get; set; }

    public virtual DbSet<SQLPLUS_PRODUCT_PROFILE> SQLPLUS_PRODUCT_PROFILE { get; set; }

    public virtual DbSet<TRANSACTIONS> TRANSACTIONS { get; set; }

    public virtual DbSet<VW_BRANCH_SUMMARY> VW_BRANCH_SUMMARY { get; set; }

    public virtual DbSet<VW_CUSTOMER_ACCOUNTS> VW_CUSTOMER_ACCOUNTS { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<ACCOUNTS>(entity =>
        {
            entity.HasKey(e => e.ACCOUNT_ID).HasName("SYS_C008332");

            entity.HasIndex(e => e.BALANCE, "IDX_ACCOUNT_BALANCE");

            entity.Property(e => e.ACCOUNT_ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER");
            entity.Property(e => e.ACCOUNT_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BALANCE)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(15,2)");
            entity.Property(e => e.BRANCH_ID).HasColumnType("NUMBER");
            entity.Property(e => e.CREATED_AT)
                .HasDefaultValueSql("SYSDATE")
                .HasColumnType("DATE");
            entity.Property(e => e.CUSTOMER_ID).HasColumnType("NUMBER");
            entity.Property(e => e.STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'ACTIVE'");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.ACCOUNTS)
                .HasForeignKey(d => d.BRANCH_ID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C008334");

            entity.HasOne(d => d.CUSTOMER).WithMany(p => p.ACCOUNTS)
                .HasForeignKey(d => d.CUSTOMER_ID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C008333");
        });

        modelBuilder.Entity<AQ__INTERNET_AGENTS>(entity =>
        {
            entity.HasKey(e => e.AGENT_NAME).HasName("SYS_C002815");

            entity.ToTable("AQ$_INTERNET_AGENTS");

            entity.Property(e => e.AGENT_NAME)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.PROTOCOL).HasColumnType("NUMBER(38)");
            entity.Property(e => e.SPARE1)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AQ__INTERNET_AGENT_PRIVS>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AQ$_INTERNET_AGENT_PRIVS");

            entity.HasIndex(e => new { e.AGENT_NAME, e.DB_USERNAME }, "UNQ_PAIRS").IsUnique();

            entity.Property(e => e.AGENT_NAME)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.DB_USERNAME)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.AGENT_NAMENavigation).WithMany()
                .HasForeignKey(d => d.AGENT_NAME)
                .HasConstraintName("AGENT_MUST_BE_CREATED");
        });

        modelBuilder.Entity<AQ__KEY_SHARD_MAP>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AQ$_KEY_SHARD_MAP");

            entity.HasIndex(e => new { e.QUEUE, e.KEY }, "AQ$_KEY_SHARD_MAP_PK").IsUnique();

            entity.Property(e => e.DELAY_SHARD).HasColumnType("NUMBER");
            entity.Property(e => e.KEY)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.QUEUE).HasColumnType("NUMBER");
            entity.Property(e => e.SHARD).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<AQ__QUEUES>(entity =>
        {
            entity.HasKey(e => e.OID).HasName("AQ$_QUEUES_PRIMARY");

            entity.ToTable("AQ$_QUEUES");

            entity.HasIndex(e => new { e.NAME, e.TABLE_OBJNO }, "AQ$_QUEUES_CHECK").IsUnique();

            entity.HasIndex(e => new { e.NAME, e.EVENTID, e.TABLE_OBJNO }, "I1_QUEUES");

            entity.Property(e => e.OID).ValueGeneratedNever();
            entity.Property(e => e.BASE_QUEUE)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER");
            entity.Property(e => e.ENABLE_FLAG).HasColumnType("NUMBER");
            entity.Property(e => e.EVENTID).HasColumnType("NUMBER");
            entity.Property(e => e.MAX_RETRIES).HasColumnType("NUMBER");
            entity.Property(e => e.MEMORY_THRESHOLD).HasColumnType("NUMBER");
            entity.Property(e => e.NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.NETWORK_NAME)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.PROPERTIES).HasColumnType("NUMBER");
            entity.Property(e => e.QUEUE_COMMENT)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.RETRY_DELAY).HasColumnType("NUMBER");
            entity.Property(e => e.RET_TIME).HasColumnType("NUMBER");
            entity.Property(e => e.SERVICE_NAME)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.SHARDED).HasColumnType("NUMBER");
            entity.Property(e => e.TABLE_OBJNO).HasColumnType("NUMBER");
            entity.Property(e => e.USAGE).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<AQ__QUEUE_TABLES>(entity =>
        {
            entity.HasKey(e => e.OBJNO).HasName("AQ$_QUEUE_TABLES_PRIMARY");

            entity.ToTable("AQ$_QUEUE_TABLES");

            entity.HasIndex(e => new { e.OBJNO, e.SCHEMA, e.FLAGS }, "I1_QUEUE_TABLES");

            entity.Property(e => e.OBJNO).HasColumnType("NUMBER");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.SCHEMA)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.SORT_COLS).HasColumnType("NUMBER");
            entity.Property(e => e.TABLE_COMMENT)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.TIMEZONE)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.UDATA_TYPE).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<AQ__SCHEDULES>(entity =>
        {
            entity.HasKey(e => new { e.OID, e.DESTINATION }).HasName("AQ$_SCHEDULES_PRIMARY");

            entity.ToTable("AQ$_SCHEDULES");

            entity.HasIndex(e => e.JOBNO, "AQ$_SCHEDULES_CHECK").IsUnique();

            entity.Property(e => e.DESTINATION)
                .HasMaxLength(390)
                .IsUnicode(false);
            entity.Property(e => e.DURATION)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.JOBNO).HasColumnType("NUMBER");
            entity.Property(e => e.LAST_TIME).HasColumnType("DATE");
            entity.Property(e => e.LATENCY)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.NEXT_TIME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.START_TIME).HasColumnType("DATE");
        });

        modelBuilder.Entity<AUDIT_LOGS>(entity =>
        {
            entity.HasKey(e => e.LOG_ID).HasName("SYS_C008357");

            entity.Property(e => e.LOG_ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER");
            entity.Property(e => e.ACTION)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ACTION_DATE)
                .HasDefaultValueSql("SYSDATE")
                .HasColumnType("DATE");
            entity.Property(e => e.USER_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BRANCHES>(entity =>
        {
            entity.HasKey(e => e.BRANCH_ID).HasName("SYS_C008322");

            entity.Property(e => e.BRANCH_ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER");
            entity.Property(e => e.BRANCH_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LOCATION)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MANAGER_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CARDS>(entity =>
        {
            entity.HasKey(e => e.CARD_ID).HasName("SYS_C008350");

            entity.HasIndex(e => e.CARD_NUMBER, "SYS_C008351").IsUnique();

            entity.Property(e => e.CARD_ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER");
            entity.Property(e => e.CARD_NUMBER)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.CARD_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CUSTOMER_ID).HasColumnType("NUMBER");
            entity.Property(e => e.EXPIRY_DATE).HasColumnType("DATE");
            entity.Property(e => e.STATUS)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.CUSTOMER).WithMany(p => p.CARDS)
                .HasForeignKey(d => d.CUSTOMER_ID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C008352");
        });

        modelBuilder.Entity<CUSTOMERS>(entity =>
        {
            entity.HasKey(e => e.CUSTOMER_ID).HasName("SYS_C008317");

            entity.HasIndex(e => e.EMAIL, "SYS_C008318").IsUnique();

            entity.Property(e => e.CUSTOMER_ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER");
            entity.Property(e => e.ADDRESS)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CREATED_AT)
                .HasDefaultValueSql("SYSDATE\n")
                .HasColumnType("DATE");
            entity.Property(e => e.DOB).HasColumnType("DATE");
            entity.Property(e => e.EMAIL)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FIRST_NAME)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GENDER)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LAST_NAME)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PHONE)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CUSTOMER_CONTACTS>(entity =>
        {
            entity.HasKey(e => e.CONTACT_ID).HasName("SYS_C008359");

            entity.Property(e => e.CONTACT_ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER");
            entity.Property(e => e.CONTACT_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CONTACT_VALUE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CUSTOMER_ID).HasColumnType("NUMBER");

            entity.HasOne(d => d.CUSTOMER).WithMany(p => p.CUSTOMER_CONTACTS)
                .HasForeignKey(d => d.CUSTOMER_ID)
                .HasConstraintName("SYS_C008360");
        });

        modelBuilder.Entity<EMPLOYEES>(entity =>
        {
            entity.HasKey(e => e.EMPLOYEE_ID).HasName("SYS_C008326");

            entity.Property(e => e.EMPLOYEE_ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER");
            entity.Property(e => e.BRANCH_ID).HasColumnType("NUMBER");
            entity.Property(e => e.FIRST_NAME)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LAST_NAME)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.POSITION)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SALARY).HasColumnType("NUMBER(10,2)");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.EMPLOYEES)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("SYS_C008327");
        });

        modelBuilder.Entity<HELP>(entity =>
        {
            entity.HasKey(e => new { e.TOPIC, e.SEQ }).HasName("HELP_TOPIC_SEQ");

            entity.Property(e => e.TOPIC)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SEQ).HasColumnType("NUMBER");
            entity.Property(e => e.INFO)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LOANS>(entity =>
        {
            entity.HasKey(e => e.LOAN_ID).HasName("SYS_C008344");

            entity.Property(e => e.LOAN_ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER");
            entity.Property(e => e.BRANCH_ID).HasColumnType("NUMBER");
            entity.Property(e => e.CUSTOMER_ID).HasColumnType("NUMBER");
            entity.Property(e => e.END_DATE).HasColumnType("DATE");
            entity.Property(e => e.INTEREST_RATE).HasColumnType("NUMBER(5,2)");
            entity.Property(e => e.LOAN_AMOUNT).HasColumnType("NUMBER(15,2)");
            entity.Property(e => e.START_DATE).HasColumnType("DATE");
            entity.Property(e => e.STATUS)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.BRANCH).WithMany(p => p.LOANS)
                .HasForeignKey(d => d.BRANCH_ID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C008346");

            entity.HasOne(d => d.CUSTOMER).WithMany(p => p.LOANS)
                .HasForeignKey(d => d.CUSTOMER_ID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C008345");
        });

        modelBuilder.Entity<LOGMNRC_CONCOL_GG>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.CON_, e.COMMIT_SCN, e.INTCOL_ }).HasName("LOGMNRC_CONCOL_GG_PK");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.CON_)
                .HasColumnType("NUMBER")
                .HasColumnName("CON#");
            entity.Property(e => e.COMMIT_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.POS_)
                .HasColumnType("NUMBER")
                .HasColumnName("POS#");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNRC_CON_GG>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.CON_, e.COMMIT_SCN }).HasName("LOGMNRC_CON_GG_PK");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.BASEOBJ_, e.BASEOBJV_, e.COMMIT_SCN }, "LOGMNRC_I1CONGG");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.DROP_SCN }, "LOGMNRC_I2CONGG");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.CON_)
                .HasColumnType("NUMBER")
                .HasColumnName("CON#");
            entity.Property(e => e.COMMIT_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.BASEOBJV_)
                .HasColumnType("NUMBER")
                .HasColumnName("BASEOBJV#");
            entity.Property(e => e.BASEOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("BASEOBJ#");
            entity.Property(e => e.DROP_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.INDEXOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("INDEXOBJ#");
            entity.Property(e => e.NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE4).IsUnicode(false);
            entity.Property(e => e.SPARE5).IsUnicode(false);
            entity.Property(e => e.SPARE6).IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNRC_DBNAME_UID_MAP>(entity =>
        {
            entity.HasKey(e => new { e.GLOBAL_NAME, e.LOGMNR_MDH }).HasName("LOGMNRC_DBNAME_UID_MAP_PK");

            entity.Property(e => e.GLOBAL_NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.LOGMNR_MDH).HasColumnType("NUMBER");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.PDB_NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNRC_GSBA>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.AS_OF_SCN }).HasName("LOGMNRC_GSBA_PK");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.AS_OF_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.CHARSETID).HasColumnType("NUMBER");
            entity.Property(e => e.DBTIMEZONE_LEN).HasColumnType("NUMBER");
            entity.Property(e => e.DBTIMEZONE_VALUE)
                .HasMaxLength(192)
                .IsUnicode(false);
            entity.Property(e => e.DB_GLOBAL_NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.FDO_LENGTH).HasColumnType("NUMBER");
            entity.Property(e => e.FDO_VALUE).HasMaxLength(255);
            entity.Property(e => e.LOGMNR_SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE3)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.LOGMNR_SPARE4).HasColumnType("DATE");
            entity.Property(e => e.NCHARSETID).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNRC_GSII>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_ }).HasName("LOGMNRC_GSII_PK");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.BO_)
                .HasColumnType("NUMBER")
                .HasColumnName("BO#");
            entity.Property(e => e.DROP_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.INDTYPE_)
                .HasColumnType("NUMBER")
                .HasColumnName("INDTYPE#");
            entity.Property(e => e.LOGMNR_SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE3)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.LOGMNR_SPARE4).HasColumnType("DATE");
        });

        modelBuilder.Entity<LOGMNRC_GTCS>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.OBJV_, e.INTCOL_ }).HasName("LOGMNRC_GTCS_PK");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.OBJV_, e.SEGCOL_, e.INTCOL_ }, "LOGMNRC_I2GTCS");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.OBJV_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJV#");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.ACDRRESCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("ACDRRESCOL#");
            entity.Property(e => e.ADTORDER).HasColumnType("NUMBER");
            entity.Property(e => e.CHARSETFORM).HasColumnType("NUMBER");
            entity.Property(e => e.CHARSETID).HasColumnType("NUMBER");
            entity.Property(e => e.COLLID).HasColumnType("NUMBER");
            entity.Property(e => e.COLLINTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("COLLINTCOL#");
            entity.Property(e => e.COLNAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.COL_)
                .HasColumnType("NUMBER")
                .HasColumnName("COL#");
            entity.Property(e => e.EAENCALG).HasColumnType("NUMBER");
            entity.Property(e => e.EAFLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.EAINTALG).HasColumnType("NUMBER");
            entity.Property(e => e.EAKLCLEN).HasColumnType("NUMBER");
            entity.Property(e => e.EAMKEYID)
                .HasMaxLength(192)
                .IsUnicode(false);
            entity.Property(e => e.EAOWNER_)
                .HasColumnType("NUMBER")
                .HasColumnName("EAOWNER#");
            entity.Property(e => e.FQCOLNAME).IsUnicode(false);
            entity.Property(e => e.INTERVAL_LEADING_PRECISION).HasColumnType("NUMBER");
            entity.Property(e => e.INTERVAL_TRAILING_PRECISION).HasColumnType("NUMBER");
            entity.Property(e => e.LENGTH).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNRDERIVEDFLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE3)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.LOGMNR_SPARE4).HasColumnType("DATE");
            entity.Property(e => e.LOGMNR_SPARE5).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE6).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE7).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE8).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE9).HasColumnType("NUMBER");
            entity.Property(e => e.NUMATTRS).HasColumnType("NUMBER");
            entity.Property(e => e.NUMINTCOLS).HasColumnType("NUMBER");
            entity.Property(e => e.PRECISION).HasColumnType("NUMBER");
            entity.Property(e => e.PROPERTY).HasColumnType("NUMBER");
            entity.Property(e => e.SCALE).HasColumnType("NUMBER");
            entity.Property(e => e.SEGCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("SEGCOL#");
            entity.Property(e => e.TYPENAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.TYPE_)
                .HasColumnType("NUMBER")
                .HasColumnName("TYPE#");
            entity.Property(e => e.XCOLTYPEFLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.XFQCOLNAME).IsUnicode(false);
            entity.Property(e => e.XOPQLOBINTCOL).HasColumnType("NUMBER");
            entity.Property(e => e.XOPQOBJINTCOL).HasColumnType("NUMBER");
            entity.Property(e => e.XOPQTYPEFLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.XOPQTYPETYPE).HasColumnType("NUMBER");
            entity.Property(e => e.XREFFEDTABLEOBJN).HasColumnType("NUMBER");
            entity.Property(e => e.XREFFEDTABLEOBJV).HasColumnType("NUMBER");
            entity.Property(e => e.XTOPINTCOL).HasColumnType("NUMBER");
            entity.Property(e => e.XTYPENAME).IsUnicode(false);
            entity.Property(e => e.XTYPESCHEMANAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.XXMLINTCOL).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNRC_GTLO>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.KEYOBJ_, e.BASEOBJV_ }).HasName("LOGMNRC_GTLO_PK");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.BASEOBJ_, e.BASEOBJV_ }, "LOGMNRC_I2GTLO");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.DROP_SCN }, "LOGMNRC_I3GTLO");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.KEYOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("KEYOBJ#");
            entity.Property(e => e.BASEOBJV_)
                .HasColumnType("NUMBER")
                .HasColumnName("BASEOBJV#");
            entity.Property(e => e.ACDRFLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.ACDRROWTSINTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("ACDRROWTSINTCOL#");
            entity.Property(e => e.ACDRTSOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("ACDRTSOBJ#");
            entity.Property(e => e.ASSOC_)
                .HasColumnType("NUMBER")
                .HasColumnName("ASSOC#");
            entity.Property(e => e.BASEOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("BASEOBJ#");
            entity.Property(e => e.COLS).HasColumnType("NUMBER");
            entity.Property(e => e.COMPLEXTYPECOLS).HasColumnType("NUMBER");
            entity.Property(e => e.DROP_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.INTCOLS).HasColumnType("NUMBER");
            entity.Property(e => e.KERNELCOLS).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNRMCV)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LOGMNRTLOFLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE3)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.LOGMNR_SPARE4).HasColumnType("DATE");
            entity.Property(e => e.LOGMNR_SPARE5).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE6).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE7).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE8).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE9).HasColumnType("NUMBER");
            entity.Property(e => e.LVL0NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.LVL0TYPE_)
                .HasColumnType("NUMBER")
                .HasColumnName("LVL0TYPE#");
            entity.Property(e => e.LVL1NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.LVL1OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("LVL1OBJ#");
            entity.Property(e => e.LVL1TYPE_)
                .HasColumnType("NUMBER")
                .HasColumnName("LVL1TYPE#");
            entity.Property(e => e.LVL2NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.LVL2OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("LVL2OBJ#");
            entity.Property(e => e.LVL2TYPE_)
                .HasColumnType("NUMBER")
                .HasColumnName("LVL2TYPE#");
            entity.Property(e => e.LVLCNT).HasColumnType("NUMBER");
            entity.Property(e => e.NTPARENTINTCOLNUM).HasColumnType("NUMBER");
            entity.Property(e => e.NTPARENTOBJNUM).HasColumnType("NUMBER");
            entity.Property(e => e.NTPARENTOBJVERSION).HasColumnType("NUMBER");
            entity.Property(e => e.OBJ_FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.OWNERNAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.OWNER_)
                .HasColumnType("NUMBER")
                .HasColumnName("OWNER#");
            entity.Property(e => e.PARTTYPE).HasColumnType("NUMBER");
            entity.Property(e => e.PROPERTY).HasColumnType("NUMBER");
            entity.Property(e => e.START_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.SUBPARTTYPE).HasColumnType("NUMBER");
            entity.Property(e => e.TAB_FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.TRIGFLAG).HasColumnType("NUMBER");
            entity.Property(e => e.TSNAME)
                .HasMaxLength(90)
                .IsUnicode(false);
            entity.Property(e => e.TS_)
                .HasColumnType("NUMBER")
                .HasColumnName("TS#");
            entity.Property(e => e.UNSUPPORTEDCOLS).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSLT).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSQN).HasColumnType("NUMBER");
            entity.Property(e => e.XIDUSN).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNRC_INDCOL_GG>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.COMMIT_SCN, e.INTCOL_ }).HasName("LOGMNRC_INDCOL_GG_PK");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.COMMIT_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.POS_)
                .HasColumnType("NUMBER")
                .HasColumnName("POS#");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNRC_IND_GG>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.COMMIT_SCN }).HasName("LOGMNRC_IND_GG_PK");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.BASEOBJ_, e.BASEOBJV_, e.COMMIT_SCN }, "LOGMNRC_I1INDGG");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.DROP_SCN }, "LOGMNRC_I2INDGG");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.COMMIT_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.BASEOBJV_)
                .HasColumnType("NUMBER")
                .HasColumnName("BASEOBJV#");
            entity.Property(e => e.BASEOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("BASEOBJ#");
            entity.Property(e => e.DROP_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.OWNERNAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.OWNER_)
                .HasColumnType("NUMBER")
                .HasColumnName("OWNER#");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE4).IsUnicode(false);
            entity.Property(e => e.SPARE5).IsUnicode(false);
            entity.Property(e => e.SPARE6).IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNRC_SEQ_GG>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.COMMIT_SCN }).HasName("LOGMNRC_SEQ_GG_PK");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.DROP_SCN }, "LOGMNRC_I2SEQGG");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.COMMIT_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.DROP_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.OBJNAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.OWNERNAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.OWNER_)
                .HasColumnType("NUMBER")
                .HasColumnName("OWNER#");
            entity.Property(e => e.SEQCACHE).HasColumnType("NUMBER");
            entity.Property(e => e.SEQINC).HasColumnType("NUMBER");
            entity.Property(e => e.SEQ_FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).IsUnicode(false);
            entity.Property(e => e.SPARE4).IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNRC_SHARD_TS>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.TABLESPACE_NAME, e.START_SCN }).HasName("LOGMNRC_SHARD_TS_PK");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.DROP_SCN }, "LOGMNRC_I1SHARD_TS");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.TABLESPACE_NAME)
                .HasMaxLength(90)
                .IsUnicode(false);
            entity.Property(e => e.START_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.CHUNK_NUMBER).HasColumnType("NUMBER");
            entity.Property(e => e.DROP_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNRC_TS>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.TS_, e.START_SCN }).HasName("LOGMNRC_TS_PK");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.DROP_SCN }, "LOGMNRC_I1TS");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.TS_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("TS#");
            entity.Property(e => e.START_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.DROP_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.NAME)
                .HasMaxLength(90)
                .IsUnicode(false);
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNRC_TSPART>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.START_SCN }).HasName("LOGMNRC_TSPART_PK");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.DROP_SCN }, "LOGMNRC_I1TSPART");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.START_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.DROP_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).IsUnicode(false);
            entity.Property(e => e.TS_)
                .HasColumnType("NUMBER")
                .HasColumnName("TS#");
        });

        modelBuilder.Entity<LOGMNRC_USER>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.USER_, e.START_SCN }).HasName("LOGMNRC_USER_PK");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.NAME, e.START_SCN }, "LOGMNRC_I1USER");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.USER_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("USER#");
            entity.Property(e => e.START_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.DROP_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1_C).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2_C).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3_C).IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNRGGC_GTCS>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.OBJV_, e.INTCOL_ }).HasName("LOGMNRGGC_GTCS_PK");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.OBJV_, e.SEGCOL_, e.INTCOL_ }, "LOGMNRGGC_I2GTCS");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.OBJV_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJV#");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.ACDRRESCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("ACDRRESCOL#");
            entity.Property(e => e.ADTORDER).HasColumnType("NUMBER");
            entity.Property(e => e.CHARSETFORM).HasColumnType("NUMBER");
            entity.Property(e => e.CHARSETID).HasColumnType("NUMBER");
            entity.Property(e => e.COLLID).HasColumnType("NUMBER");
            entity.Property(e => e.COLLINTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("COLLINTCOL#");
            entity.Property(e => e.COLNAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.COL_)
                .HasColumnType("NUMBER")
                .HasColumnName("COL#");
            entity.Property(e => e.EAENCALG).HasColumnType("NUMBER");
            entity.Property(e => e.EAFLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.EAINTALG).HasColumnType("NUMBER");
            entity.Property(e => e.EAKLCLEN).HasColumnType("NUMBER");
            entity.Property(e => e.EAMKEYID)
                .HasMaxLength(192)
                .IsUnicode(false);
            entity.Property(e => e.EAOWNER_)
                .HasColumnType("NUMBER")
                .HasColumnName("EAOWNER#");
            entity.Property(e => e.FQCOLNAME).IsUnicode(false);
            entity.Property(e => e.INTERVAL_LEADING_PRECISION).HasColumnType("NUMBER");
            entity.Property(e => e.INTERVAL_TRAILING_PRECISION).HasColumnType("NUMBER");
            entity.Property(e => e.LENGTH).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNRDERIVEDFLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE3)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.LOGMNR_SPARE4).HasColumnType("DATE");
            entity.Property(e => e.LOGMNR_SPARE5).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE6).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE7).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE8).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE9).HasColumnType("NUMBER");
            entity.Property(e => e.NUMATTRS).HasColumnType("NUMBER");
            entity.Property(e => e.NUMINTCOLS).HasColumnType("NUMBER");
            entity.Property(e => e.PRECISION).HasColumnType("NUMBER");
            entity.Property(e => e.PROPERTY).HasColumnType("NUMBER");
            entity.Property(e => e.SCALE).HasColumnType("NUMBER");
            entity.Property(e => e.SEGCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("SEGCOL#");
            entity.Property(e => e.TYPENAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.TYPE_)
                .HasColumnType("NUMBER")
                .HasColumnName("TYPE#");
            entity.Property(e => e.XCOLTYPEFLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.XFQCOLNAME).IsUnicode(false);
            entity.Property(e => e.XOPQLOBINTCOL).HasColumnType("NUMBER");
            entity.Property(e => e.XOPQOBJINTCOL).HasColumnType("NUMBER");
            entity.Property(e => e.XOPQTYPEFLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.XOPQTYPETYPE).HasColumnType("NUMBER");
            entity.Property(e => e.XREFFEDTABLEOBJN).HasColumnType("NUMBER");
            entity.Property(e => e.XREFFEDTABLEOBJV).HasColumnType("NUMBER");
            entity.Property(e => e.XTOPINTCOL).HasColumnType("NUMBER");
            entity.Property(e => e.XTYPENAME).IsUnicode(false);
            entity.Property(e => e.XTYPESCHEMANAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.XXMLINTCOL).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNRGGC_GTLO>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.KEYOBJ_, e.BASEOBJV_ }).HasName("LOGMNRGGC_GTLO_PK");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.BASEOBJ_, e.BASEOBJV_ }, "LOGMNRGGC_I2GTLO");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.DROP_SCN }, "LOGMNRGGC_I3GTLO");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.KEYOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("KEYOBJ#");
            entity.Property(e => e.BASEOBJV_)
                .HasColumnType("NUMBER")
                .HasColumnName("BASEOBJV#");
            entity.Property(e => e.ACDRFLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.ACDRROWTSINTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("ACDRROWTSINTCOL#");
            entity.Property(e => e.ACDRTSOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("ACDRTSOBJ#");
            entity.Property(e => e.ASSOC_)
                .HasColumnType("NUMBER")
                .HasColumnName("ASSOC#");
            entity.Property(e => e.BASEOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("BASEOBJ#");
            entity.Property(e => e.COLS).HasColumnType("NUMBER");
            entity.Property(e => e.COMPLEXTYPECOLS).HasColumnType("NUMBER");
            entity.Property(e => e.DROP_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.INTCOLS).HasColumnType("NUMBER");
            entity.Property(e => e.KERNELCOLS).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNRMCV)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LOGMNRTLOFLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE3)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.LOGMNR_SPARE4).HasColumnType("DATE");
            entity.Property(e => e.LOGMNR_SPARE5).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE6).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE7).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE8).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_SPARE9).HasColumnType("NUMBER");
            entity.Property(e => e.LVL0NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.LVL0TYPE_)
                .HasColumnType("NUMBER")
                .HasColumnName("LVL0TYPE#");
            entity.Property(e => e.LVL1NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.LVL1OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("LVL1OBJ#");
            entity.Property(e => e.LVL1TYPE_)
                .HasColumnType("NUMBER")
                .HasColumnName("LVL1TYPE#");
            entity.Property(e => e.LVL2NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.LVL2OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("LVL2OBJ#");
            entity.Property(e => e.LVL2TYPE_)
                .HasColumnType("NUMBER")
                .HasColumnName("LVL2TYPE#");
            entity.Property(e => e.LVLCNT).HasColumnType("NUMBER");
            entity.Property(e => e.NTPARENTINTCOLNUM).HasColumnType("NUMBER");
            entity.Property(e => e.NTPARENTOBJNUM).HasColumnType("NUMBER");
            entity.Property(e => e.NTPARENTOBJVERSION).HasColumnType("NUMBER");
            entity.Property(e => e.OBJ_FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.OWNERNAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.OWNER_)
                .HasColumnType("NUMBER")
                .HasColumnName("OWNER#");
            entity.Property(e => e.PARTTYPE).HasColumnType("NUMBER");
            entity.Property(e => e.PROPERTY).HasColumnType("NUMBER");
            entity.Property(e => e.START_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.SUBPARTTYPE).HasColumnType("NUMBER");
            entity.Property(e => e.TAB_FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.TRIGFLAG).HasColumnType("NUMBER");
            entity.Property(e => e.TSNAME)
                .HasMaxLength(90)
                .IsUnicode(false);
            entity.Property(e => e.TS_)
                .HasColumnType("NUMBER")
                .HasColumnName("TS#");
            entity.Property(e => e.UNSUPPORTEDCOLS).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSLT).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSQN).HasColumnType("NUMBER");
            entity.Property(e => e.XIDUSN).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNRP_CTAS_PART_MAP>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.BASEOBJV_, e.KEYOBJ_ }).HasName("LOGMNRP_CTAS_PART_MAP_PK");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.BASEOBJ_, e.BASEOBJV_, e.PART_ }, "LOGMNRP_CTAS_PART_MAP_I");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.BASEOBJV_)
                .HasColumnType("NUMBER")
                .HasColumnName("BASEOBJV#");
            entity.Property(e => e.KEYOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("KEYOBJ#");
            entity.Property(e => e.BASEOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("BASEOBJ#");
            entity.Property(e => e.PART_)
                .HasColumnType("NUMBER")
                .HasColumnName("PART#");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNRT_MDDL_>(entity =>
        {
            entity.HasKey(e => new { e.SOURCE_OBJ_, e.SOURCE_ROWID }).HasName("LOGMNRT_MDDL$_PK");

            entity.ToTable("LOGMNRT_MDDL$");

            entity.Property(e => e.SOURCE_OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("SOURCE_OBJ#");
            entity.Property(e => e.SOURCE_ROWID).HasColumnType("ROWID");
            entity.Property(e => e.DEST_ROWID).HasColumnType("ROWID");
        });

        modelBuilder.Entity<LOGMNR_AGE_SPILL_>(entity =>
        {
            entity.HasKey(e => new { e.SESSION_, e.PDBID, e.XIDUSN, e.XIDSLT, e.XIDSQN, e.CHUNK, e.SEQUENCE_ }).HasName("LOGMNR_AGE_SPILL$_PK");

            entity.ToTable("LOGMNR_AGE_SPILL$");

            entity.Property(e => e.SESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("SESSION#");
            entity.Property(e => e.PDBID).HasColumnType("NUMBER");
            entity.Property(e => e.XIDUSN).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSLT).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSQN).HasColumnType("NUMBER");
            entity.Property(e => e.CHUNK).HasColumnType("NUMBER");
            entity.Property(e => e.SEQUENCE_)
                .HasColumnType("NUMBER")
                .HasColumnName("SEQUENCE#");
            entity.Property(e => e.OFFSET).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPILL_DATA).HasColumnType("BLOB");
        });

        modelBuilder.Entity<LOGMNR_ATTRCOL_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }).HasName("LOGMNR_ATTRCOL$_PK");

            entity.ToTable("LOGMNR_ATTRCOL$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }, "LOGMNR_I1ATTRCOL$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.NAME).IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNR_ATTRIBUTE_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.TOID, e.VERSION_, e.ATTRIBUTE_ }).HasName("LOGMNR_ATTRIBUTE$_PK");

            entity.ToTable("LOGMNR_ATTRIBUTE$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.TOID, e.VERSION_, e.ATTRIBUTE_ }, "LOGMNR_I1ATTRIBUTE$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.VERSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("VERSION#");
            entity.Property(e => e.ATTRIBUTE_)
                .HasColumnType("NUMBER")
                .HasColumnName("ATTRIBUTE#");
            entity.Property(e => e.ATTR_VERSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("ATTR_VERSION#");
            entity.Property(e => e.CHARSETFORM).HasColumnType("NUMBER");
            entity.Property(e => e.CHARSETID).HasColumnType("NUMBER");
            entity.Property(e => e.EXTERNNAME).IsUnicode(false);
            entity.Property(e => e.GETTER).HasColumnType("NUMBER");
            entity.Property(e => e.LENGTH).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.PRECISION_)
                .HasColumnType("NUMBER")
                .HasColumnName("PRECISION#");
            entity.Property(e => e.PROPERTIES).HasColumnType("NUMBER");
            entity.Property(e => e.SCALE).HasColumnType("NUMBER");
            entity.Property(e => e.SETTER).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE4).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE5).HasColumnType("NUMBER");
            entity.Property(e => e.SYNOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("SYNOBJ#");
            entity.Property(e => e.XFLAGS).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_CCOL_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.CON_, e.INTCOL_ }).HasName("LOGMNR_CCOL$_PK");

            entity.ToTable("LOGMNR_CCOL$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.CON_, e.INTCOL_ }, "LOGMNR_I1CCOL$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.CON_)
                .HasColumnType("NUMBER")
                .HasColumnName("CON#");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.COL_)
                .HasColumnType("NUMBER")
                .HasColumnName("COL#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.POS_)
                .HasColumnType("NUMBER")
                .HasColumnName("POS#");
        });

        modelBuilder.Entity<LOGMNR_CDEF_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.CON_ }).HasName("LOGMNR_CDEF$_PK");

            entity.ToTable("LOGMNR_CDEF$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.CON_ }, "LOGMNR_I1CDEF$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.ROBJ_ }, "LOGMNR_I2CDEF$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_ }, "LOGMNR_I3CDEF$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.CON_)
                .HasColumnType("NUMBER")
                .HasColumnName("CON#");
            entity.Property(e => e.COLS).HasColumnType("NUMBER");
            entity.Property(e => e.DEFER).HasColumnType("NUMBER");
            entity.Property(e => e.ENABLED).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.RCON_)
                .HasColumnType("NUMBER")
                .HasColumnName("RCON#");
            entity.Property(e => e.ROBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("ROBJ#");
            entity.Property(e => e.TYPE_)
                .HasColumnType("NUMBER")
                .HasColumnName("TYPE#");
        });

        modelBuilder.Entity<LOGMNR_COLTYPE_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }).HasName("LOGMNR_COLTYPE$_PK");

            entity.ToTable("LOGMNR_COLTYPE$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }, "LOGMNR_I1COLTYPE$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.COL_)
                .HasColumnType("NUMBER")
                .HasColumnName("COL#");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.INTCOLS).HasColumnType("NUMBER");
            entity.Property(e => e.INTCOL_S).HasColumnName("INTCOL#S");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.PACKED).HasColumnType("NUMBER");
            entity.Property(e => e.SYNOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("SYNOBJ#");
            entity.Property(e => e.TYPIDCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("TYPIDCOL#");
            entity.Property(e => e.VERSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("VERSION#");
        });

        modelBuilder.Entity<LOGMNR_COL_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }).HasName("LOGMNR_COL$_PK");

            entity.ToTable("LOGMNR_COL$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }, "LOGMNR_I1COL$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.NAME }, "LOGMNR_I2COL$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.COL_ }, "LOGMNR_I3COL$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("OBJ#");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.ACDRRESCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("ACDRRESCOL#");
            entity.Property(e => e.CHARSETFORM).HasColumnType("NUMBER(22)");
            entity.Property(e => e.CHARSETID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.COLLID).HasColumnType("NUMBER");
            entity.Property(e => e.COLLINTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("COLLINTCOL#");
            entity.Property(e => e.COL_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("COL#");
            entity.Property(e => e.LENGTH).HasColumnType("NUMBER(22)");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.NULL_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("NULL$");
            entity.Property(e => e.PRECISION_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("PRECISION#");
            entity.Property(e => e.PROPERTY).HasColumnType("NUMBER");
            entity.Property(e => e.SCALE).HasColumnType("NUMBER(22)");
            entity.Property(e => e.SEGCOL_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("SEGCOL#");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER(22)");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER(22)");
            entity.Property(e => e.TYPE_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("TYPE#");
        });

        modelBuilder.Entity<LOGMNR_CONTAINER_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_ }).HasName("LOGMNR_CONTAINER$_PK");

            entity.ToTable("LOGMNR_CONTAINER$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.CON_ID_ }, "LOGMNR_I1CONTAINER$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.CON_ID_)
                .HasColumnType("NUMBER")
                .HasColumnName("CON_ID#");
            entity.Property(e => e.CON_UID).HasColumnType("NUMBER");
            entity.Property(e => e.CREATE_SCNBAS).HasColumnType("NUMBER");
            entity.Property(e => e.CREATE_SCNWRP).HasColumnType("NUMBER");
            entity.Property(e => e.DBID).HasColumnType("NUMBER");
            entity.Property(e => e.FED_ROOT_CON_ID_)
                .HasColumnType("NUMBER")
                .HasColumnName("FED_ROOT_CON_ID#");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.STATUS).HasColumnType("NUMBER");
            entity.Property(e => e.VSN).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_CON_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.CON_ }).HasName("LOGMNR_CON$_PK");

            entity.ToTable("LOGMNR_CON$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.CON_ }, "LOGMNR_I1CON$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.CON_)
                .HasColumnType("NUMBER")
                .HasColumnName("CON#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.OWNER_)
                .HasColumnType("NUMBER")
                .HasColumnName("OWNER#");
            entity.Property(e => e.START_SCNBAS).HasColumnType("NUMBER");
            entity.Property(e => e.START_SCNWRP).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_DICTIONARY_>(entity =>
        {
            entity.HasKey(e => e.LOGMNR_UID).HasName("LOGMNR_DICTIONARY$_PK");

            entity.ToTable("LOGMNR_DICTIONARY$");

            entity.HasIndex(e => e.LOGMNR_UID, "LOGMNR_I1DICTIONARY$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.DB_CHARACTER_SET)
                .HasMaxLength(192)
                .IsUnicode(false);
            entity.Property(e => e.DB_CREATED)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DB_DICT_CREATED)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DB_DICT_MAXOBJECTS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.DB_DICT_OBJECTCOUNT).HasColumnType("NUMBER(22)");
            entity.Property(e => e.DB_DICT_SCN).HasColumnType("NUMBER(22)");
            entity.Property(e => e.DB_GLOBAL_NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.DB_ID).HasColumnType("NUMBER(20)");
            entity.Property(e => e.DB_NAME)
                .HasMaxLength(27)
                .IsUnicode(false);
            entity.Property(e => e.DB_REDO_RELEASE)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.DB_REDO_TYPE_ID)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DB_RESETLOGS_CHANGE_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("DB_RESETLOGS_CHANGE#");
            entity.Property(e => e.DB_RESETLOGS_TIME)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DB_STATUS)
                .HasMaxLength(240)
                .IsUnicode(false);
            entity.Property(e => e.DB_THREAD_MAP).HasMaxLength(8);
            entity.Property(e => e.DB_TXN_SCNBAS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.DB_TXN_SCNWRP).HasColumnType("NUMBER(22)");
            entity.Property(e => e.DB_VERSION)
                .HasMaxLength(240)
                .IsUnicode(false);
            entity.Property(e => e.DB_VERSION_TIME)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FED_ROOT_CON_ID_)
                .HasColumnType("NUMBER")
                .HasColumnName("FED_ROOT_CON_ID#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.PDB_COUNT).HasColumnType("NUMBER");
            entity.Property(e => e.PDB_CREATE_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.PDB_DBID).HasColumnType("NUMBER");
            entity.Property(e => e.PDB_GLOBAL_NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.PDB_ID).HasColumnType("NUMBER");
            entity.Property(e => e.PDB_NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.PDB_UID).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_DICTSTATE_>(entity =>
        {
            entity.HasKey(e => e.LOGMNR_UID).HasName("LOGMNR_DICTSTATE$_PK");

            entity.ToTable("LOGMNR_DICTSTATE$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.END_SCNBAS).HasColumnType("NUMBER");
            entity.Property(e => e.END_SCNWRP).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.RBABLK).HasColumnType("NUMBER");
            entity.Property(e => e.RBABYTE).HasColumnType("NUMBER");
            entity.Property(e => e.RBASQN).HasColumnType("NUMBER");
            entity.Property(e => e.REDO_THREAD).HasColumnType("NUMBER");
            entity.Property(e => e.START_SCNBAS).HasColumnType("NUMBER");
            entity.Property(e => e.START_SCNWRP).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_DID_>(entity =>
        {
            entity.HasKey(e => e.SESSION_).HasName("LOGMNR_DID$_PK");

            entity.ToTable("LOGMNR_DID$");

            entity.Property(e => e.SESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("SESSION#");
            entity.Property(e => e.FLAGS)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_DID).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).IsUnicode(false);
            entity.Property(e => e.SPARE4).HasPrecision(6);
        });

        modelBuilder.Entity<LOGMNR_ENC_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.OWNER_ }).HasName("LOGMNR_ENC$_PK");

            entity.ToTable("LOGMNR_ENC$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.OWNER_ }, "LOGMNR_I1ENC$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.OWNER_)
                .HasColumnType("NUMBER")
                .HasColumnName("OWNER#");
            entity.Property(e => e.ENCALG).HasColumnType("NUMBER");
            entity.Property(e => e.FLAG).HasColumnType("NUMBER");
            entity.Property(e => e.INTALG).HasColumnType("NUMBER");
            entity.Property(e => e.KLCLEN).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.MKEYID)
                .HasMaxLength(192)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNR_ERROR_>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGMNR_ERROR$");

            entity.Property(e => e.CODE).HasColumnType("NUMBER");
            entity.Property(e => e.MESSAGE).IsUnicode(false);
            entity.Property(e => e.SESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("SESSION#");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE4).IsUnicode(false);
            entity.Property(e => e.SPARE5).IsUnicode(false);
            entity.Property(e => e.TIME_OF_ERROR).HasColumnType("DATE");
        });

        modelBuilder.Entity<LOGMNR_FILTER_>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGMNR_FILTER$");

            entity.Property(e => e.ATTR1).HasColumnType("NUMBER");
            entity.Property(e => e.ATTR10)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ATTR11)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ATTR2).HasColumnType("NUMBER");
            entity.Property(e => e.ATTR3).HasColumnType("NUMBER");
            entity.Property(e => e.ATTR4).HasColumnType("NUMBER");
            entity.Property(e => e.ATTR5).HasColumnType("NUMBER");
            entity.Property(e => e.ATTR6).HasColumnType("NUMBER");
            entity.Property(e => e.ATTR7)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ATTR8)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ATTR9)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.FILTER_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.FILTER_TYPE)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("SESSION#");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).HasColumnType("DATE");
        });

        modelBuilder.Entity<LOGMNR_GLOBAL_>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGMNR_GLOBAL$");

            entity.Property(e => e.HIGH_RECID_DELETED).HasColumnType("NUMBER");
            entity.Property(e => e.HIGH_RECID_FOREIGN).HasColumnType("NUMBER");
            entity.Property(e => e.LOCAL_RESET_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.LOCAL_RESET_TIMESTAMP).HasColumnType("NUMBER");
            entity.Property(e => e.SESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("SESSION#");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE4)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.SPARE5).HasColumnType("DATE");
            entity.Property(e => e.VERSION_TIMESTAMP).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_GT_TAB_INCLUDE_>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGMNR_GT_TAB_INCLUDE$");

            entity.Property(e => e.PDB_NAME)
                .HasMaxLength(390)
                .IsUnicode(false);
            entity.Property(e => e.SCHEMA_NAME)
                .HasMaxLength(390)
                .IsUnicode(false);
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).IsUnicode(false);
            entity.Property(e => e.TABLE_NAME)
                .HasMaxLength(390)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNR_GT_USER_INCLUDE_>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGMNR_GT_USER_INCLUDE$");

            entity.Property(e => e.PDB_NAME)
                .HasMaxLength(390)
                .IsUnicode(false);
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).IsUnicode(false);
            entity.Property(e => e.USER_NAME)
                .HasMaxLength(390)
                .IsUnicode(false);
            entity.Property(e => e.USER_TYPE).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_GT_XID_INCLUDE_>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGMNR_GT_XID_INCLUDE$");

            entity.Property(e => e.PDBID).HasColumnType("NUMBER");
            entity.Property(e => e.PDB_NAME)
                .HasMaxLength(390)
                .IsUnicode(false);
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).IsUnicode(false);
            entity.Property(e => e.XIDSLT).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSQN).HasColumnType("NUMBER");
            entity.Property(e => e.XIDUSN).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_ICOL_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }).HasName("LOGMNR_ICOL$_PK");

            entity.ToTable("LOGMNR_ICOL$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }, "LOGMNR_I1ICOL$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.BO_)
                .HasColumnType("NUMBER")
                .HasColumnName("BO#");
            entity.Property(e => e.COL_)
                .HasColumnType("NUMBER")
                .HasColumnName("COL#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.POS_)
                .HasColumnType("NUMBER")
                .HasColumnName("POS#");
            entity.Property(e => e.SEGCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("SEGCOL#");
        });

        modelBuilder.Entity<LOGMNR_IDNSEQ_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }).HasName("LOGMNR_IDNSEQ$_PK");

            entity.ToTable("LOGMNR_IDNSEQ$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }, "LOGMNR_I1IDNSEQ$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.SEQOBJ_ }, "LOGMNR_I2IDNSEQ$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.SEQOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("SEQOBJ#");
            entity.Property(e => e.STARTWITH).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_INDCOMPART_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_ }).HasName("LOGMNR_INDCOMPART$_PK");

            entity.ToTable("LOGMNR_INDCOMPART$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_ }, "LOGMNR_I1INDCOMPART$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.BO_)
                .HasColumnType("NUMBER")
                .HasColumnName("BO#");
            entity.Property(e => e.DATAOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("DATAOBJ#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.PART_)
                .HasColumnType("NUMBER")
                .HasColumnName("PART#");
        });

        modelBuilder.Entity<LOGMNR_INDPART_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.BO_ }).HasName("LOGMNR_INDPART$_PK");

            entity.ToTable("LOGMNR_INDPART$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.BO_ }, "LOGMNR_I1INDPART$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.BO_ }, "LOGMNR_I2INDPART$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.BO_)
                .HasColumnType("NUMBER")
                .HasColumnName("BO#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.PART_)
                .HasColumnType("NUMBER")
                .HasColumnName("PART#");
            entity.Property(e => e.TS_)
                .HasColumnType("NUMBER")
                .HasColumnName("TS#");
        });

        modelBuilder.Entity<LOGMNR_INDSUBPART_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.POBJ_ }).HasName("LOGMNR_INDSUBPART$_PK");

            entity.ToTable("LOGMNR_INDSUBPART$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.POBJ_ }, "LOGMNR_I1INDSUBPART$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("OBJ#");
            entity.Property(e => e.POBJ_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("POBJ#");
            entity.Property(e => e.DATAOBJ_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("DATAOBJ#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.SUBPART_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("SUBPART#");
            entity.Property(e => e.TS_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("TS#");
        });

        modelBuilder.Entity<LOGMNR_IND_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_ }).HasName("LOGMNR_IND$_PK");

            entity.ToTable("LOGMNR_IND$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_ }, "LOGMNR_I1IND$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.BO_ }, "LOGMNR_I2IND$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("OBJ#");
            entity.Property(e => e.BO_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("BO#");
            entity.Property(e => e.COLS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.PROPERTY).HasColumnType("NUMBER");
            entity.Property(e => e.TYPE_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("TYPE#");
        });

        modelBuilder.Entity<LOGMNR_KOPM_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.NAME }).HasName("LOGMNR_KOPM$_PK");

            entity.ToTable("LOGMNR_KOPM$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.NAME }, "LOGMNR_I1KOPM$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.LENGTH).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.METADATA).HasMaxLength(255);
        });

        modelBuilder.Entity<LOGMNR_LOBFRAG_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.FRAGOBJ_ }).HasName("LOGMNR_LOBFRAG$_PK");

            entity.ToTable("LOGMNR_LOBFRAG$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.FRAGOBJ_ }, "LOGMNR_I1LOBFRAG$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.FRAGOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("FRAGOBJ#");
            entity.Property(e => e.FRAG_)
                .HasColumnType("NUMBER")
                .HasColumnName("FRAG#");
            entity.Property(e => e.INDFRAGOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("INDFRAGOBJ#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.PARENTOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("PARENTOBJ#");
            entity.Property(e => e.TABFRAGOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("TABFRAGOBJ#");
        });

        modelBuilder.Entity<LOGMNR_LOB_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }).HasName("LOGMNR_LOB$_PK");

            entity.ToTable("LOGMNR_LOB$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }, "LOGMNR_I1LOB$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.CHUNK).HasColumnType("NUMBER");
            entity.Property(e => e.COL_)
                .HasColumnType("NUMBER")
                .HasColumnName("COL#");
            entity.Property(e => e.LOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("LOBJ#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
        });

        modelBuilder.Entity<LOGMNR_LOGMNR_BUILDLOG>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.INITIAL_XID }).HasName("LOGMNR_LOGMNR_BUILDLOG_PK");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.INITIAL_XID }, "LOGMNR_I1LOGMNR_BUILDLOG");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.INITIAL_XID)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.BUILD_DATE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CDB_XID)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.COMPLETION_STATUS).HasColumnType("NUMBER");
            entity.Property(e => e.CURRENT_BUILD_STATE).HasColumnType("NUMBER");
            entity.Property(e => e.DB_TXN_SCNBAS).HasColumnType("NUMBER");
            entity.Property(e => e.DB_TXN_SCNWRP).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.MARKED_LOG_FILE_LOW_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNR_LOG_>(entity =>
        {
            entity.HasKey(e => new { e.SESSION_, e.THREAD_, e.SEQUENCE_, e.FIRST_CHANGE_, e.DB_ID, e.RESETLOGS_CHANGE_, e.RESET_TIMESTAMP }).HasName("LOGMNR_LOG$_PK");

            entity.ToTable("LOGMNR_LOG$");

            entity.HasIndex(e => e.FIRST_CHANGE_, "LOGMNR_LOG$_FIRST_CHANGE#");

            entity.HasIndex(e => e.FLAGS, "LOGMNR_LOG$_FLAGS");

            entity.HasIndex(e => new { e.FILE_NAME, e.STATUS }, "LOGMNR_LOG$_PURGE_IDX1");

            entity.HasIndex(e => new { e.SESSION_, e.RESET_TIMESTAMP, e.NEXT_CHANGE_, e.STATUS }, "LOGMNR_LOG$_PURGE_IDX2");

            entity.HasIndex(e => e.RECID, "LOGMNR_LOG$_RECID");

            entity.Property(e => e.SESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("SESSION#");
            entity.Property(e => e.THREAD_)
                .HasColumnType("NUMBER")
                .HasColumnName("THREAD#");
            entity.Property(e => e.SEQUENCE_)
                .HasColumnType("NUMBER")
                .HasColumnName("SEQUENCE#");
            entity.Property(e => e.FIRST_CHANGE_)
                .HasColumnType("NUMBER")
                .HasColumnName("FIRST_CHANGE#");
            entity.Property(e => e.DB_ID).HasColumnType("NUMBER");
            entity.Property(e => e.RESETLOGS_CHANGE_)
                .HasColumnType("NUMBER")
                .HasColumnName("RESETLOGS_CHANGE#");
            entity.Property(e => e.RESET_TIMESTAMP).HasColumnType("NUMBER");
            entity.Property(e => e.BLOCKS).HasColumnType("NUMBER");
            entity.Property(e => e.BLOCK_SIZE).HasColumnType("NUMBER");
            entity.Property(e => e.CONTENTS).HasColumnType("NUMBER");
            entity.Property(e => e.DICT_BEGIN)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.DICT_END)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.FILE_NAME)
                .HasMaxLength(513)
                .IsUnicode(false);
            entity.Property(e => e.FIRST_TIME).HasColumnType("DATE");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.INFO)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MARK_DELETE_TIMESTAMP).HasColumnType("NUMBER");
            entity.Property(e => e.NEXT_CHANGE_)
                .HasColumnType("NUMBER")
                .HasColumnName("NEXT_CHANGE#");
            entity.Property(e => e.NEXT_TIME).HasColumnType("DATE");
            entity.Property(e => e.PREV_RESETLOGS_CHANGE_)
                .HasColumnType("NUMBER")
                .HasColumnName("PREV_RESETLOGS_CHANGE#");
            entity.Property(e => e.PREV_RESET_TIMESTAMP).HasColumnType("NUMBER");
            entity.Property(e => e.RECID).HasColumnType("NUMBER");
            entity.Property(e => e.RECSTAMP).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE4).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE5).HasColumnType("NUMBER");
            entity.Property(e => e.STATUS).HasColumnType("NUMBER");
            entity.Property(e => e.STATUS_INFO)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.TIMESTAMP).HasColumnType("DATE");
        });

        modelBuilder.Entity<LOGMNR_NTAB_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }).HasName("LOGMNR_NTAB$_PK");

            entity.ToTable("LOGMNR_NTAB$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }, "LOGMNR_I1NTAB$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.NTAB_ }, "LOGMNR_I2NTAB$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.COL_)
                .HasColumnType("NUMBER")
                .HasColumnName("COL#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.NAME).IsUnicode(false);
            entity.Property(e => e.NTAB_)
                .HasColumnType("NUMBER")
                .HasColumnName("NTAB#");
        });

        modelBuilder.Entity<LOGMNR_OBJ_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_ }).HasName("LOGMNR_OBJ$_PK");

            entity.ToTable("LOGMNR_OBJ$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_ }, "LOGMNR_I1OBJ$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OID_ }, "LOGMNR_I2OBJ$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.NAME }, "LOGMNR_I3OBJ$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("OBJ#");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.LINKNAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.NAMESPACE).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJV_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("OBJV#");
            entity.Property(e => e.OID_).HasColumnName("OID$");
            entity.Property(e => e.OWNER_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("OWNER#");
            entity.Property(e => e.REMOTEOWNER)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER(22)");
            entity.Property(e => e.START_SCNBAS).HasColumnType("NUMBER");
            entity.Property(e => e.START_SCNWRP).HasColumnType("NUMBER");
            entity.Property(e => e.STIME).HasColumnType("DATE");
            entity.Property(e => e.SUBNAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.TYPE_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("TYPE#");
        });

        modelBuilder.Entity<LOGMNR_OPQTYPE_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }).HasName("LOGMNR_OPQTYPE$_PK");

            entity.ToTable("LOGMNR_OPQTYPE$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }, "LOGMNR_I1OPQTYPE$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.ELEMNUM).HasColumnType("NUMBER");
            entity.Property(e => e.EXTRACOL).HasColumnType("NUMBER");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.LOBCOL).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJCOL).HasColumnType("NUMBER");
            entity.Property(e => e.SCHEMAURL).IsUnicode(false);
            entity.Property(e => e.TYPE).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_PARAMETER_>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGMNR_PARAMETER$");

            entity.HasIndex(e => new { e.SESSION_, e.NAME }, "LOGMNR_PARAMETER_INDX");

            entity.Property(e => e.NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.SCN).HasColumnType("NUMBER");
            entity.Property(e => e.SESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("SESSION#");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.TYPE).HasColumnType("NUMBER");
            entity.Property(e => e.VALUE)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNR_PARTOBJ_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_ }).HasName("LOGMNR_PARTOBJ$_PK");

            entity.ToTable("LOGMNR_PARTOBJ$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_ }, "LOGMNR_I1PARTOBJ$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.DEFEXTPCT).HasColumnType("NUMBER");
            entity.Property(e => e.DEFEXTSIZE).HasColumnType("NUMBER");
            entity.Property(e => e.DEFGROUPS).HasColumnType("NUMBER");
            entity.Property(e => e.DEFINCLCOL).HasColumnType("NUMBER");
            entity.Property(e => e.DEFINITRANS).HasColumnType("NUMBER");
            entity.Property(e => e.DEFLISTS).HasColumnType("NUMBER");
            entity.Property(e => e.DEFLOGGING).HasColumnType("NUMBER");
            entity.Property(e => e.DEFMAXEXTS).HasColumnType("NUMBER");
            entity.Property(e => e.DEFMAXTRANS).HasColumnType("NUMBER");
            entity.Property(e => e.DEFMINEXTS).HasColumnType("NUMBER");
            entity.Property(e => e.DEFPCTFREE).HasColumnType("NUMBER");
            entity.Property(e => e.DEFPCTTHRES).HasColumnType("NUMBER");
            entity.Property(e => e.DEFPCTUSED).HasColumnType("NUMBER");
            entity.Property(e => e.DEFTINIEXTS).HasColumnType("NUMBER");
            entity.Property(e => e.DEFTS_)
                .HasColumnType("NUMBER")
                .HasColumnName("DEFTS#");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.PARAMETERS)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.PARTCNT).HasColumnType("NUMBER");
            entity.Property(e => e.PARTKEYCOLS).HasColumnType("NUMBER");
            entity.Property(e => e.PARTTYPE).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_PDB_INFO_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_DID, e.LOGMNR_MDH, e.PLUGIN_SCN }).HasName("LOGMNR_PDB_INFO$_PK");

            entity.ToTable("LOGMNR_PDB_INFO$");

            entity.Property(e => e.LOGMNR_DID).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_MDH).HasColumnType("NUMBER");
            entity.Property(e => e.PLUGIN_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.PDB_GLOBAL_NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.PDB_ID).HasColumnType("NUMBER");
            entity.Property(e => e.PDB_NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.PDB_UID).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).IsUnicode(false);
            entity.Property(e => e.SPARE4).HasPrecision(6);
            entity.Property(e => e.UNPLUG_SCN).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_PROCESSED_LOG_>(entity =>
        {
            entity.HasKey(e => new { e.SESSION_, e.THREAD_ }).HasName("LOGMNR_PROCESSED_LOG$_PK");

            entity.ToTable("LOGMNR_PROCESSED_LOG$");

            entity.Property(e => e.SESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("SESSION#");
            entity.Property(e => e.THREAD_)
                .HasColumnType("NUMBER")
                .HasColumnName("THREAD#");
            entity.Property(e => e.FILE_NAME)
                .HasMaxLength(513)
                .IsUnicode(false);
            entity.Property(e => e.FIRST_CHANGE_)
                .HasColumnType("NUMBER")
                .HasColumnName("FIRST_CHANGE#");
            entity.Property(e => e.FIRST_TIME).HasColumnType("DATE");
            entity.Property(e => e.INFO)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.NEXT_CHANGE_)
                .HasColumnType("NUMBER")
                .HasColumnName("NEXT_CHANGE#");
            entity.Property(e => e.NEXT_TIME).HasColumnType("DATE");
            entity.Property(e => e.SEQUENCE_)
                .HasColumnType("NUMBER")
                .HasColumnName("SEQUENCE#");
            entity.Property(e => e.STATUS).HasColumnType("NUMBER");
            entity.Property(e => e.TIMESTAMP).HasColumnType("DATE");
        });

        modelBuilder.Entity<LOGMNR_PROFILE_PLSQL_STATS_>(entity =>
        {
            entity.HasKey(e => new { e.PKGOWNER, e.PKGNAME, e.NAME }).HasName("LOGMNR_PROFILE_PLSQL$_PK");

            entity.ToTable("LOGMNR_PROFILE_PLSQL_STATS$");

            entity.Property(e => e.PKGOWNER)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.PKGNAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.NAME).HasColumnType("NUMBER");
            entity.Property(e => e.OGGUNSUPPOPNUM).HasColumnType("NUMBER");
            entity.Property(e => e.OPNUM).HasColumnType("NUMBER");
            entity.Property(e => e.PRAGMAOP).HasColumnType("NUMBER");
            entity.Property(e => e.REDORATE).HasColumnType("NUMBER");
            entity.Property(e => e.REDOSIZE).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.SPARE2)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE4).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE5).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE6).HasColumnType("NUMBER");
            entity.Property(e => e.TLSBYUNSUPPOPNUM).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_PROFILE_TABLE_STATS_>(entity =>
        {
            entity.HasKey(e => e.OBJID).HasName("LOGMNR_PROFILE_TABLE$_PK");

            entity.ToTable("LOGMNR_PROFILE_TABLE_STATS$");

            entity.Property(e => e.OBJID).HasColumnType("NUMBER");
            entity.Property(e => e.DDLNUM).HasColumnType("NUMBER");
            entity.Property(e => e.DELETENUM).HasColumnType("NUMBER");
            entity.Property(e => e.INSERTNUM).HasColumnType("NUMBER");
            entity.Property(e => e.MAXLOBSIZE).HasColumnType("NUMBER");
            entity.Property(e => e.NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.OGGFETCHOPNUM).HasColumnType("NUMBER");
            entity.Property(e => e.OGGPLSQLOPNUM).HasColumnType("NUMBER");
            entity.Property(e => e.OGGUNSUPPOPNUM).HasColumnType("NUMBER");
            entity.Property(e => e.OPNUM).HasColumnType("NUMBER");
            entity.Property(e => e.OWNER)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.PARTITIONATTR).HasColumnType("NUMBER");
            entity.Property(e => e.PARTNUM).HasColumnType("NUMBER");
            entity.Property(e => e.PROPERTY1).HasColumnType("NUMBER");
            entity.Property(e => e.PROPERTY2).HasColumnType("NUMBER");
            entity.Property(e => e.REDORATE).HasColumnType("NUMBER");
            entity.Property(e => e.REDOSIZE).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.SPARE2)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE4).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE5).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE6).HasColumnType("NUMBER");
            entity.Property(e => e.TLSBYUNSUPPOPNUM).HasColumnType("NUMBER");
            entity.Property(e => e.UPDATENUM).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_PROPS_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.NAME }).HasName("LOGMNR_PROPS$_PK");

            entity.ToTable("LOGMNR_PROPS$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.NAME }, "LOGMNR_I1PROPS$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.COMMENT_)
                .IsUnicode(false)
                .HasColumnName("COMMENT$");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.VALUE_)
                .IsUnicode(false)
                .HasColumnName("VALUE$");
        });

        modelBuilder.Entity<LOGMNR_REFCON_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }).HasName("LOGMNR_REFCON$_PK");

            entity.ToTable("LOGMNR_REFCON$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }, "LOGMNR_I1REFCON$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.COL_)
                .HasColumnType("NUMBER")
                .HasColumnName("COL#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.REFTYP).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_RESTART_CKPT_>(entity =>
        {
            entity.HasKey(e => new { e.SESSION_, e.CKPT_SCN, e.XIDUSN, e.XIDSLT, e.XIDSQN, e.PDBID, e.SESSION_NUM, e.SERIAL_NUM }).HasName("LOGMNR_RESTART_CKPT$_PK");

            entity.ToTable("LOGMNR_RESTART_CKPT$");

            entity.Property(e => e.SESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("SESSION#");
            entity.Property(e => e.CKPT_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.XIDUSN).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSLT).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSQN).HasColumnType("NUMBER");
            entity.Property(e => e.PDBID).HasColumnType("NUMBER");
            entity.Property(e => e.SESSION_NUM).HasColumnType("NUMBER");
            entity.Property(e => e.SERIAL_NUM).HasColumnType("NUMBER");
            entity.Property(e => e.CKPT_INFO).HasColumnType("BLOB");
            entity.Property(e => e.CLIENT_DATA).HasColumnType("BLOB");
            entity.Property(e => e.FLAG).HasColumnType("NUMBER");
            entity.Property(e => e.OFFSET).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.VALID).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_RESTART_CKPT_TXINFO_>(entity =>
        {
            entity.HasKey(e => new { e.SESSION_, e.XIDUSN, e.XIDSLT, e.XIDSQN, e.SESSION_NUM, e.SERIAL_NUM, e.EFFECTIVE_SCN }).HasName("LOGMNR_RESTART_CKPT_TXINFO$_PK");

            entity.ToTable("LOGMNR_RESTART_CKPT_TXINFO$");

            entity.Property(e => e.SESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("SESSION#");
            entity.Property(e => e.XIDUSN).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSLT).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSQN).HasColumnType("NUMBER");
            entity.Property(e => e.SESSION_NUM).HasColumnType("NUMBER");
            entity.Property(e => e.SERIAL_NUM).HasColumnType("NUMBER");
            entity.Property(e => e.EFFECTIVE_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.FLAG).HasColumnType("NUMBER");
            entity.Property(e => e.OFFSET).HasColumnType("NUMBER");
            entity.Property(e => e.START_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.TX_DATA).HasColumnType("BLOB");
        });

        modelBuilder.Entity<LOGMNR_SEED_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }).HasName("LOGMNR_SEED$_PK");

            entity.ToTable("LOGMNR_SEED$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_ }, "LOGMNR_I1SEED$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.SCHEMANAME, e.TABLE_NAME, e.COL_NAME, e.OBJ_, e.INTCOL_ }, "LOGMNR_I2SEED$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.COL_)
                .HasColumnType("NUMBER")
                .HasColumnName("COL#");
            entity.Property(e => e.COL_NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.GATHER_VERSION).HasColumnType("NUMBER(22)");
            entity.Property(e => e.LENGTH).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.NULL_)
                .HasColumnType("NUMBER")
                .HasColumnName("NULL$");
            entity.Property(e => e.OBJV_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("OBJV#");
            entity.Property(e => e.PRECISION_)
                .HasColumnType("NUMBER")
                .HasColumnName("PRECISION#");
            entity.Property(e => e.SCALE).HasColumnType("NUMBER");
            entity.Property(e => e.SCHEMANAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.SEED_VERSION).HasColumnType("NUMBER(22)");
            entity.Property(e => e.SEGCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("SEGCOL#");
            entity.Property(e => e.TABLE_NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.TYPE_)
                .HasColumnType("NUMBER")
                .HasColumnName("TYPE#");
        });

        modelBuilder.Entity<LOGMNR_SESSION_>(entity =>
        {
            entity.HasKey(e => e.SESSION_).HasName("LOGMNR_SESSION_PK");

            entity.ToTable("LOGMNR_SESSION$");

            entity.HasIndex(e => e.SESSION_NAME, "LOGMNR_SESSION_UK1").IsUnique();

            entity.Property(e => e.SESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("SESSION#");
            entity.Property(e => e.BRANCH_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.CLIENT_)
                .HasColumnType("NUMBER")
                .HasColumnName("CLIENT#");
            entity.Property(e => e.DB_ID).HasColumnType("NUMBER");
            entity.Property(e => e.END_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.GLOBAL_DB_NAME)
                .HasMaxLength(384)
                .IsUnicode(false)
                .HasDefaultValueSql("null");
            entity.Property(e => e.OLDEST_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.PURGE_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.REDO_COMPAT)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RESETLOGS_CHANGE_)
                .HasColumnType("NUMBER")
                .HasColumnName("RESETLOGS_CHANGE#");
            entity.Property(e => e.RESET_TIMESTAMP).HasColumnType("NUMBER");
            entity.Property(e => e.RESUME_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.SESSION_ATTR).HasColumnType("NUMBER");
            entity.Property(e => e.SESSION_ATTR_VERBOSE)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.SESSION_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE4).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE5).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE6).HasColumnType("DATE");
            entity.Property(e => e.SPARE7)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.SPARE8)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.SPARE9).HasColumnType("NUMBER");
            entity.Property(e => e.SPILL_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.SPILL_TIME).HasColumnType("DATE");
            entity.Property(e => e.START_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.VERSION)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNR_SESSION_ACTIONS_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNRSESSION_, e.ACTIONNAME }).HasName("LOGMNR_SESSION_ACTION$_PK");

            entity.ToTable("LOGMNR_SESSION_ACTIONS$");

            entity.Property(e => e.LOGMNRSESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("LOGMNRSESSION#");
            entity.Property(e => e.ACTIONNAME)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ACTIONTYPE_)
                .HasColumnType("NUMBER")
                .HasColumnName("ACTIONTYPE#");
            entity.Property(e => e.ATTR1).HasColumnType("NUMBER");
            entity.Property(e => e.ATTR2).HasColumnType("NUMBER");
            entity.Property(e => e.ATTR3).HasColumnType("NUMBER");
            entity.Property(e => e.CREATETIME).HasPrecision(6);
            entity.Property(e => e.DISPATCHTIME).HasPrecision(6);
            entity.Property(e => e.DROPSCN).HasColumnType("NUMBER");
            entity.Property(e => e.DROPTIME).HasPrecision(6);
            entity.Property(e => e.ENDSCN).HasColumnType("NUMBER");
            entity.Property(e => e.ENDSUBSCN).HasColumnType("NUMBER");
            entity.Property(e => e.FLAGSDEFINETIME).HasColumnType("NUMBER");
            entity.Property(e => e.FLAGSRUNTIME)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER");
            entity.Property(e => e.LCRCOUNT)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER");
            entity.Property(e => e.MODIFYTIME).HasPrecision(6);
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.PDBID).HasColumnType("NUMBER");
            entity.Property(e => e.PDB_NAME)
                .HasMaxLength(390)
                .IsUnicode(false);
            entity.Property(e => e.PROCESSROLE_)
                .HasColumnType("NUMBER")
                .HasColumnName("PROCESSROLE#");
            entity.Property(e => e.RBABLK).HasColumnType("NUMBER");
            entity.Property(e => e.RBABYTE).HasColumnType("NUMBER");
            entity.Property(e => e.RBASQN).HasColumnType("NUMBER");
            entity.Property(e => e.SESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("SESSION#");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).HasPrecision(6);
            entity.Property(e => e.SPARE4)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.STARTSCN).HasColumnType("NUMBER");
            entity.Property(e => e.STARTSUBSCN).HasColumnType("NUMBER");
            entity.Property(e => e.THREAD_)
                .HasColumnType("NUMBER")
                .HasColumnName("THREAD#");
            entity.Property(e => e.XIDSLT).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSQN).HasColumnType("NUMBER");
            entity.Property(e => e.XIDUSN).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_SESSION_EVOLVE_>(entity =>
        {
            entity.HasKey(e => new { e.SESSION_, e.DB_ID, e.RESET_SCN, e.RESET_TIMESTAMP }).HasName("LOGMNR_SESSION_EVOLVE$_PK");

            entity.ToTable("LOGMNR_SESSION_EVOLVE$");

            entity.Property(e => e.SESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("SESSION#");
            entity.Property(e => e.DB_ID).HasColumnType("NUMBER");
            entity.Property(e => e.RESET_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.RESET_TIMESTAMP).HasColumnType("NUMBER");
            entity.Property(e => e.BRANCH_LEVEL).HasColumnType("NUMBER");
            entity.Property(e => e.PREV_RESET_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.PREV_RESET_TIMESTAMP).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE4).HasColumnType("DATE");
            entity.Property(e => e.STATUS).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_SHARD_TS>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.TABLESPACE_NAME }).HasName("LOGMNR_SHARD_TS_PK");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.TABLESPACE_NAME }, "LOGMNR_I1SHARD_TS");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER");
            entity.Property(e => e.TABLESPACE_NAME)
                .HasMaxLength(90)
                .IsUnicode(false);
            entity.Property(e => e.CHUNK_NUMBER).HasColumnType("NUMBER");
            entity.Property(e => e.START_SCNBAS).HasColumnType("NUMBER");
            entity.Property(e => e.START_SCNWRP).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_SPILL_>(entity =>
        {
            entity.HasKey(e => new { e.SESSION_, e.PDBID, e.XIDUSN, e.XIDSLT, e.XIDSQN, e.CHUNK, e.STARTIDX, e.ENDIDX, e.FLAG, e.SEQUENCE_ }).HasName("LOGMNR_SPILL$_PK");

            entity.ToTable("LOGMNR_SPILL$");

            entity.Property(e => e.SESSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("SESSION#");
            entity.Property(e => e.PDBID).HasColumnType("NUMBER");
            entity.Property(e => e.XIDUSN).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSLT).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSQN).HasColumnType("NUMBER");
            entity.Property(e => e.CHUNK).HasColumnType("NUMBER");
            entity.Property(e => e.STARTIDX).HasColumnType("NUMBER");
            entity.Property(e => e.ENDIDX).HasColumnType("NUMBER");
            entity.Property(e => e.FLAG).HasColumnType("NUMBER");
            entity.Property(e => e.SEQUENCE_)
                .HasColumnType("NUMBER")
                .HasColumnName("SEQUENCE#");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPILL_DATA).HasColumnType("BLOB");
        });

        modelBuilder.Entity<LOGMNR_SUBCOLTYPE_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_, e.TOID }).HasName("LOGMNR_SUBCOLTYPE$_PK");

            entity.ToTable("LOGMNR_SUBCOLTYPE$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.INTCOL_, e.TOID }, "LOGMNR_I1SUBCOLTYPE$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.INTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("INTCOL#");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.INTCOLS).HasColumnType("NUMBER");
            entity.Property(e => e.INTCOL_S).HasColumnName("INTCOL#S");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.SYNOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("SYNOBJ#");
            entity.Property(e => e.VERSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("VERSION#");
        });

        modelBuilder.Entity<LOGMNR_TABCOMPART_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_ }).HasName("LOGMNR_TABCOMPART$_PK");

            entity.ToTable("LOGMNR_TABCOMPART$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_ }, "LOGMNR_I1TABCOMPART$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.BO_ }, "LOGMNR_I2TABCOMPART$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("OBJ#");
            entity.Property(e => e.BO_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("BO#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.PART_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("PART#");
        });

        modelBuilder.Entity<LOGMNR_TABPART_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.BO_ }).HasName("LOGMNR_TABPART$_PK");

            entity.ToTable("LOGMNR_TABPART$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.BO_ }, "LOGMNR_I1TABPART$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.BO_ }, "LOGMNR_I2TABPART$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("OBJ#");
            entity.Property(e => e.BO_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("BO#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.PART_)
                .HasColumnType("NUMBER")
                .HasColumnName("PART#");
            entity.Property(e => e.TS_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("TS#");
        });

        modelBuilder.Entity<LOGMNR_TABSUBPART_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_, e.POBJ_ }).HasName("LOGMNR_TABSUBPART$_PK");

            entity.ToTable("LOGMNR_TABSUBPART$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_, e.POBJ_ }, "LOGMNR_I1TABSUBPART$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.POBJ_ }, "LOGMNR_I2TABSUBPART$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("OBJ#");
            entity.Property(e => e.POBJ_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("POBJ#");
            entity.Property(e => e.DATAOBJ_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("DATAOBJ#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.SUBPART_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("SUBPART#");
            entity.Property(e => e.TS_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("TS#");
        });

        modelBuilder.Entity<LOGMNR_TAB_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.OBJ_ }).HasName("LOGMNR_TAB$_PK");

            entity.ToTable("LOGMNR_TAB$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.OBJ_ }, "LOGMNR_I1TAB$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.BOBJ_ }, "LOGMNR_I2TAB$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("OBJ#");
            entity.Property(e => e.ACDRFLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.ACDRROWTSINTCOL_)
                .HasColumnType("NUMBER")
                .HasColumnName("ACDRROWTSINTCOL#");
            entity.Property(e => e.ACDRTSOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("ACDRTSOBJ#");
            entity.Property(e => e.BOBJ_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("BOBJ#");
            entity.Property(e => e.COLS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.INTCOLS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.KERNELCOLS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.PROPERTY).HasColumnType("NUMBER");
            entity.Property(e => e.TRIGFLAG).HasColumnType("NUMBER(22)");
            entity.Property(e => e.TS_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("TS#");
        });

        modelBuilder.Entity<LOGMNR_TS_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.TS_ }).HasName("LOGMNR_TS$_PK");

            entity.ToTable("LOGMNR_TS$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.TS_ }, "LOGMNR_I1TS$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.TS_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("TS#");
            entity.Property(e => e.BLOCKSIZE).HasColumnType("NUMBER(22)");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.NAME)
                .HasMaxLength(90)
                .IsUnicode(false);
            entity.Property(e => e.OWNER_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("OWNER#");
            entity.Property(e => e.START_SCNBAS).HasColumnType("NUMBER");
            entity.Property(e => e.START_SCNWRP).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_TYPE_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.TOID, e.VERSION_ }).HasName("LOGMNR_TYPE$_PK");

            entity.ToTable("LOGMNR_TYPE$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.TOID, e.VERSION_ }, "LOGMNR_I1TYPE$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.VERSION_)
                .HasColumnType("NUMBER")
                .HasColumnName("VERSION#");
            entity.Property(e => e.ATTRIBUTES).HasColumnType("NUMBER");
            entity.Property(e => e.EXTERNNAME).IsUnicode(false);
            entity.Property(e => e.EXTERNTYPE).HasColumnType("NUMBER");
            entity.Property(e => e.HASHCODE).HasMaxLength(17);
            entity.Property(e => e.HELPERCLASSNAME).IsUnicode(false);
            entity.Property(e => e.HIDDENMETHODS).HasColumnType("NUMBER");
            entity.Property(e => e.LOCAL_ATTRS).HasColumnType("NUMBER");
            entity.Property(e => e.LOCAL_METHODS).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.METHODS).HasColumnType("NUMBER");
            entity.Property(e => e.PROPERTIES).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER");
            entity.Property(e => e.SUBTYPES).HasColumnType("NUMBER");
            entity.Property(e => e.SUPERTYPES).HasColumnType("NUMBER");
            entity.Property(e => e.TYPECODE).HasColumnType("NUMBER");
            entity.Property(e => e.VERSION)
                .HasMaxLength(384)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LOGMNR_UID_>(entity =>
        {
            entity.HasKey(e => e.LOGMNR_UID).HasName("LOGMNR_UID$_PK");

            entity.ToTable("LOGMNR_UID$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.END_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_DID).HasColumnType("NUMBER");
            entity.Property(e => e.LOGMNR_MDH).HasColumnType("NUMBER");
            entity.Property(e => e.PDB_ID).HasColumnType("NUMBER");
            entity.Property(e => e.PDB_NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.PDB_UID).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).IsUnicode(false);
            entity.Property(e => e.SPARE4).HasPrecision(6);
            entity.Property(e => e.START_SCN).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGMNR_USER_>(entity =>
        {
            entity.HasKey(e => new { e.LOGMNR_UID, e.USER_ }).HasName("LOGMNR_USER$_PK");

            entity.ToTable("LOGMNR_USER$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.USER_ }, "LOGMNR_I1USER$");

            entity.HasIndex(e => new { e.LOGMNR_UID, e.NAME }, "LOGMNR_I2USER$");

            entity.Property(e => e.LOGMNR_UID).HasColumnType("NUMBER(22)");
            entity.Property(e => e.USER_)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("USER#");
            entity.Property(e => e.LOGMNR_FLAGS).HasColumnType("NUMBER(22)");
            entity.Property(e => e.NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGSTDBY_APPLY_MILESTONE>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGSTDBY$APPLY_MILESTONE");

            entity.Property(e => e.COMMIT_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.COMMIT_TIME).HasColumnType("DATE");
            entity.Property(e => e.EPOCH).HasColumnType("NUMBER");
            entity.Property(e => e.FETCHLWM_SCN)
                .HasDefaultValueSql("(0) ")
                .HasColumnType("NUMBER");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.LWM_UPD_TIME).HasColumnType("DATE");
            entity.Property(e => e.PROCESSED_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.PROCESSED_TIME).HasColumnType("DATE");
            entity.Property(e => e.PTO_RECOVERY_INCARNATION).HasColumnType("NUMBER");
            entity.Property(e => e.PTO_RECOVERY_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.SESSION_ID).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.SPARE4).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE5).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE6).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE7).HasColumnType("DATE");
            entity.Property(e => e.SYNCH_SCN).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGSTDBY_APPLY_PROGRESS>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGSTDBY$APPLY_PROGRESS");

            entity.Property(e => e.COMMIT_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.COMMIT_TIME).HasColumnType("DATE");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.XIDSLT).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSQN).HasColumnType("NUMBER");
            entity.Property(e => e.XIDUSN).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGSTDBY_EDS_TABLES>(entity =>
        {
            entity.HasKey(e => new { e.OWNER, e.TABLE_NAME }).HasName("LOGSTDBY$EDS_TABLES_PKEY");

            entity.ToTable("LOGSTDBY$EDS_TABLES");

            entity.Property(e => e.OWNER)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.TABLE_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.BASE_TRIGGER_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.CTIME).HasPrecision(6);
            entity.Property(e => e.DBLINK)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.MVIEW_LOG_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.MVIEW_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.MVIEW_TRIGGER_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.OBJV).HasColumnType("NUMBER");
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.SHADOW_TABLE_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.SHADOW_TRIGGER_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.SOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("SOBJ#");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER");
            entity.Property(e => e.STATE)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LOGSTDBY_EVENTS>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGSTDBY$EVENTS");

            entity.HasIndex(e => e.EVENT_TIME, "LOGSTDBY$EVENTS_IND");

            entity.HasIndex(e => e.COMMIT_SCN, "LOGSTDBY$EVENTS_IND_SCN");

            entity.HasIndex(e => new { e.XIDUSN, e.XIDSLT, e.XIDSQN }, "LOGSTDBY$EVENTS_IND_XID");

            entity.Property(e => e.COMMIT_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.CON_ID).HasColumnType("NUMBER");
            entity.Property(e => e.CON_NAME)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CURRENT_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.ERROR)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ERRVAL).HasColumnType("NUMBER");
            entity.Property(e => e.EVENT)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.EVENT_TIME).HasPrecision(6);
            entity.Property(e => e.FULL_EVENT).HasColumnType("CLOB");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.XIDSLT).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSQN).HasColumnType("NUMBER");
            entity.Property(e => e.XIDUSN).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGSTDBY_FLASHBACK_SCN>(entity =>
        {
            entity.HasKey(e => e.PRIMARY_SCN).HasName("SYS_C005845");

            entity.ToTable("LOGSTDBY$FLASHBACK_SCN");

            entity.Property(e => e.PRIMARY_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.PRIMARY_TIME).HasColumnType("DATE");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).HasColumnType("DATE");
            entity.Property(e => e.STANDBY_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.STANDBY_TIME).HasColumnType("DATE");
        });

        modelBuilder.Entity<LOGSTDBY_HISTORY>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGSTDBY$HISTORY");

            entity.Property(e => e.DBID).HasColumnType("NUMBER");
            entity.Property(e => e.DGNAME)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FIRST_CHANGE_)
                .HasColumnType("NUMBER")
                .HasColumnName("FIRST_CHANGE#");
            entity.Property(e => e.FIRST_TIME).HasColumnType("DATE");
            entity.Property(e => e.LAST_CHANGE_)
                .HasColumnType("NUMBER")
                .HasColumnName("LAST_CHANGE#");
            entity.Property(e => e.LAST_TIME).HasColumnType("DATE");
            entity.Property(e => e.LMNR_SID).HasColumnType("NUMBER");
            entity.Property(e => e.SOURCE).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.STATUS).HasColumnType("NUMBER");
            entity.Property(e => e.STREAM_SEQUENCE_)
                .HasColumnType("NUMBER")
                .HasColumnName("STREAM_SEQUENCE#");
        });

        modelBuilder.Entity<LOGSTDBY_PARAMETERS>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGSTDBY$PARAMETERS");

            entity.Property(e => e.NAME)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SCN).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.TYPE).HasColumnType("NUMBER");
            entity.Property(e => e.VALUE)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LOGSTDBY_PLSQL>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGSTDBY$PLSQL");

            entity.Property(e => e.CALL_TEXT).HasColumnType("CLOB");
            entity.Property(e => e.SESSION_ID).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.START_FINISH).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGSTDBY_SCN>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGSTDBY$SCN");

            entity.Property(e => e.OBJNAME).IsUnicode(false);
            entity.Property(e => e.OBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("OBJ#");
            entity.Property(e => e.SCHEMA)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.SCN).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.TYPE)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LOGSTDBY_SKIP>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGSTDBY$SKIP");

            entity.HasIndex(e => new { e.USE_LIKE, e.SCHEMA, e.NAME }, "LOGSTDBY$SKIP_IDX1");

            entity.HasIndex(e => e.STATEMENT_OPT, "LOGSTDBY$SKIP_IDX2");

            entity.Property(e => e.ACTIVE).HasColumnType("NUMBER");
            entity.Property(e => e.ERROR).HasColumnType("NUMBER");
            entity.Property(e => e.ESC)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NAME)
                .HasMaxLength(261)
                .IsUnicode(false);
            entity.Property(e => e.PROC)
                .HasMaxLength(392)
                .IsUnicode(false);
            entity.Property(e => e.SCHEMA)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.STATEMENT_OPT)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.USE_LIKE).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<LOGSTDBY_SKIP_SUPPORT>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGSTDBY$SKIP_SUPPORT");

            entity.HasIndex(e => new { e.NAME, e.ACTION }, "LOGSTDBY$SKIP_IND");

            entity.Property(e => e.ACTION).HasColumnType("NUMBER");
            entity.Property(e => e.NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.NAME2)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.NAME3)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.NAME4)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.NAME5)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.REG).HasColumnType("NUMBER(38)");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(2000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LOGSTDBY_SKIP_TRANSACTION>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGSTDBY$SKIP_TRANSACTION");

            entity.Property(e => e.ACTIVE).HasColumnType("NUMBER");
            entity.Property(e => e.COMMIT_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.CON_NAME)
                .HasMaxLength(384)
                .IsUnicode(false);
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.XIDSLT).HasColumnType("NUMBER");
            entity.Property(e => e.XIDSQN).HasColumnType("NUMBER");
            entity.Property(e => e.XIDUSN).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<MVIEW_EVALUATIONS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MVIEW_EVALUATIONS");

            entity.Property(e => e.BENEFIT_TO_COST_RATIO).HasColumnType("NUMBER");
            entity.Property(e => e.CUMULATIVE_BENEFIT).HasColumnType("NUMBER");
            entity.Property(e => e.FREQUENCY).HasColumnType("NUMBER");
            entity.Property(e => e.MVIEW_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.MVIEW_OWNER)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.RANK).HasColumnType("NUMBER");
            entity.Property(e => e.RUNID).HasColumnType("NUMBER");
            entity.Property(e => e.STORAGE_IN_BYTES).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<MVIEW_EXCEPTIONS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MVIEW_EXCEPTIONS");

            entity.Property(e => e.BAD_ROWID).HasColumnType("ROWID");
            entity.Property(e => e.DIMENSION_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.OWNER)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.RELATIONSHIP)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.RUNID).HasColumnType("NUMBER");
            entity.Property(e => e.TABLE_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MVIEW_FILTER>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MVIEW_FILTER");

            entity.Property(e => e.DATE_VALUE1).HasColumnType("DATE");
            entity.Property(e => e.DATE_VALUE2).HasColumnType("DATE");
            entity.Property(e => e.FILTERID).HasColumnType("NUMBER");
            entity.Property(e => e.NUM_VALUE1).HasColumnType("NUMBER");
            entity.Property(e => e.NUM_VALUE2).HasColumnType("NUMBER");
            entity.Property(e => e.STR_VALUE)
                .HasMaxLength(1028)
                .IsUnicode(false);
            entity.Property(e => e.SUBFILTERNUM).HasColumnType("NUMBER");
            entity.Property(e => e.SUBFILTERTYPE)
                .HasMaxLength(12)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MVIEW_FILTERINSTANCE>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MVIEW_FILTERINSTANCE");

            entity.Property(e => e.DATE_VALUE1).HasColumnType("DATE");
            entity.Property(e => e.DATE_VALUE2).HasColumnType("DATE");
            entity.Property(e => e.FILTERID).HasColumnType("NUMBER");
            entity.Property(e => e.NUM_VALUE1).HasColumnType("NUMBER");
            entity.Property(e => e.NUM_VALUE2).HasColumnType("NUMBER");
            entity.Property(e => e.RUNID).HasColumnType("NUMBER");
            entity.Property(e => e.STR_VALUE)
                .HasMaxLength(1028)
                .IsUnicode(false);
            entity.Property(e => e.SUBFILTERNUM).HasColumnType("NUMBER");
            entity.Property(e => e.SUBFILTERTYPE)
                .HasMaxLength(12)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MVIEW_LOG>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MVIEW_LOG");

            entity.Property(e => e.COMPLETED).HasColumnType("NUMBER");
            entity.Property(e => e.ERROR_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FILTERID).HasColumnType("NUMBER");
            entity.Property(e => e.ID).HasColumnType("NUMBER");
            entity.Property(e => e.MESSAGE)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.RUN_BEGIN).HasColumnType("DATE");
            entity.Property(e => e.RUN_END).HasColumnType("DATE");
            entity.Property(e => e.STATUS)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.TOTAL).HasColumnType("NUMBER");
            entity.Property(e => e.TYPE)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MVIEW_RECOMMENDATIONS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MVIEW_RECOMMENDATIONS");

            entity.Property(e => e.ALL_TABLES)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.BENEFIT_TO_COST_RATIO).HasColumnType("NUMBER");
            entity.Property(e => e.FACT_TABLES)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.GROUPING_LEVELS)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.MVIEW_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.MVIEW_OWNER)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.PCT_PERFORMANCE_GAIN).HasColumnType("NUMBER");
            entity.Property(e => e.QUERY_TEXT).HasColumnType("LONG");
            entity.Property(e => e.RECOMMENDATION_NUMBER).HasColumnType("NUMBER");
            entity.Property(e => e.RECOMMENDED_ACTION)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.RUNID).HasColumnType("NUMBER");
            entity.Property(e => e.STORAGE_IN_BYTES).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<MVIEW_WORKLOAD>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MVIEW_WORKLOAD");

            entity.Property(e => e.APPLICATION)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.CARDINALITY).HasColumnType("NUMBER");
            entity.Property(e => e.FREQUENCY).HasColumnType("NUMBER");
            entity.Property(e => e.IMPORT_TIME).HasColumnType("DATE");
            entity.Property(e => e.LASTUSE).HasColumnType("DATE");
            entity.Property(e => e.OWNER)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.PRIORITY).HasColumnType("NUMBER");
            entity.Property(e => e.QUERY).HasColumnType("LONG");
            entity.Property(e => e.QUERYID).HasColumnType("NUMBER");
            entity.Property(e => e.RESPONSETIME).HasColumnType("NUMBER");
            entity.Property(e => e.RESULTSIZE).HasColumnType("NUMBER");
            entity.Property(e => e.WORKLOADID).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<MVIEW__ADV_AJG>(entity =>
        {
            entity.HasKey(e => e.AJGID_).HasName("MVIEW$_ADV_AJG_PK");

            entity.ToTable("MVIEW$_ADV_AJG", tb => tb.HasComment("Anchor-join graph representation"));

            entity.Property(e => e.AJGID_)
                .HasColumnType("NUMBER")
                .HasColumnName("AJGID#");
            entity.Property(e => e.AJGDES).HasColumnType("LONG RAW");
            entity.Property(e => e.AJGDESLEN).HasColumnType("NUMBER");
            entity.Property(e => e.FREQUENCY).HasColumnType("NUMBER");
            entity.Property(e => e.HASHVALUE).HasColumnType("NUMBER");
            entity.Property(e => e.RUNID_)
                .HasColumnType("NUMBER")
                .HasColumnName("RUNID#");

            entity.HasOne(d => d.RUNID_Navigation).WithMany(p => p.MVIEW__ADV_AJG)
                .HasForeignKey(d => d.RUNID_)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MVIEW$_ADV_AJG_FK");
        });

        modelBuilder.Entity<MVIEW__ADV_BASETABLE>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MVIEW$_ADV_BASETABLE", tb => tb.HasComment("Base tables refered by a query"));

            entity.HasIndex(e => e.QUERYID_, "MVIEW$_ADV_BASETABLE_IDX_01");

            entity.Property(e => e.COLLECTIONID_)
                .HasColumnType("NUMBER")
                .HasColumnName("COLLECTIONID#");
            entity.Property(e => e.OWNER)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.QUERYID_)
                .HasColumnType("NUMBER")
                .HasColumnName("QUERYID#");
            entity.Property(e => e.TABLE_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.TABLE_TYPE).HasColumnType("NUMBER");

            entity.HasOne(d => d.QUERYID_Navigation).WithMany()
                .HasForeignKey(d => d.QUERYID_)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MVIEW$_ADV_BASETABLE_FK");
        });

        modelBuilder.Entity<MVIEW__ADV_CLIQUE>(entity =>
        {
            entity.HasKey(e => e.CLIQUEID_).HasName("MVIEW$_ADV_CLIQUE_PK");

            entity.ToTable("MVIEW$_ADV_CLIQUE", tb => tb.HasComment("Table for storing canonical form of Clique queries"));

            entity.Property(e => e.CLIQUEID_)
                .HasColumnType("NUMBER")
                .HasColumnName("CLIQUEID#");
            entity.Property(e => e.BYTECOST).HasColumnType("NUMBER");
            entity.Property(e => e.CLIQUEDES).HasColumnType("LONG RAW");
            entity.Property(e => e.CLIQUEDESLEN).HasColumnType("NUMBER");
            entity.Property(e => e.FREQUENCY).HasColumnType("NUMBER");
            entity.Property(e => e.HASHVALUE).HasColumnType("NUMBER");
            entity.Property(e => e.NUMROWS).HasColumnType("NUMBER");
            entity.Property(e => e.ROWSIZE).HasColumnType("NUMBER");
            entity.Property(e => e.RUNID_)
                .HasColumnType("NUMBER")
                .HasColumnName("RUNID#");

            entity.HasOne(d => d.RUNID_Navigation).WithMany(p => p.MVIEW__ADV_CLIQUE)
                .HasForeignKey(d => d.RUNID_)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MVIEW$_ADV_CLIQUE_FK");
        });

        modelBuilder.Entity<MVIEW__ADV_ELIGIBLE>(entity =>
        {
            entity.HasKey(e => new { e.SUMOBJN_, e.RUNID_ }).HasName("MVIEW$_ADV_ELIGIBLE_PK");

            entity.ToTable("MVIEW$_ADV_ELIGIBLE", tb => tb.HasComment("Summary management rewrite eligibility information"));

            entity.Property(e => e.SUMOBJN_)
                .HasColumnType("NUMBER")
                .HasColumnName("SUMOBJN#");
            entity.Property(e => e.RUNID_)
                .HasColumnType("NUMBER")
                .HasColumnName("RUNID#");
            entity.Property(e => e.BYTECOST).HasColumnType("NUMBER");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.FREQUENCY).HasColumnType("NUMBER");

            entity.HasOne(d => d.RUNID_Navigation).WithMany(p => p.MVIEW__ADV_ELIGIBLE)
                .HasForeignKey(d => d.RUNID_)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MVIEW$_ADV_ELIGIBLE_FK");
        });

        modelBuilder.Entity<MVIEW__ADV_EXCEPTIONS>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MVIEW$_ADV_EXCEPTIONS", tb => tb.HasComment("Output table for dimension validations"));

            entity.Property(e => e.BAD_ROWID).HasColumnType("ROWID");
            entity.Property(e => e.DIMENSION_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.OWNER)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.RELATIONSHIP)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.RUNID_)
                .HasColumnType("NUMBER")
                .HasColumnName("RUNID#");
            entity.Property(e => e.TABLE_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.RUNID_Navigation).WithMany()
                .HasForeignKey(d => d.RUNID_)
                .HasConstraintName("MVIEW$_ADV_EXCEPTION_FK");
        });

        modelBuilder.Entity<MVIEW__ADV_FILTER>(entity =>
        {
            entity.HasKey(e => new { e.FILTERID_, e.SUBFILTERNUM_ }).HasName("MVIEW$_ADV_FILTER_PK");

            entity.ToTable("MVIEW$_ADV_FILTER", tb => tb.HasComment("Table for workload filter definition"));

            entity.Property(e => e.FILTERID_)
                .HasColumnType("NUMBER")
                .HasColumnName("FILTERID#");
            entity.Property(e => e.SUBFILTERNUM_)
                .HasColumnType("NUMBER")
                .HasColumnName("SUBFILTERNUM#");
            entity.Property(e => e.DATE_VALUE1).HasColumnType("DATE");
            entity.Property(e => e.DATE_VALUE2).HasColumnType("DATE");
            entity.Property(e => e.NUM_VALUE1).HasColumnType("NUMBER");
            entity.Property(e => e.NUM_VALUE2).HasColumnType("NUMBER");
            entity.Property(e => e.STR_VALUE)
                .HasMaxLength(1028)
                .IsUnicode(false);
            entity.Property(e => e.SUBFILTERTYPE).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<MVIEW__ADV_FILTERINSTANCE>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MVIEW$_ADV_FILTERINSTANCE", tb => tb.HasComment("Table for workload filter instance definition"));

            entity.Property(e => e.DATE_VALUE1).HasColumnType("DATE");
            entity.Property(e => e.DATE_VALUE2).HasColumnType("DATE");
            entity.Property(e => e.FILTERID_)
                .HasColumnType("NUMBER")
                .HasColumnName("FILTERID#");
            entity.Property(e => e.NUM_VALUE1).HasColumnType("NUMBER");
            entity.Property(e => e.NUM_VALUE2).HasColumnType("NUMBER");
            entity.Property(e => e.RUNID_)
                .HasColumnType("NUMBER")
                .HasColumnName("RUNID#");
            entity.Property(e => e.STR_VALUE)
                .HasMaxLength(1028)
                .IsUnicode(false);
            entity.Property(e => e.SUBFILTERNUM_)
                .HasColumnType("NUMBER")
                .HasColumnName("SUBFILTERNUM#");
            entity.Property(e => e.SUBFILTERTYPE).HasColumnType("NUMBER");

            entity.HasOne(d => d.RUNID_Navigation).WithMany()
                .HasForeignKey(d => d.RUNID_)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MVIEW$_ADV_FILTERINSTANCE_FK");
        });

        modelBuilder.Entity<MVIEW__ADV_FJG>(entity =>
        {
            entity.HasKey(e => e.FJGID_).HasName("MVIEW$_ADV_FJG_PK");

            entity.ToTable("MVIEW$_ADV_FJG", tb => tb.HasComment("Representation for query join sub-graph not in AJG "));

            entity.Property(e => e.FJGID_)
                .HasColumnType("NUMBER")
                .HasColumnName("FJGID#");
            entity.Property(e => e.AJGID_)
                .HasColumnType("NUMBER")
                .HasColumnName("AJGID#");
            entity.Property(e => e.FJGDES).HasColumnType("LONG RAW");
            entity.Property(e => e.FJGDESLEN).HasColumnType("NUMBER");
            entity.Property(e => e.FREQUENCY).HasColumnType("NUMBER");
            entity.Property(e => e.HASHVALUE).HasColumnType("NUMBER");

            entity.HasOne(d => d.AJGID_Navigation).WithMany(p => p.MVIEW__ADV_FJG)
                .HasForeignKey(d => d.AJGID_)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MVIEW$_ADV_FJG_FK");
        });

        modelBuilder.Entity<MVIEW__ADV_GC>(entity =>
        {
            entity.HasKey(e => e.GCID_).HasName("MVIEW$_ADV_GC_PK");

            entity.ToTable("MVIEW$_ADV_GC", tb => tb.HasComment("Group-by columns of a query"));

            entity.Property(e => e.GCID_)
                .HasColumnType("NUMBER")
                .HasColumnName("GCID#");
            entity.Property(e => e.FJGID_)
                .HasColumnType("NUMBER")
                .HasColumnName("FJGID#");
            entity.Property(e => e.FREQUENCY).HasColumnType("NUMBER");
            entity.Property(e => e.GCDES).HasColumnType("LONG RAW");
            entity.Property(e => e.GCDESLEN).HasColumnType("NUMBER");
            entity.Property(e => e.HASHVALUE).HasColumnType("NUMBER");

            entity.HasOne(d => d.FJGID_Navigation).WithMany(p => p.MVIEW__ADV_GC)
                .HasForeignKey(d => d.FJGID_)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MVIEW$_ADV_GC_FK");
        });

        modelBuilder.Entity<MVIEW__ADV_INFO>(entity =>
        {
            entity.HasKey(e => new { e.RUNID_, e.SEQ_ }).HasName("MVIEW$_ADV_INFO_PK");

            entity.ToTable("MVIEW$_ADV_INFO", tb => tb.HasComment("Internal table for passing information from the SQL analyzer"));

            entity.Property(e => e.RUNID_)
                .HasColumnType("NUMBER")
                .HasColumnName("RUNID#");
            entity.Property(e => e.SEQ_)
                .HasColumnType("NUMBER")
                .HasColumnName("SEQ#");
            entity.Property(e => e.FLAG).HasColumnType("NUMBER");
            entity.Property(e => e.INFO).HasColumnType("LONG RAW");
            entity.Property(e => e.INFOLEN).HasColumnType("NUMBER");
            entity.Property(e => e.STATUS).HasColumnType("NUMBER");
            entity.Property(e => e.TYPE).HasColumnType("NUMBER");

            entity.HasOne(d => d.RUNID_Navigation).WithMany(p => p.MVIEW__ADV_INFO)
                .HasForeignKey(d => d.RUNID_)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MVIEW$_ADV_INFO_FK");
        });

        modelBuilder.Entity<MVIEW__ADV_JOURNAL>(entity =>
        {
            entity.HasKey(e => new { e.RUNID_, e.SEQ_ }).HasName("MVIEW$_ADV_JOURNAL_PK");

            entity.ToTable("MVIEW$_ADV_JOURNAL", tb => tb.HasComment("Summary advisor journal table for debugging and information"));

            entity.Property(e => e.RUNID_)
                .HasColumnType("NUMBER")
                .HasColumnName("RUNID#");
            entity.Property(e => e.SEQ_)
                .HasColumnType("NUMBER")
                .HasColumnName("SEQ#");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.NUM).HasColumnType("NUMBER");
            entity.Property(e => e.TEXT).HasColumnType("LONG");
            entity.Property(e => e.TEXTLEN).HasColumnType("NUMBER");
            entity.Property(e => e.TIMESTAMP).HasColumnType("DATE");

            entity.HasOne(d => d.RUNID_Navigation).WithMany(p => p.MVIEW__ADV_JOURNAL)
                .HasForeignKey(d => d.RUNID_)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MVIEW$_ADV_JOURNAL_FK");
        });

        modelBuilder.Entity<MVIEW__ADV_LEVEL>(entity =>
        {
            entity.HasKey(e => new { e.RUNID_, e.LEVELID_ }).HasName("MVIEW$_ADV_LEVEL_PK");

            entity.ToTable("MVIEW$_ADV_LEVEL", tb => tb.HasComment("Level definition"));

            entity.Property(e => e.RUNID_)
                .HasColumnType("NUMBER")
                .HasColumnName("RUNID#");
            entity.Property(e => e.LEVELID_)
                .HasColumnType("NUMBER")
                .HasColumnName("LEVELID#");
            entity.Property(e => e.COLUMNLIST).HasMaxLength(70);
            entity.Property(e => e.DIMOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("DIMOBJ#");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.LEVELNAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.TBLOBJ_)
                .HasColumnType("NUMBER")
                .HasColumnName("TBLOBJ#");

            entity.HasOne(d => d.RUNID_Navigation).WithMany(p => p.MVIEW__ADV_LEVEL)
                .HasForeignKey(d => d.RUNID_)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MVIEW$_ADV_LEVEL_FK");
        });

        modelBuilder.Entity<MVIEW__ADV_LOG>(entity =>
        {
            entity.HasKey(e => e.RUNID_).HasName("MVIEW$_ADV_LOG_PK");

            entity.ToTable("MVIEW$_ADV_LOG", tb => tb.HasComment("Log all calls to summary advisory functions"));

            entity.Property(e => e.RUNID_)
                .HasColumnType("NUMBER")
                .HasColumnName("RUNID#");
            entity.Property(e => e.COMPLETED).HasColumnType("NUMBER");
            entity.Property(e => e.ERROR_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FILTERID_)
                .HasColumnType("NUMBER")
                .HasColumnName("FILTERID#");
            entity.Property(e => e.MESSAGE)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.RUN_BEGIN).HasColumnType("DATE");
            entity.Property(e => e.RUN_END).HasColumnType("DATE");
            entity.Property(e => e.RUN_TYPE).HasColumnType("NUMBER");
            entity.Property(e => e.STATUS).HasColumnType("NUMBER");
            entity.Property(e => e.TOTAL).HasColumnType("NUMBER");
            entity.Property(e => e.UNAME)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MVIEW__ADV_OUTPUT>(entity =>
        {
            entity.HasKey(e => new { e.RUNID_, e.RANK_ }).HasName("MVIEW$_ADV_OUTPUT_PK");

            entity.ToTable("MVIEW$_ADV_OUTPUT", tb => tb.HasComment("Output table for summary recommendations and evaluations"));

            entity.Property(e => e.RUNID_)
                .HasColumnType("NUMBER")
                .HasColumnName("RUNID#");
            entity.Property(e => e.RANK_)
                .HasColumnType("NUMBER")
                .HasColumnName("RANK#");
            entity.Property(e => e.ACTION_TYPE)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.BENEFIT_TO_COST_RATIO).HasColumnType("NUMBER");
            entity.Property(e => e.CUMULATIVE_BENEFIT).HasColumnType("NUMBER");
            entity.Property(e => e.FACT_TABLES)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.FREQUENCY).HasColumnType("NUMBER");
            entity.Property(e => e.FROM_CLAUSE)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.GROUPING_LEVELS)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.GROUP_BY_COLUMNS)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.MEASURES_LIST)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.OUTPUT_TYPE).HasColumnType("NUMBER");
            entity.Property(e => e.PCT_PERFORMANCE_GAIN).HasColumnType("NUMBER");
            entity.Property(e => e.QUERYLEN).HasColumnType("NUMBER");
            entity.Property(e => e.QUERY_TEXT).HasColumnType("LONG");
            entity.Property(e => e.STORAGE_IN_BYTES).HasColumnType("NUMBER");
            entity.Property(e => e.SUMMARY_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.SUMMARY_OWNER)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.VALIDATED).HasColumnType("NUMBER");
            entity.Property(e => e.WHERE_CLAUSE)
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.HasOne(d => d.RUNID_Navigation).WithMany(p => p.MVIEW__ADV_OUTPUT)
                .HasForeignKey(d => d.RUNID_)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MVIEW$_ADV_OUTPUT_FK");
        });

        modelBuilder.Entity<MVIEW__ADV_PARAMETERS>(entity =>
        {
            entity.HasKey(e => e.PARAMETER_NAME).HasName("MVIEW$_ADV_PARAMETERS_PK");

            entity.ToTable("MVIEW$_ADV_PARAMETERS", tb => tb.HasComment("Summary advisor tuning parameters"));

            entity.Property(e => e.PARAMETER_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.DATE_VALUE).HasColumnType("DATE");
            entity.Property(e => e.NUMERICAL_VALUE).HasColumnType("NUMBER");
            entity.Property(e => e.PARAMETER_TYPE).HasColumnType("NUMBER");
            entity.Property(e => e.STRING_VALUE)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MVIEW__ADV_PLAN>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MVIEW$_ADV_PLAN", tb => tb.HasComment("Private plan table for estimate_mview_size operations"));

            entity.Property(e => e.BYTES).HasColumnType("NUMBER(38)");
            entity.Property(e => e.CARDINALITY).HasColumnType("NUMBER(38)");
            entity.Property(e => e.COST).HasColumnType("NUMBER(38)");
            entity.Property(e => e.CPU_COST).HasColumnType("NUMBER(38)");
            entity.Property(e => e.DISTRIBUTION)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ID).HasColumnType("NUMBER(38)");
            entity.Property(e => e.IO_COST).HasColumnType("NUMBER(38)");
            entity.Property(e => e.OBJECT_INSTANCE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.OBJECT_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.OBJECT_NODE)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.OBJECT_OWNER)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.OBJECT_TYPE)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OPERATION)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OPTIMIZER)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OPTIONS)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OTHER).HasColumnType("LONG");
            entity.Property(e => e.OTHER_TAG)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER(38)");
            entity.Property(e => e.PARTITION_ID).HasColumnType("NUMBER(38)");
            entity.Property(e => e.PARTITION_START)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PARTITION_STOP)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.POSITION).HasColumnType("NUMBER(38)");
            entity.Property(e => e.REMARKS)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.SEARCH_COLUMNS).HasColumnType("NUMBER");
            entity.Property(e => e.STATEMENT_ID)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TEMP_SPACE).HasColumnType("NUMBER(38)");
            entity.Property(e => e.TIMESTAMP).HasColumnType("DATE");
        });

        modelBuilder.Entity<MVIEW__ADV_PRETTY>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MVIEW$_ADV_PRETTY", tb => tb.HasComment("Table for sql parsing"));

            entity.HasIndex(e => e.QUERYID_, "MVIEW$_ADV_PRETTY_IDX_01");

            entity.Property(e => e.QUERYID_)
                .HasColumnType("NUMBER")
                .HasColumnName("QUERYID#");
            entity.Property(e => e.SQL_TEXT).HasColumnType("LONG");
        });

        modelBuilder.Entity<MVIEW__ADV_ROLLUP>(entity =>
        {
            entity.HasKey(e => new { e.RUNID_, e.CLEVELID_, e.PLEVELID_ }).HasName("MVIEW$_ADV_ROLLUP_PK");

            entity.ToTable("MVIEW$_ADV_ROLLUP", tb => tb.HasComment("Each row repesents either a functional dependency or join-key relationship"));

            entity.Property(e => e.RUNID_)
                .HasColumnType("NUMBER")
                .HasColumnName("RUNID#");
            entity.Property(e => e.CLEVELID_)
                .HasColumnType("NUMBER")
                .HasColumnName("CLEVELID#");
            entity.Property(e => e.PLEVELID_)
                .HasColumnType("NUMBER")
                .HasColumnName("PLEVELID#");
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");

            entity.HasOne(d => d.RUNID_Navigation).WithMany(p => p.MVIEW__ADV_ROLLUP)
                .HasForeignKey(d => d.RUNID_)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MVIEW$_ADV_ROLLUP_FK");

            entity.HasOne(d => d.MVIEW__ADV_LEVEL).WithMany(p => p.MVIEW__ADV_ROLLUPMVIEW__ADV_LEVEL)
                .HasForeignKey(d => new { d.RUNID_, d.CLEVELID_ })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MVIEW$_ADV_ROLLUP_CFK");

            entity.HasOne(d => d.MVIEW__ADV_LEVELNavigation).WithMany(p => p.MVIEW__ADV_ROLLUPMVIEW__ADV_LEVELNavigation)
                .HasForeignKey(d => new { d.RUNID_, d.PLEVELID_ })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MVIEW$_ADV_ROLLUP_PFK");
        });

        modelBuilder.Entity<MVIEW__ADV_SQLDEPEND>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MVIEW$_ADV_SQLDEPEND", tb => tb.HasComment("Temporary table for workload collections"));

            entity.HasIndex(e => new { e.COLLECTIONID_, e.FROM_ADDRESS, e.FROM_HASH, e.INST_ID }, "MVIEW$_ADV_SQLDEPEND_IDX_01");

            entity.Property(e => e.CARDINALITY).HasColumnType("NUMBER");
            entity.Property(e => e.COLLECTIONID_)
                .HasColumnType("NUMBER")
                .HasColumnName("COLLECTIONID#");
            entity.Property(e => e.FROM_HASH).HasColumnType("NUMBER");
            entity.Property(e => e.INST_ID).HasColumnType("NUMBER");
            entity.Property(e => e.TO_NAME)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.TO_OWNER)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.TO_TYPE).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<MVIEW__ADV_TEMP>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MVIEW$_ADV_TEMP", tb => tb.HasComment("Table for temporary data"));

            entity.HasIndex(e => new { e.ID_, e.SEQ_ }, "MVIEW$_ADV_TEMP_IDX_01");

            entity.Property(e => e.ID_)
                .HasColumnType("NUMBER")
                .HasColumnName("ID#");
            entity.Property(e => e.SEQ_)
                .HasColumnType("NUMBER")
                .HasColumnName("SEQ#");
            entity.Property(e => e.TEXT).HasColumnType("LONG");
        });

        modelBuilder.Entity<MVIEW__ADV_WORKLOAD>(entity =>
        {
            entity.HasKey(e => e.QUERYID_).HasName("MVIEW$_ADV_WORKLOAD_PK");

            entity.ToTable("MVIEW$_ADV_WORKLOAD", tb => tb.HasComment("Shared workload repository for DBA users of summary advisor"));

            entity.HasIndex(e => new { e.COLLECTIONID_, e.QUERYID_ }, "MVIEW$_ADV_WORKLOAD_IDX_01");

            entity.Property(e => e.QUERYID_)
                .HasColumnType("NUMBER")
                .HasColumnName("QUERYID#");
            entity.Property(e => e.APPLICATION)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.CARDINALITY).HasColumnType("NUMBER");
            entity.Property(e => e.COLLECTIONID_)
                .HasColumnType("NUMBER")
                .HasColumnName("COLLECTIONID#");
            entity.Property(e => e.COLLECTTIME).HasColumnType("DATE");
            entity.Property(e => e.EXEC_TIME).HasColumnType("NUMBER");
            entity.Property(e => e.FREQUENCY).HasColumnType("NUMBER");
            entity.Property(e => e.PRIORITY).HasColumnType("NUMBER");
            entity.Property(e => e.QDATE).HasColumnType("DATE");
            entity.Property(e => e.RESULTSIZE).HasColumnType("NUMBER");
            entity.Property(e => e.SQL_HASH).HasColumnType("NUMBER");
            entity.Property(e => e.SQL_TEXT).HasColumnType("LONG");
            entity.Property(e => e.SQL_TEXTLEN).HasColumnType("NUMBER");
            entity.Property(e => e.UNAME)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OL_>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OL$");

            entity.HasIndex(e => e.OL_NAME, "OL$NAME").IsUnique();

            entity.HasIndex(e => new { e.SIGNATURE, e.CATEGORY }, "OL$SIGNATURE").IsUnique();

            entity.Property(e => e.CATEGORY)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.CREATOR)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.FLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.HASH_VALUE).HasColumnType("NUMBER");
            entity.Property(e => e.HASH_VALUE2).HasColumnType("NUMBER");
            entity.Property(e => e.HINTCOUNT).HasColumnType("NUMBER");
            entity.Property(e => e.OL_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.SQL_TEXT).HasColumnType("LONG");
            entity.Property(e => e.TEXTLEN).HasColumnType("NUMBER");
            entity.Property(e => e.TIMESTAMP).HasColumnType("DATE");
            entity.Property(e => e.VERSION)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OL_HINTS>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OL$HINTS");

            entity.HasIndex(e => new { e.OL_NAME, e.HINT_ }, "OL$HNT_NUM").IsUnique();

            entity.Property(e => e.BYTES).HasColumnType("FLOAT");
            entity.Property(e => e.CARDINALITY).HasColumnType("FLOAT");
            entity.Property(e => e.CATEGORY)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.COST).HasColumnType("FLOAT");
            entity.Property(e => e.HINT_)
                .HasColumnType("NUMBER")
                .HasColumnName("HINT#");
            entity.Property(e => e.HINT_STRING).HasColumnType("CLOB");
            entity.Property(e => e.HINT_TEXT)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.HINT_TEXTLEN).HasColumnType("NUMBER");
            entity.Property(e => e.HINT_TEXTOFF).HasColumnType("NUMBER");
            entity.Property(e => e.HINT_TYPE).HasColumnType("NUMBER");
            entity.Property(e => e.JOIN_PRED)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.NODE_)
                .HasColumnType("NUMBER")
                .HasColumnName("NODE#");
            entity.Property(e => e.OL_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.REF_ID).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.STAGE_)
                .HasColumnType("NUMBER")
                .HasColumnName("STAGE#");
            entity.Property(e => e.TABLE_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.TABLE_POS).HasColumnType("NUMBER");
            entity.Property(e => e.TABLE_TIN).HasColumnType("NUMBER");
            entity.Property(e => e.USER_TABLE_NAME)
                .HasMaxLength(260)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OL_NODES>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OL$NODES");

            entity.Property(e => e.CATEGORY)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.NODE_ID).HasColumnType("NUMBER");
            entity.Property(e => e.NODE_NAME)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.NODE_TEXTLEN).HasColumnType("NUMBER");
            entity.Property(e => e.NODE_TEXTOFF).HasColumnType("NUMBER");
            entity.Property(e => e.NODE_TYPE).HasColumnType("NUMBER");
            entity.Property(e => e.OL_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.PARENT_ID).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<PAYMENTS>(entity =>
        {
            entity.HasKey(e => e.PAYMENT_ID).HasName("SYS_C008354");

            entity.Property(e => e.PAYMENT_ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER");
            entity.Property(e => e.AMOUNT).HasColumnType("NUMBER(15,2)");
            entity.Property(e => e.LOAN_ID).HasColumnType("NUMBER");
            entity.Property(e => e.PAYMENT_DATE)
                .HasDefaultValueSql("SYSDATE")
                .HasColumnType("DATE");

            entity.HasOne(d => d.LOAN).WithMany(p => p.PAYMENTS)
                .HasForeignKey(d => d.LOAN_ID)
                .HasConstraintName("SYS_C008355");
        });

        modelBuilder.Entity<PRODUCT_PRIVS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PRODUCT_PRIVS");

            entity.Property(e => e.ATTRIBUTE)
                .HasMaxLength(240)
                .IsUnicode(false);
            entity.Property(e => e.CHAR_VALUE)
                .HasMaxLength(240)
                .IsUnicode(false);
            entity.Property(e => e.DATE_VALUE).HasColumnType("DATE");
            entity.Property(e => e.LONG_VALUE).HasColumnType("LONG");
            entity.Property(e => e.NUMERIC_VALUE).HasColumnType("NUMBER(15,2)");
            entity.Property(e => e.PRODUCT)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SCOPE)
                .HasMaxLength(240)
                .IsUnicode(false);
            entity.Property(e => e.USERID)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<REDO_DB>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.TENANT_KEY, e.DBID, e.THREAD_, e.RESETLOGS_SCN, e.RESETLOGS_TIME }, "REDO_DB_IDX");

            entity.Property(e => e.APPLY_DONE).HasColumnType("NUMBER");
            entity.Property(e => e.APPLY_SEQNO).HasColumnType("NUMBER");
            entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");
            entity.Property(e => e.CURBLKNO).HasColumnType("NUMBER");
            entity.Property(e => e.CURLOG).HasColumnType("NUMBER");
            entity.Property(e => e.CURSCN_TIME).HasColumnType("NUMBER");
            entity.Property(e => e.DBID).HasColumnType("NUMBER");
            entity.Property(e => e.DBUNAME)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ENDIAN).HasColumnType("NUMBER");
            entity.Property(e => e.ENQIDX).HasColumnType("NUMBER");
            entity.Property(e => e.ERROR1).HasColumnType("NUMBER");
            entity.Property(e => e.GAP_DONE).HasColumnType("NUMBER");
            entity.Property(e => e.GAP_NEXT_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.GAP_NEXT_TIME).HasColumnType("NUMBER");
            entity.Property(e => e.GAP_RET).HasColumnType("NUMBER");
            entity.Property(e => e.GAP_RET2).HasColumnType("NUMBER");
            entity.Property(e => e.GAP_SEQNO).HasColumnType("NUMBER");
            entity.Property(e => e.GLOBAL_DBNAME)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.HAS_CHILD).HasColumnType("NUMBER");
            entity.Property(e => e.PRESETLOGS_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.PRESETLOGS_SCN_BAS).HasColumnType("NUMBER");
            entity.Property(e => e.PRESETLOGS_SCN_WRP).HasColumnType("NUMBER");
            entity.Property(e => e.PRESETLOGS_TIME).HasColumnType("NUMBER");
            entity.Property(e => e.PURGE_DONE).HasColumnType("NUMBER");
            entity.Property(e => e.RESETLOGS_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.RESETLOGS_SCN_BAS).HasColumnType("NUMBER");
            entity.Property(e => e.RESETLOGS_SCN_WRP).HasColumnType("NUMBER");
            entity.Property(e => e.RESETLOGS_TIME).HasColumnType("NUMBER");
            entity.Property(e => e.SEQNO_DONE_CUR).HasColumnType("NUMBER");
            entity.Property(e => e.SEQNO_DONE_HI).HasColumnType("NUMBER");
            entity.Property(e => e.SEQNO_DONE_LO).HasColumnType("NUMBER");
            entity.Property(e => e.SEQNO_RCV_CUR).HasColumnType("NUMBER");
            entity.Property(e => e.SEQNO_RCV_HI).HasColumnType("NUMBER");
            entity.Property(e => e.SEQNO_RCV_LO).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE10).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE11).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE12).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE4).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE5).HasColumnType("DATE");
            entity.Property(e => e.SPARE6)
                .HasMaxLength(65)
                .IsUnicode(false);
            entity.Property(e => e.SPARE7)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.SPARE8).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE9).HasColumnType("NUMBER");
            entity.Property(e => e.STATUS).HasColumnType("NUMBER");
            entity.Property(e => e.TENANT_KEY).HasColumnType("NUMBER");
            entity.Property(e => e.THREAD_)
                .HasColumnType("NUMBER")
                .HasColumnName("THREAD#");
            entity.Property(e => e.TS1).HasColumnType("NUMBER");
            entity.Property(e => e.TS2).HasColumnType("NUMBER");
            entity.Property(e => e.TS3).HasColumnType("NUMBER");
            entity.Property(e => e.VERSION)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<REDO_LOG>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.TENANT_KEY, e.DBID, e.THREAD_, e.RESETLOGS_SCN, e.RESETLOGS_TIME }, "REDO_LOG_IDX");

            entity.Property(e => e.BLOCKS).HasColumnType("NUMBER");
            entity.Property(e => e.BLOCK_SIZE).HasColumnType("NUMBER");
            entity.Property(e => e.CLOSE_TIME)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.CREATE_DATE).HasColumnType("DATE");
            entity.Property(e => e.CREATE_TIME)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.DBID).HasColumnType("NUMBER");
            entity.Property(e => e.DBUNAME)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.DONE_TIME)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.DUPID).HasColumnType("NUMBER");
            entity.Property(e => e.ENDIAN).HasColumnType("NUMBER");
            entity.Property(e => e.ERROR1).HasColumnType("NUMBER");
            entity.Property(e => e.ERROR2).HasColumnType("NUMBER");
            entity.Property(e => e.FILENAME)
                .HasMaxLength(513)
                .IsUnicode(false);
            entity.Property(e => e.FIRST_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.FIRST_SCN_BAS).HasColumnType("NUMBER");
            entity.Property(e => e.FIRST_SCN_WRP).HasColumnType("NUMBER");
            entity.Property(e => e.FIRST_TIME).HasColumnType("NUMBER");
            entity.Property(e => e.GLOBAL_DBNAME)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.NEXT_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.NEXT_SCN_BAS).HasColumnType("NUMBER");
            entity.Property(e => e.NEXT_SCN_WRP).HasColumnType("NUMBER");
            entity.Property(e => e.NEXT_TIME).HasColumnType("NUMBER");
            entity.Property(e => e.OLD_BLOCKS).HasColumnType("NUMBER");
            entity.Property(e => e.OLD_FILENAME)
                .HasMaxLength(513)
                .IsUnicode(false);
            entity.Property(e => e.OLD_STATUS1).HasColumnType("NUMBER");
            entity.Property(e => e.OLD_STATUS2).HasColumnType("NUMBER");
            entity.Property(e => e.PRESETLOGS_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.PRESETLOGS_SCN_BAS).HasColumnType("NUMBER");
            entity.Property(e => e.PRESETLOGS_SCN_WRP).HasColumnType("NUMBER");
            entity.Property(e => e.PRESETLOGS_TIME).HasColumnType("NUMBER");
            entity.Property(e => e.RESETLOGS_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.RESETLOGS_SCN_BAS).HasColumnType("NUMBER");
            entity.Property(e => e.RESETLOGS_SCN_WRP).HasColumnType("NUMBER");
            entity.Property(e => e.RESETLOGS_TIME).HasColumnType("NUMBER");
            entity.Property(e => e.SEQUENCE_)
                .HasColumnType("NUMBER")
                .HasColumnName("SEQUENCE#");
            entity.Property(e => e.SPARE10).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE4).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE5).HasColumnType("DATE");
            entity.Property(e => e.SPARE6)
                .HasMaxLength(65)
                .IsUnicode(false);
            entity.Property(e => e.SPARE7)
                .HasMaxLength(129)
                .IsUnicode(false);
            entity.Property(e => e.SPARE8).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE9).HasColumnType("NUMBER");
            entity.Property(e => e.STATUS1).HasColumnType("NUMBER");
            entity.Property(e => e.STATUS2).HasColumnType("NUMBER");
            entity.Property(e => e.TENANT_KEY).HasColumnType("NUMBER");
            entity.Property(e => e.THREAD_)
                .HasColumnType("NUMBER")
                .HasColumnName("THREAD#");
            entity.Property(e => e.TS1).HasColumnType("NUMBER");
            entity.Property(e => e.TS2).HasColumnType("NUMBER");
            entity.Property(e => e.TS3).HasColumnType("NUMBER");
            entity.Property(e => e.VERSION)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<REPL_SUPPORT_MATRIX>(entity =>
        {
            entity.HasKey(e => new { e.BMAP1, e.BMAP2, e.REPL_PRODUCT, e.SUPPORT_MODE }).HasName("REPL_SUPPORT_MATRIX_PK");

            entity.Property(e => e.BMAP1).HasColumnType("NUMBER");
            entity.Property(e => e.BMAP2).HasColumnType("NUMBER");
            entity.Property(e => e.REPL_PRODUCT).HasColumnType("NUMBER");
            entity.Property(e => e.SUPPORT_MODE).HasColumnType("NUMBER");
            entity.Property(e => e.FEATURE_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MAX_COMPAT).HasColumnType("NUMBER");
            entity.Property(e => e.MIN_COMPAT).HasColumnType("NUMBER");
            entity.Property(e => e.REASON_CODE).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<REPL_VALID_COMPAT>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.COMPAT).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<ROLLING_CONNECTIONS>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ROLLING$CONNECTIONS");

            entity.Property(e => e.ATTRIBUTES).HasColumnType("NUMBER");
            entity.Property(e => e.CONNECT_TIME).HasPrecision(6);
            entity.Property(e => e.CONN_HANDLE).HasColumnType("NUMBER");
            entity.Property(e => e.DEST_PID).HasColumnType("NUMBER");
            entity.Property(e => e.DEST_RDBID).HasColumnType("NUMBER");
            entity.Property(e => e.DISCONNECT_TIME).HasPrecision(6);
            entity.Property(e => e.SEND_TIME).HasPrecision(6);
            entity.Property(e => e.SERVICE_NAME)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SOURCE_PID).HasColumnType("NUMBER");
            entity.Property(e => e.SOURCE_RDBID).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.UPDATE_TIME).HasPrecision(6);
        });

        modelBuilder.Entity<ROLLING_DATABASES>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ROLLING$DATABASES");

            entity.Property(e => e.ATTRIBUTES).HasColumnType("NUMBER");
            entity.Property(e => e.ATTRIBUTES2).HasColumnType("NUMBER");
            entity.Property(e => e.CONS_RID).HasColumnType("NUMBER");
            entity.Property(e => e.CONS_RSCN).HasColumnType("NUMBER");
            entity.Property(e => e.CONS_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.DBID).HasColumnType("NUMBER");
            entity.Property(e => e.DBUN)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ENGINE_STATUS).HasColumnType("NUMBER");
            entity.Property(e => e.PROD_RID).HasColumnType("NUMBER");
            entity.Property(e => e.PROD_RSCN).HasColumnType("NUMBER");
            entity.Property(e => e.PROD_SCN).HasColumnType("NUMBER");
            entity.Property(e => e.RDBID).HasColumnType("NUMBER");
            entity.Property(e => e.REDO_SOURCE).HasColumnType("NUMBER");
            entity.Property(e => e.REVISION).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.UPDATE_TIME).HasPrecision(6);
            entity.Property(e => e.VERSION)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ROLLING_DIRECTIVES>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ROLLING$DIRECTIVES");

            entity.Property(e => e.DESCRIPTION)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.DIRECTID).HasColumnType("NUMBER");
            entity.Property(e => e.FEATURE)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.FLAGS)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.OPCODE).HasColumnType("NUMBER");
            entity.Property(e => e.P1)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.P2)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.P3)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.PHASE).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.TARGET).HasColumnType("NUMBER");
            entity.Property(e => e.TASKID).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<ROLLING_EVENTS>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ROLLING$EVENTS");

            entity.Property(e => e.EVENTID).HasColumnType("NUMBER");
            entity.Property(e => e.EVENT_TIME).HasPrecision(6);
            entity.Property(e => e.INSTID).HasColumnType("NUMBER");
            entity.Property(e => e.MESSAGE)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.REVISION).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.STATUS).HasColumnType("NUMBER");
            entity.Property(e => e.TYPE)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ROLLING_PARAMETERS>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ROLLING$PARAMETERS");

            entity.Property(e => e.ATTRIBUTES).HasColumnType("NUMBER");
            entity.Property(e => e.CURVAL)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.DATATYPE).HasColumnType("NUMBER");
            entity.Property(e => e.DEFVAL)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.DESCRIP)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.ID).HasColumnType("NUMBER");
            entity.Property(e => e.LSTVAL)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.MAXVAL).HasColumnType("NUMBER");
            entity.Property(e => e.MINVAL).HasColumnType("NUMBER");
            entity.Property(e => e.NAME)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.SCOPE).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.TYPE).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<ROLLING_PLAN>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ROLLING$PLAN");

            entity.Property(e => e.BATCHID).HasColumnType("NUMBER");
            entity.Property(e => e.DESCRIPTION)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.DIRECTID).HasColumnType("NUMBER");
            entity.Property(e => e.EXEC_INFO)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.EXEC_STATUS).HasColumnType("NUMBER");
            entity.Property(e => e.EXEC_TIME).HasPrecision(6);
            entity.Property(e => e.FINISH_TIME).HasPrecision(6);
            entity.Property(e => e.INSTID).HasColumnType("NUMBER");
            entity.Property(e => e.OPCODE).HasColumnType("NUMBER");
            entity.Property(e => e.P1)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.P2)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.P3)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.P4)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.PHASE).HasColumnType("NUMBER");
            entity.Property(e => e.POST_STATUS).HasColumnType("NUMBER");
            entity.Property(e => e.PROGRESS).HasColumnType("NUMBER");
            entity.Property(e => e.REVISION).HasColumnType("NUMBER");
            entity.Property(e => e.RFLAGS).HasColumnType("NUMBER");
            entity.Property(e => e.SOURCE).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.STATUS).HasColumnType("NUMBER");
            entity.Property(e => e.TARGET).HasColumnType("NUMBER");
            entity.Property(e => e.TASKID).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<ROLLING_STATISTICS>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ROLLING$STATISTICS");

            entity.Property(e => e.ATTRIBUTES).HasColumnType("NUMBER");
            entity.Property(e => e.NAME)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.RDBID).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.STATID).HasColumnType("NUMBER");
            entity.Property(e => e.TYPE).HasColumnType("NUMBER");
            entity.Property(e => e.UPDATE_TIME).HasPrecision(6);
            entity.Property(e => e.VALUEINT).HasColumnType("INTERVAL DAY(3) TO SECOND(2)");
            entity.Property(e => e.VALUENUM).HasColumnType("NUMBER");
            entity.Property(e => e.VALUESTR)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.VALUETS).HasPrecision(6);
        });

        modelBuilder.Entity<ROLLING_STATUS>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ROLLING$STATUS");

            entity.Property(e => e.BATCHID).HasColumnType("NUMBER");
            entity.Property(e => e.BUILD_TIME).HasPrecision(6);
            entity.Property(e => e.COORDID).HasColumnType("NUMBER");
            entity.Property(e => e.DBACTIVE).HasColumnType("NUMBER");
            entity.Property(e => e.DBTOTAL).HasColumnType("NUMBER");
            entity.Property(e => e.FINISH_TIME).HasPrecision(6);
            entity.Property(e => e.FPRIMARY).HasColumnType("NUMBER");
            entity.Property(e => e.INIT_TIME).HasPrecision(6);
            entity.Property(e => e.INSTANCE).HasColumnType("NUMBER");
            entity.Property(e => e.LAST_BATCHID).HasColumnType("NUMBER");
            entity.Property(e => e.LAST_INSTID).HasColumnType("NUMBER");
            entity.Property(e => e.LOCATION)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.OPRIMARY).HasColumnType("NUMBER");
            entity.Property(e => e.PHASE).HasColumnType("NUMBER");
            entity.Property(e => e.PID).HasColumnType("NUMBER");
            entity.Property(e => e.REVISION).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE1).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE2).HasColumnType("NUMBER");
            entity.Property(e => e.SPARE3)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.START_TIME).HasPrecision(6);
            entity.Property(e => e.STATUS).HasColumnType("NUMBER");
            entity.Property(e => e.SWITCH_TIME).HasPrecision(6);
        });

        modelBuilder.Entity<SCHEDULER_JOB_ARGS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SCHEDULER_JOB_ARGS");

            entity.Property(e => e.ARGUMENT_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ARGUMENT_POSITION).HasColumnType("NUMBER");
            entity.Property(e => e.ARGUMENT_TYPE)
                .HasMaxLength(257)
                .IsUnicode(false);
            entity.Property(e => e.JOB_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.OUT_ARGUMENT)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OWNER)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.VALUE).IsUnicode(false);
        });

        modelBuilder.Entity<SCHEDULER_JOB_ARGS_TBL>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ARGUMENT_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ARGUMENT_POSITION).HasColumnType("NUMBER");
            entity.Property(e => e.ARGUMENT_TYPE)
                .HasMaxLength(257)
                .IsUnicode(false);
            entity.Property(e => e.JOB_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.OUT_ARGUMENT)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OWNER)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.VALUE).IsUnicode(false);
        });

        modelBuilder.Entity<SCHEDULER_PROGRAM_ARGS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SCHEDULER_PROGRAM_ARGS");

            entity.Property(e => e.ARGUMENT_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ARGUMENT_POSITION).HasColumnType("NUMBER");
            entity.Property(e => e.ARGUMENT_TYPE)
                .HasMaxLength(257)
                .IsUnicode(false);
            entity.Property(e => e.DEFAULT_VALUE).IsUnicode(false);
            entity.Property(e => e.METADATA_ATTRIBUTE)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.OUT_ARGUMENT)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OWNER)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.PROGRAM_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SCHEDULER_PROGRAM_ARGS_TBL>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ARGUMENT_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ARGUMENT_POSITION).HasColumnType("NUMBER");
            entity.Property(e => e.ARGUMENT_TYPE)
                .HasMaxLength(257)
                .IsUnicode(false);
            entity.Property(e => e.DEFAULT_VALUE).IsUnicode(false);
            entity.Property(e => e.METADATA_ATTRIBUTE)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.OUT_ARGUMENT)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OWNER)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.PROGRAM_NAME)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SQLPLUS_PRODUCT_PROFILE>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ATTRIBUTE)
                .HasMaxLength(240)
                .IsUnicode(false);
            entity.Property(e => e.CHAR_VALUE)
                .HasMaxLength(240)
                .IsUnicode(false);
            entity.Property(e => e.DATE_VALUE).HasColumnType("DATE");
            entity.Property(e => e.LONG_VALUE).HasColumnType("LONG");
            entity.Property(e => e.NUMERIC_VALUE).HasColumnType("NUMBER(15,2)");
            entity.Property(e => e.PRODUCT)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SCOPE)
                .HasMaxLength(240)
                .IsUnicode(false);
            entity.Property(e => e.USERID)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TRANSACTIONS>(entity =>
        {
            entity.HasKey(e => e.TRANSACTION_ID).HasName("SYS_C008339");

            entity.HasIndex(e => e.TRANSACTION_DATE, "IDX_TRANSACTION_DATE");

            entity.Property(e => e.TRANSACTION_ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER");
            entity.Property(e => e.ACCOUNT_ID).HasColumnType("NUMBER");
            entity.Property(e => e.AMOUNT).HasColumnType("NUMBER(15,2)");
            entity.Property(e => e.TRANSACTION_DATE)
                .HasDefaultValueSql("SYSDATE")
                .HasColumnType("DATE");
            entity.Property(e => e.TRANSACTION_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.ACCOUNT).WithMany(p => p.TRANSACTIONS)
                .HasForeignKey(d => d.ACCOUNT_ID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C008340");
        });

        modelBuilder.Entity<VW_BRANCH_SUMMARY>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_BRANCH_SUMMARY");

            entity.Property(e => e.BRANCH_ID).HasColumnType("NUMBER");
            entity.Property(e => e.TOTAL_ACCOUNTS).HasColumnType("NUMBER");
        });

        modelBuilder.Entity<VW_CUSTOMER_ACCOUNTS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_CUSTOMER_ACCOUNTS");

            entity.Property(e => e.ACCOUNT_ID)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER");
            entity.Property(e => e.BALANCE).HasColumnType("NUMBER(15,2)");
            entity.Property(e => e.FIRST_NAME)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LAST_NAME)
                .HasMaxLength(50)
                .IsUnicode(false);
        });
        modelBuilder.HasSequence("LOGMNR_DIDS$");
        modelBuilder.HasSequence("LOGMNR_EVOLVE_SEQ$");
        modelBuilder.HasSequence("LOGMNR_SEQ$");
        modelBuilder.HasSequence("LOGMNR_UIDS$").IsCyclic();
        modelBuilder.HasSequence("MVIEW$_ADVSEQ_GENERIC");
        modelBuilder.HasSequence("MVIEW$_ADVSEQ_ID");
        modelBuilder.HasSequence("ROLLING_EVENT_SEQ$");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
