using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_1.Models
{
    [Table("Topic")]
    internal class Topic
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column("TopicName",TypeName ="varchar")]
        [StringLength(50,MinimumLength =3)]
        public string Name { get; set; }
    }
}
