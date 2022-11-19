using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IBranchService
    {
       
        IEnumerable<Branch> GetBranches();
        
    }
}
