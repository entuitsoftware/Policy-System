using DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Policy
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime StartDate { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public string ConsultantId { get; set; }
        public ApplicationUser Consultant { get; set; }
        public PolicyStatus Status { get; set; }

        public int BillingDay { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
