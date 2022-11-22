using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface IBuyerRepository
    {
        IEnumerable<Buyer> GetBuyers();
    }
}
