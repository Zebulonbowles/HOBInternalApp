using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Supplier
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public Address CompanyAddress { get; set; }
        public string Phone { get; set; }
        public string WebsiteUrl { get; set; }
        public string AccountNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Description { get; set; }

    }
}
