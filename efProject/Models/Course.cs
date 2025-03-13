using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efProject.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public int? Duration { get; set; }
        [MaxLength(30)]
        public string? Name { get; set; }
        [ForeignKey("Instructor")]
        public int? InstructorId { get; set; }
        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }

        public virtual Instructor? Instructor { get; set; }

        public virtual Department? Department { get; set; }
        public virtual ICollection<CouresSession> CouresSessions { get; set; } = new HashSet<CouresSession>();

        public virtual ICollection<CourseStudent> courseStudents { get; set; } = new HashSet<CourseStudent>();
    }
}
