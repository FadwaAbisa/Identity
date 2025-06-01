using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identity.Models
{
    public class Curriculums /*جدول المناهج الدراسية*/
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cur_ID { get; set; }
        public string Cur_Name { get; set; }
        public string? Cur_Image { get; set; }
        [NotMapped]
        public IFormFile clientFile { get; set; }

        public DateTime Cur_Date { get; set; }

        [ValidateNever]
        public Specialties Specialties { get; set; } // علاقة بين جدول التخصصات

        [ForeignKey("Specialties")]
        public int SpecialtiesID { get; set; }


    }
}
