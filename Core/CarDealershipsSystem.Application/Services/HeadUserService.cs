using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;

namespace CarDealershipsSystem.Application.Services
{
    public class HeadUserService : IHeadUserService
    {
        private readonly IHeadUserRepository _headUserRepository;
        public HeadUserService(IHeadUserRepository headUserRepository)
        {
            _headUserRepository = headUserRepository;
        }

        public IEnumerable<HeadUserDTO> GetHeadUsers()
        {
            var headUsers = _headUserRepository.GetHeadUsers();
            var headUsersDTO = headUsers
                .Select(headUser => new HeadUserDTO
                {
                    HeadId = headUser.HeadId,
                    HeadPassword = headUser.HeadPassword,
                    HeadLogin = headUser.HeadLogin,
                    HeadPassData = headUser.HeadPassData
                }).ToList();
            return headUsersDTO;
        }
    }
}
