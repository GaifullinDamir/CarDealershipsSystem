using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Repositories
{
    public class HeadRepository : IHeadRepository
    {
        private readonly CarDealershipsDbContext _context;

        public HeadRepository(CarDealershipsDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Head> GetHeads()
        {
            var heads = _context.Heads.ToList();
            return (IEnumerable<Head>)heads;
        }
    }
}
