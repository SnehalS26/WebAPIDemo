﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIDemo.Entites
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genere { get; set; }
        [Required]
        public DateTime Realeased_Date { get; set; }
        [Required]
        public string Starcast { get; set; }
        [ScaffoldColumn(false)]
        public int IsActive { get; set; }
    }
}
