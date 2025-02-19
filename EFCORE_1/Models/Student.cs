using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_1.Models
{
    [Table("Student")]
    internal class Student
    {
        [Key]
        public int ID { get; set; }
        [Column("FirstName",TypeName ="varchar")]
        [Required]
        [StringLength(30, MinimumLength = 3)]

        public string FName { get; set; }
        [Column("LastName", TypeName = "varchar")]
        [Required]
        [StringLength(30,MinimumLength =3)]
        public string LName { get; set; }
        public string Address { get; set; }
        [Range(10, 20)]
        public int Age { get; set; }
        public int Dep_Id { get; set; }
    }
}
