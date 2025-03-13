using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efProject.Models
{
    public class CourseSessionAttandance
    {
        [Key]
        public int Id { get; set; }

        public int? Grade { get; set; }
        
        public string? Notes { get; set; }
        [ForeignKey("CouresSession")]
        public int ? CourseSessionID { get; set; }
        [ForeignKey("Student")]
        public int? StudentID { get; set; }

        public virtual CouresSession? CouresSession { get; set; }

        public virtual Student? Student { get; set; }
    }
}
