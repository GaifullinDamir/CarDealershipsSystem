using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface IBuyerRepository
    {
        IEnumerable<Buyer> GetBuyers();

        public Buyer GetBuyerById(int idBuyer);

        public Buyer GetBuyerByPassData(string buyerPassData);

        public bool SaveBuyer(Buyer buyer);
    }
}
