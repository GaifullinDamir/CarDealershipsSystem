using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IBranchService
    {
        public interface IBranchRepository
        {
            IEnumerable<Branch> GetBranches();
        }
    }
}
