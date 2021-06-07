using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FarmerDTO
    {
        public int Id { get; set; }
        public string FarmName { get; set; }
        public Address FarmAddress { get; set; }

        [ForeignKey("Id")]
        public Person ContactPerson { get; set; }
    }
}
