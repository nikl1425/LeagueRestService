using System;
using System.Collections.Generic;
using LeagueOfLegendsRest.Services.MappedModels;


namespace LeagueOfLegendsRest.Services.IService
{
    public interface IUserService
    {
        public IEnumerable<UserDto> GetAllUsers();
    }
}
