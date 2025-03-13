using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efProject.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string? FName { get; set; }
        [StringLength(255)]
        public string? LName { get; set; }
        [StringLength(255)]
        public string? Phone { get; set; }
        public virtual ICollection<CourseStudent> courseStudents { get; set; } = new HashSet<CourseStudent>();
        public virtual ICollection<CourseSessionAttandance>  CourseSessionAttandances { get; set; } = new HashSet<CourseSessionAttandance>();
    }
}
