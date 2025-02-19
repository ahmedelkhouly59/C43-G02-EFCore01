using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_1.Models
{
    [Table("Department")]
    internal class Department
    {
        [Key]
        [Column("DepartmentID")]
        public int ID { get; set; }
        [Required]
        [Column("DepartmentName", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        public int Ins_ID { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime HiringDate { get; set; }
    }
}
