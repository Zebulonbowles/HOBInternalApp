using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class CrudeBatch
    {
        [Required]
        public int Id { get; set; }
        public string JulianId { get; set; }
        public int BiomassExtractionId { get; set; }
        public string CoaURL { get; set; }
        public bool IsDecarboxylated { get; set; }
        public bool IsWinterized { get; set; }
        public bool IsTested { get; set; }
        public bool IsCarbonScrubbed { get; set; }
        public bool IsHotScrubbed { get; set; }
        public string Qr { get; set; }

        [ForeignKey("BiomassExtractionId")]
        public BiomassExtraction ExtractionBatchSource { get; set; }
    }
}
