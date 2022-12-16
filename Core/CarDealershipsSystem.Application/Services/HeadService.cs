using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;

namespace CarDealershipsSystem.Application.Services
{
    public class HeadService : IHeadService
    {
        private readonly IHeadRepository _headRepository;

        public HeadService(IHeadRepository headRepository)
        {
            _headRepository = headRepository;
        }

        public IEnumerable<HeadDTO> GetHeads()
        {
            var heads = _headRepository.GetHeads();
            var headsDTO = heads
                .Select(head => new HeadDTO
                {
                    IdHead = head.IdHead,
                    HeadPassData = head.HeadPassData,
                    HeadName = head.HeadName,
                    HeadSurname = head.HeadSurname,
                    HeadMiddlename = head.HeadMiddlename,
                    HeadPhoneNumber = head.HeadPhoneNumber,
                    HeadPassword = head.HeadPassword,
                    HeadLogin = head.HeadLogin,
                    Branches = head.Branches
                        .Select(branch => new BranchDTO
                        {
                            IdBranch = branch.IdBranch,
                            BranchName = branch.BranchName,
                            BranchAddress = branch.BranchAddress,
                            Cars = branch.Cars
                            .Select(car => new CarDTO
                            {
                                IdCar = car.IdCar,
                                IdBranch = car.IdBranch,
                                Brand = car.Brand,
                                Model = car.Model,
                                BodyType = car.BodyType,
                                CarExemplars = car.CarExemplars
                                        .Select(carex => new CarExemplarDTO
                                        {
                                            VinNumber = carex.VinNumber,
                                            IdCar = carex.IdCar,
                                            HorsePower = carex.HorsePower,
                                            Price = carex.Price,
                                            Color = carex.Color,
                                            YearOfAssembly = carex.YearOfAssembly
                                        })
                                        .ToList()
                            })
                            .ToList(),
                            Managers = branch.Managers
                                .Select(manager => new ManagerDTO
                                {
                                    MngrPassData = manager.MngrPassData,
                                    IdBranch = manager.IdBranch,
                                    MngrSurname = manager.MngrSurname,
                                    MngrName = manager.MngrName,
                                    MngrMiddlename = manager.MngrMiddlename,
                                    MngrPhoneNumber = manager.MngrPhoneNumber,
                                    MngrSalary = manager.MngrSalary,
                                    MngrPayDate = manager.MngrPayDate,
                                    MngrPrize = manager.MngrPrize,
                                    CarOrders = manager.CarOrders
                                        .Select(carorder => new CarOrderDTO
                                        {
                                            IdOrder = carorder.IdOrder,
                                            IdMngr = carorder.IdMngr,
                                            IdBuyer = carorder.IdBuyer,
                                            ContractDate = carorder.ContractDate,
                                            OrderAmount = carorder.OrderAmount
                                        })
                                        .ToList()
                                })
                                .ToList()
                        })
                         .ToList()
                }).ToList();
            return headsDTO;
        }
    }
}
