﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIDemo.Entites
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public Decimal Price { get; set; }
        [Required]
        public string? Author { get; set; }
        [ScaffoldColumn(false)]
        public int IsActive { get; set; }
    }
}
