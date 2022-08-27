﻿using System.ComponentModel.DataAnnotations;

namespace CommandAPINEW.Models
{
    public class CommandModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Howto { get; set; } 
        [Required]
        public string  Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}
