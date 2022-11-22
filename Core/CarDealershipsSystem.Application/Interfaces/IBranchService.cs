﻿using CarDealershipsSystem.Application.DTO;

namespace CarDealershipsSystem.Application.Interfaces
{
    public interface IBranchService
    {
        IEnumerable<BranchDTO> GetBranches();
    }
}