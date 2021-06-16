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
        public string FarmAddress { get; set; }
        public string FarmCity { get; set; }
        public int FarmZip { get; set; }
        public string FarmContactPersonFirstName { get; set; }
        public string FarmContactPhone { get; set; }
        public int ContactPersonId { get; set; }
    }
}
