using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Address1 { get; set; }
        [StringLength(60)]
        public string Address2 { get; set; }
        [StringLength(60)]
        public string City { get; set; }
        [StringLength(60)]
        public string State { get; set; }
        [Required]
        [StringLength(10)]
        public int Zip { get; set; }
        [StringLength(2)]
        public string Country { get; set; }

    }
}
