using System.ComponentModel.DataAnnotations;

namespace PortfolioAPI.Models
{
    public class ExperienceForCreationRequest
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        [Url]
        public string ImagePath { get; set; }
    }
}
