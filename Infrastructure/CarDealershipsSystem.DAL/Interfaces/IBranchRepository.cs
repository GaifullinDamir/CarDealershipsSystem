using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface IBranchRepository
    {
        IEnumerable<Branch> GetBranches();
    }
}
