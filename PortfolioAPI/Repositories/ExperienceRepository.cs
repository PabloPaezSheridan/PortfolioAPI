using PortfolioAPI.Entities;

namespace PortfolioAPI.Repositories
{
    public class ExperienceRepository
    {
        public List<Experience> Experiences { get; set; } 

        public ExperienceRepository()
        {
            Experiences = new List<Experience>()
            {
                new Experience()
                {
                    Title = "Exp 1 testing",
                    Description ="zaraza",
                    ImagePath = "zaraza",
                    Summary = "zaraza"
                    
                },
                new Experience()
                {
                    Title = "Exp 2 testing",
                    Description ="zaraza",
                    ImagePath = "zaraza",
                    Summary = "zaraza"

                },
                new Experience()
                {
                    Title = "Programador backend C sharp"
                }
            };
        }
    }
}
