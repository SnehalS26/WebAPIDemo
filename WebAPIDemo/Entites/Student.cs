using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIDemo.Entites
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Roll { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Percentage { get; set; }
        [ScaffoldColumn(false)]
        public int IsActive { get; set; }
    }
}
