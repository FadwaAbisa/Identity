using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class Specialties /*جدول التخصصات*/
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SP_ID { get; set; }
        public string? SP_Name { get; set; }

    }
}
