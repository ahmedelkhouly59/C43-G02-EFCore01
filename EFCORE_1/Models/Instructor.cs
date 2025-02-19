using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_1.Models
{
    [Table("Instructor")]
    internal class Instructor
    {
        [Key]
        public int ID { get; set; }
        [Column("InstructorName",TypeName ="varchar")]
        [StringLength(30,MinimumLength =3)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Bonus { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Range(2,20)]
        public decimal HourRate { get; set; }
        public int Dept_ID { get; set; }
    }
}
