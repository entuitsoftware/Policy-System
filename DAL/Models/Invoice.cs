using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Core;

namespace DAL.Models
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }

        public PaymentStatus Status { get; set; }
        public Guid PolicyId { get;set; }
        public Policy Policy { get; set; }

        public int Amount { get; set; }
    }
}
