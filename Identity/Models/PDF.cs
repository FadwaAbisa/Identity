using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identity.Models
{
    public class PDF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PDF_ID { get; set; }

        public string PDF_Name { get; set; }
        public byte[] PDF_File { get; set; } // استخدم varbinary(max) لتخزين الملف

        [NotMapped]
        public IFormFile? clientFilePDF { get; set; }

        public int CurriculumId { get; set; }

        [ValidateNever]
        public Curriculums Curriculums { get; set; } // علاقة بين جدول المناهج

        [ForeignKey("Curriculums")]
        public int CurriculumsID { get; set; }

    }
}
