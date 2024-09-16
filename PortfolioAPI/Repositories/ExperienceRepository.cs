using PortfolioAPI.Entities;

namespace PortfolioAPI.Repositories
{
    public class ExperienceRepository
    {
        public ExperienceRepository() 
        {
            Console.WriteLine("Me instancie");
        }
        public  List<Experience> Experiences { get; set; } = new List<Experience>()
            {
                new Experience()
                {
                    Id = 1,
                    Title = "Exp 1 testing",
                    Description ="zaraza",
                    ImagePath = "zaraza",
                    Summary = "zaraza"

                },
                new Experience()
                {
                    Id = 2,
                    Title = "Exp 2 testing",
                    Description ="zaraza",
                    ImagePath = "zaraza",
                    Summary = "zaraza"

                },
                new Experience()
                {
                    Id = 3,
                    Title = "Programador backend C sharp"
                }

        };
    }
}
