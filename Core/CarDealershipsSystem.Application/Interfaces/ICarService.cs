using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarDTO> GetCars();

        public int GetCarExemplarsCount(BranchDTO branch);

        //public CarDTO GetCarByID(int idCar);

        public bool AddCar(string brand, string model, string bodyType, int idBranch);

        public bool DeleteCar(int idCar);
    }
}
