using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IBuyerService
    {
        IEnumerable<BuyerDTO> GetBuyers();

        public BuyerDTO GetBuyerById(int idBuyer);

        public bool IsBuyerExistByPassData(string buyerPassData);

        public bool AddBuyer(string buyerPassData, string buyerSurname,
            string buyerName, string buyerMiddlename,
            string buyerPhoneNumber);

        public BuyerDTO GetBuyerByPassData(string passData);
    }
}
