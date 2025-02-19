using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_1.Models
{
    [Table("Course_Instructor")]
    internal class Course_Inst
    {
        [Required]
        public int Inst_ID { get; set; }
        [Required]
        public int Course_ID { get; set; }
        [Required]
        [Column("Evaluation", TypeName = "varchar")]
        [StringLength(20, MinimumLength = 3)]
        public string Evaluate { get; set; }
    }
}
