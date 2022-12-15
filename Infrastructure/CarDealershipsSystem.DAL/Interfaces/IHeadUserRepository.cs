﻿using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.DAL.Interfaces
{
    public interface IHeadUserRepository
    {
        public IEnumerable<HeadUser> GetHeadUsers();
    }
}