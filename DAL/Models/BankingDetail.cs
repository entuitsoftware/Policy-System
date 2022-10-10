using DAL.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class BankingDetail
    {
        public Guid Id { get; set; }
        public string AccountNumber { get; set; }
        public string Bank { get; set; }
        public string BranchCode { get; set; }
        public AccountType AccountType { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
