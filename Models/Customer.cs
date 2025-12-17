using System;
using System.Collections.Generic;

namespace BankingWebApp.BankingModels;

public partial class Customer
{
    public decimal CustomerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public DateTime? Dob { get; set; }

    public string? Gender { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<Card> Cards { get; set; } = new List<Card>();

    public virtual ICollection<CustomerContact> CustomerContacts { get; set; } = new List<CustomerContact>();

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
