// =============================
// Email: info@ebenmonney.com
// www.ebenmonney.com/templates
// =============================

using System;
using System.ComponentModel;

namespace DAL.Core
{
    public enum Gender
    {
        None,
        Female,
        Male
    }

    public enum PolicyStatus
    {
        Pending,
        Active,
        Suspended,
        Cancelled
    }

    public enum PaymentStatus
    {
        Pending,
        Paid,
        Failed
    }

    public enum PaymentMethod
    {
        [Description("Cash")]
        Cash,
        [Description("Debit Order")]
        DebitOrder,
        [Description("Debit/Credit Card")]
        OnlineCard,
        [Description("EFT")]
        Eft,
        [Description("Card Machine")]
        Speedpoint
    }

    public enum BankingDetailVerificationStatus
    {
        Pending, 
        Valid,
        Invalid
    }

    public enum AccountType
    {
        Savings,
        Cheque,
        Business
    }

}
