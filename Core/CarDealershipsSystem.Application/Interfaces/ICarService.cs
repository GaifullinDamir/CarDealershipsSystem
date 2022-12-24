using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarDTO> GetCars();

        public int GetCarExemplarsCount(BranchDTO branch);

        public bool AddCar(string brand, string model, string bodyType, int idBranch);
    }
}
