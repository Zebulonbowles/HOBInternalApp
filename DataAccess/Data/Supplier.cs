using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public int CompanyAddressId { get; set; }
        public string Phone { get; set; }
        public string WebsiteUrl { get; set; }
        public string AccountNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Description { get; set; }
        [ForeignKey("CompanyAddressId")]
        public Address CompanyAddress { get; set; }

    }
}
