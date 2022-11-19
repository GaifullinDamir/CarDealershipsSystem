using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL;
using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.Application.Services
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _branchRepository;

        public BranchService(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }
        public IEnumerable<Branch> GetBranches()
        {
            var branches = _branchRepository.GetBranches();
            return branches;
        }
    }
}
