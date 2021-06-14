using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class BiomassExtraction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public BiomassBatch BiomassBatchUsed { get; set; }
        [Required]
        public int WeightIn { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public List<Employee> Employees { get; set; }


    }
}
