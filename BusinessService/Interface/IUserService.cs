using System;
using System.Collections.Generic;
using BusinessService.ModelDto;


namespace BusinessService.Interface
{
    public interface IUserService
    {
        public IEnumerable<UserDto> GetAll();
    }
}
