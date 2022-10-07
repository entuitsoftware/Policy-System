using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Lead
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public string PhoneNumber { get; set; }
        public string ConsultantId { get; set; }
        public ApplicationUser Consultant { get; set; }
        public string Source { get; set; }
    }
}
