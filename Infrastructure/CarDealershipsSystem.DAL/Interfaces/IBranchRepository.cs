using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface IBranchRepository
    {
        IEnumerable<Branch> GetBranches();

        public Branch GetBranchById(int id);

        IEnumerable<Branch> GetBranchesByName(string branchName);

        public IEnumerable<Branch> GetBranchesWithCarsExemplars();

        public bool SaveBranch(Branch branch);
    }
}
