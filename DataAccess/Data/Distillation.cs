using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Distillation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Id")]
        public Employee Employee { get; set; }
        [Required]
        [ForeignKey("Id")]
        public CrudeBatch CrudeBatch { get; set; }
        public DateTime DateTime { get; set; }
        public int CrudeInputWeight { get; set; }
        public int OutpoutMains { get; set; }
        public int OutputHeadsTails { get; set; }
    }
}
