using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface IBranchRepository
    {
        IEnumerable<Branch> GetBranches();

        IEnumerable<Branch> GetBranchesByName(string branchName);

        public bool SaveBranch(Branch branch);
    }
}
