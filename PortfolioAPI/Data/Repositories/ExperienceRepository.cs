using PortfolioAPI.Data;
using PortfolioAPI.Entities;

namespace PortfolioAPI.Data.Repositories
{
    public class ExperienceRepository
    {
        private readonly ApplicationContext _context;

        public ExperienceRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Experience> Get() 
        {
            return _context.Experiences.ToList();
        }

        public int Add(Experience exp)
        {
            _context.Experiences.Add(exp);
            _context.SaveChanges();
            return exp.Id;
        }
    }
}
