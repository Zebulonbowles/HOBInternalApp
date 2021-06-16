using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public int PersonalInfoId { get; set; }

        [Required]
        [ForeignKey("PersonalInfoId")]
        public Person EmployeePersonalInfo { get; set; }

        [Required]
        public string JobTitle { get; set; }

        [Required]
        public DateTime DateHired { get; set; }

        public DateTime UpdatedOn { get; set; }

        public virtual List<Distillation> EmployeeDistillations {get; set;}

        public virtual List<BiomassExtraction> EmployeeExtractions { get; set; }
       


    }
}
