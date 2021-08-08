using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataService;
using LeagueOfLegendsRest.Services.IService;
using LeagueOfLegendsRest.Services.MappedModels;

namespace LeagueOfLegendsRest.Services.Service
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            var b = _unitOfWork.Users.GetAll();
            _unitOfWork.Complete();
            var y = from x in b select _mapper.Map<UserDto>(x);

            return y;
            

        }
    }
}
