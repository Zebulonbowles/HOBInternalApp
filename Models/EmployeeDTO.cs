using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EmployeeDTO
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public PersonDTO EmployeePersonalInfo { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public DateTime DateHired { get; set; }
    }
}
