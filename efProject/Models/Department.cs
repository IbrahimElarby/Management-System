using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efProject.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string? Location { get; set; }
      
        public int? MangerId { get; set; }

        public virtual Instructor? Instructor { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        public virtual ICollection<Course> courses   { get; set;} = new HashSet<Course>();
    }
}
