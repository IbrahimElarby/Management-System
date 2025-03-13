using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efProject.Models
{
    public class CouresSession
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string? Title { get; set; }
        [ForeignKey("Course")]
        public int? CourseId { get; set; }

        [ForeignKey("Instructor")]
        public int? InstructorID { get; set; }

        public virtual Course? Course { get; set; }

        public virtual Instructor? Instructor { get; set; }


        public virtual ICollection<CourseSessionAttandance> CourseSessionAttandances { get; set; } = new HashSet<CourseSessionAttandance>();
    }
}
