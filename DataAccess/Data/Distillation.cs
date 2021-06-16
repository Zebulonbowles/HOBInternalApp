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

        public int EmployeeId { get; set; }

        public int CrudeBatchId { get; set; }

        public DateTime DateTimeStart { get; set; }

        public DateTime DateTimeEnd { get; set; }

        public int CrudeInputWeight { get; set; }

        public int OutpoutMains { get; set; }

        public int OutputHeadsTails { get; set; }

        [Required]
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [Required]
        [ForeignKey("CrudeBatchId")]
        public virtual CrudeBatch CrudeBatch { get; set; }
    }
}
