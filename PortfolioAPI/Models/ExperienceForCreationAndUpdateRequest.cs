﻿using System.ComponentModel.DataAnnotations;

namespace PortfolioAPI.Models
{
    public class ExperienceForCreationAndUpdateRequest
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        public string ImagePath { get; set; }
    }
}
