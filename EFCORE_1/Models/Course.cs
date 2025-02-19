using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_1.Models
{
    [Table("Course")]
    internal class Course
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Range(1,3)]
        public int Duration { get; set; }
        [Required]
        [Column("CourseName",TypeName ="varchar")]
        [StringLength(50,MinimumLength =3)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Top_ID { get; set; }
    }
}
