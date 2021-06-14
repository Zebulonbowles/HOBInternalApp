using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class BiomassBatch
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Strain { get; set; }
        public int Weight { get; set; } 
        public bool IsMilled { get; set; }
        public double MoistureContent { get; set; }
        [Required]
        [ForeignKey ("Id")]
        public Farmer FarmerInfo { get; set; }
        
    }
}
