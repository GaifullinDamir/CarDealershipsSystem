using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;
using Microsoft.EntityFrameworkCore;

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
            var heads = _context.Heads
                .Include(head => head.Branches)
                .ToList();
            return heads;
        }

        public bool SaveHead(Head head)
        {
            if(head == null)
            { return false; }

            _context.Add(head);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public bool SaveHeadChange(Head head)
        {
            if (head == null)
            { return false; }
            return _context.SaveChanges() > 0 ? true : false;
        }
    }
}
