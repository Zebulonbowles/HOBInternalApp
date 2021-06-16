using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class DistillateBatch
    {
        [Key]
        public int Id { get; set; }
        public string JulianBatchId { get; set; }
        public int SourceDistillationId { get; set; } 
        public bool IsDegummed { get; set; }
        public string Qr { get; set; }

        [ForeignKey("SourceDistillationId")]
        public Distillation SourceDistillation { get; set; }
        public bool IsTested { get; set; }
       
    }
}
