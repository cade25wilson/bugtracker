﻿using System.ComponentModel.DataAnnotations;
using bugtracker.Models;

namespace bugtracker.Models
{
    public class IssuePriority
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
