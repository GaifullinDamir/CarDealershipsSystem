using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface IHeadRepository
    {
        IEnumerable<Head> GetHeads();

        public bool SaveHead(Head head);
    }
}
