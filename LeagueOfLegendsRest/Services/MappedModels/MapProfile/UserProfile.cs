using System;
using DataService.Model;
using AutoMapper;

namespace LeagueOfLegendsRest.Services.MappedModels.MapProfile
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserModel, UserDto>();
        }
    }
}
