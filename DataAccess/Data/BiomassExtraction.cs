using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int BiomassBatchId { get; set; }

        [Required]
        public int WeightIn { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [ForeignKey("BiomassBatchId")]
        public virtual BiomassBatch BiomassBatchUsed { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }



    }
}
