using PortfolioAPI.Entities;

namespace PortfolioAPI.Repositories
{
    public static class ExperienceRepository
    {
        public static List<Experience> Experiences { get; set; } = new List<Experience>()
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
