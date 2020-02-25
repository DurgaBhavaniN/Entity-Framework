using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFDAL.Models
{
    [Table("Project")]
   public  class Project
    {
        [Key]
        public int ProjectID { get; set; }
        [Required]//set not null
        [StringLength(30)]
        public string ProjectName { get; set; }
        [Column(TypeName ="Date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? EndDate { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
