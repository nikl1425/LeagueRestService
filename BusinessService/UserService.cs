using System;
using BusinessService.Interface;
using DataService;
using BusinessService.ModelDto;
using System.Linq;


using System.Collections.Generic;

namespace BusinessService
{
    public class UserService : IUserService
    {

        private IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        
        public IEnumerable<UserDto> GetAll()
        {
            var x = _unitOfWork.Users.GetAll().Select(x => new UserDto
            {
                id = x.id,
                age = x.age,
                email = x.email,
                firstName = x.firstName,
                lastName = x.lastName
            });

            return x;
        }
    }
}
