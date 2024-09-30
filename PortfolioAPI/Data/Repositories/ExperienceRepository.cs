using PortfolioAPI.Data;
using PortfolioAPI.Data.Entities;

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

        public List<Experience> Get(string title)
        {
            return _context.Experiences.Where(e => e.Title.Contains(title)).ToList();
        }

        public Experience? Get(int id) 
        {
            return _context.Experiences.FirstOrDefault(e => e.Id == id);
        }

        public int Add(Experience exp)
        {
            _context.Experiences.Add(exp);
            _context.SaveChanges();
            return exp.Id;
        }
    }
}
