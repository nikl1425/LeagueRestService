using System;
using AutoMapper;

namespace LeagueOfLegendsRest.Services.MappedModels
{
    public class UserDto : Profile
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string email { get; set; }
    }
}
