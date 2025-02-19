using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_1.Models
{
    [Table("Student_Course")]

    internal class Stud_Course
    {
        [Required]

        public int Stud_ID { get; set; }
        [Required]

        public int Course_ID { get; set; }
        [Required]
        [Column("Grade", TypeName = "varchar")]
        [StringLength(20, MinimumLength = 3)]
        public string Grade { get; set; }
    }
}
