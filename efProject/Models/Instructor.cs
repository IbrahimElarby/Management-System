using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efProject.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string? LName { get; set; }
        [StringLength(255)]
        public string? FName { get; set; }
        [StringLength(255)]
        public string? Phone { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();

        public virtual ICollection<CouresSession> CouresSessions { get; set; } = new HashSet< CouresSession>();
        public virtual Department? Department { get; set; }

        
    }

}
