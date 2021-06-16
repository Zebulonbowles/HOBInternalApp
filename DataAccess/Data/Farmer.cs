using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Farmer
    {
        public int Id { get; set; }
        public string FarmName { get; set; }
        public string FarmPhone { get; set; }
        public int FarmAddressId { get; set; }
        public int ContactPersonId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        [ForeignKey("FarmAddressId")]
        public virtual Address FarmAddress { get; set; }

        [ForeignKey("FarmContactPersonId")]
        public virtual Person ContactPerson { get; set; }
    }
}
