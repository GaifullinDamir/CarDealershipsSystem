﻿using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IBranchService
    {
        IEnumerable<BranchDTO> GetBranches();

        public bool AddBranch(string branchName, string branchAddress, int idHead);

        public bool IsBranchExistsById(int idBranch);

        public IEnumerable<BranchDTO> SearchBranch(string branchName);
    }
}
