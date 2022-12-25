using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarDTO> GetCars();

        public int GetCarExemplarsCount(BranchDTO branch);

        public bool IsCarExistById(int idCar);

        public bool AddCar(string brand, string model, string bodyType, int idBranch);

        public bool DeleteCar(int idCar);

        public List<CarDTO> GetCarsByBrandModel(string brand, string model);

        public CarDTO GetCarByID(int idCar);
    }
}
