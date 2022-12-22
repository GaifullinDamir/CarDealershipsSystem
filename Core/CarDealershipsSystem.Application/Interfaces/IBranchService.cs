using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IBranchService
    {
        IEnumerable<BranchDTO> GetBranches();

        public bool AddBranch(string branchName, string branchAddress, int idHead);

        public bool IsBranchExistsById(int idBranch);

        public bool IsBranchExistByNameOrByAddress(string branchAddress);

        public IEnumerable<BranchDTO> SearchBranch(string branchName);

        public BranchDTO GetBranchById(int idBranch);
    }
}
