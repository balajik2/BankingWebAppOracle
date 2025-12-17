using System;
using System.Collections.Generic;
using BankingWebApp.BankingModels;
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

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Card> Cards { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerContact> CustomerContacts { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Loan> Loans { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("BANKINGSCHEMA")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("SYS_C008285");

            entity.ToTable("ACCOUNTS");

            entity.Property(e => e.AccountId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.AccountType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_TYPE");
            entity.Property(e => e.Balance)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER(15,2)")
                .HasColumnName("BALANCE");
            entity.Property(e => e.BranchId)
                .HasColumnType("NUMBER")
                .HasColumnName("BRANCH_ID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("SYSDATE")
                .HasColumnType("DATE")
                .HasColumnName("CREATED_AT");
            entity.Property(e => e.CustomerId)
                .HasColumnType("NUMBER")
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'ACTIVE'")
                .HasColumnName("STATUS");

            entity.HasOne(d => d.Branch).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C008287");

            entity.HasOne(d => d.Customer).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C008286");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("SYS_C008310");

            entity.ToTable("AUDIT_LOGS");

            entity.Property(e => e.LogId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("LOG_ID");
            entity.Property(e => e.Action)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.ActionDate)
                .HasDefaultValueSql("SYSDATE")
                .HasColumnType("DATE")
                .HasColumnName("ACTION_DATE");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.BranchId).HasName("SYS_C008275");

            entity.ToTable("BRANCHES");

            entity.Property(e => e.BranchId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("BRANCH_ID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BRANCH_NAME");
            entity.Property(e => e.Location)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.ManagerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MANAGER_NAME");
        });

        modelBuilder.Entity<Card>(entity =>
        {
            entity.HasKey(e => e.CardId).HasName("SYS_C008303");

            entity.ToTable("CARDS");

            entity.HasIndex(e => e.CardNumber, "SYS_C008304").IsUnique();

            entity.Property(e => e.CardId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("CARD_ID");
            entity.Property(e => e.CardNumber)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CARD_NUMBER");
            entity.Property(e => e.CardType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_TYPE");
            entity.Property(e => e.CustomerId)
                .HasColumnType("NUMBER")
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("DATE")
                .HasColumnName("EXPIRY_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.Customer).WithMany(p => p.Cards)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C008305");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("SYS_C008270");

            entity.ToTable("CUSTOMERS");

            entity.HasIndex(e => e.Email, "SYS_C008271").IsUnique();

            entity.Property(e => e.CustomerId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("SYSDATE\n")
                .HasColumnType("DATE")
                .HasColumnName("CREATED_AT");
            entity.Property(e => e.Dob)
                .HasColumnType("DATE")
                .HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GENDER");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PHONE");
        });

        modelBuilder.Entity<CustomerContact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("SYS_C008312");

            entity.ToTable("CUSTOMER_CONTACTS");

            entity.Property(e => e.ContactId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("CONTACT_ID");
            entity.Property(e => e.ContactType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CONTACT_TYPE");
            entity.Property(e => e.ContactValue)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONTACT_VALUE");
            entity.Property(e => e.CustomerId)
                .HasColumnType("NUMBER")
                .HasColumnName("CUSTOMER_ID");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerContacts)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("SYS_C008313");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("SYS_C008279");

            entity.ToTable("EMPLOYEES");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("EMPLOYEE_ID");
            entity.Property(e => e.BranchId)
                .HasColumnType("NUMBER")
                .HasColumnName("BRANCH_ID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POSITION");
            entity.Property(e => e.Salary)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("SALARY");

            entity.HasOne(d => d.Branch).WithMany(p => p.Employees)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("SYS_C008280");
        });

        modelBuilder.Entity<Loan>(entity =>
        {
            entity.HasKey(e => e.LoanId).HasName("SYS_C008297");

            entity.ToTable("LOANS");

            entity.Property(e => e.LoanId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("LOAN_ID");
            entity.Property(e => e.BranchId)
                .HasColumnType("NUMBER")
                .HasColumnName("BRANCH_ID");
            entity.Property(e => e.CustomerId)
                .HasColumnType("NUMBER")
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.EndDate)
                .HasColumnType("DATE")
                .HasColumnName("END_DATE");
            entity.Property(e => e.InterestRate)
                .HasColumnType("NUMBER(5,2)")
                .HasColumnName("INTEREST_RATE");
            entity.Property(e => e.LoanAmount)
                .HasColumnType("NUMBER(15,2)")
                .HasColumnName("LOAN_AMOUNT");
            entity.Property(e => e.StartDate)
                .HasColumnType("DATE")
                .HasColumnName("START_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.Branch).WithMany(p => p.Loans)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C008299");

            entity.HasOne(d => d.Customer).WithMany(p => p.Loans)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C008298");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("SYS_C008307");

            entity.ToTable("PAYMENTS");

            entity.Property(e => e.PaymentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("PAYMENT_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("NUMBER(15,2)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.LoanId)
                .HasColumnType("NUMBER")
                .HasColumnName("LOAN_ID");
            entity.Property(e => e.PaymentDate)
                .HasDefaultValueSql("SYSDATE")
                .HasColumnType("DATE")
                .HasColumnName("PAYMENT_DATE");

            entity.HasOne(d => d.Loan).WithMany(p => p.Payments)
                .HasForeignKey(d => d.LoanId)
                .HasConstraintName("SYS_C008308");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("SYS_C008292");

            entity.ToTable("TRANSACTIONS");

            entity.Property(e => e.TransactionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.AccountId)
                .HasColumnType("NUMBER")
                .HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount)
                .HasColumnType("NUMBER(15,2)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.TransactionDate)
                .HasDefaultValueSql("SYSDATE")
                .HasColumnType("DATE")
                .HasColumnName("TRANSACTION_DATE");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TRANSACTION_TYPE");

            entity.HasOne(d => d.Account).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C008293");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
