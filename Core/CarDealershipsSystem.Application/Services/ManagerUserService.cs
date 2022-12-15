using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;

namespace CarDealershipsSystem.Application.Services
{
    public class ManagerUserService : IManagerUserService
    {
        private readonly IManagerUserRepository _managerUserRepository;
        public ManagerUserService(IManagerUserRepository managerUserRepository)
        {
            _managerUserRepository = managerUserRepository;
        }

        public IEnumerable<ManagerUserDTO> GetManagerUsers()
        {
            var managerUsers = _managerUserRepository.GetManagerUsers();
            var managerUsersDTO = managerUsers
                .Select(managerUser => new ManagerUserDTO
                {
                    ManagerId = managerUser.ManagerId,
                    ManagerPassword = managerUser.ManagerPassword,
                    ManagerLogin = managerUser.ManagerLogin,
                    MngrPassData = managerUser.MngrPassData
                }).ToList();
            return managerUsersDTO;
        }
    }
}
