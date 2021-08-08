using System;
using DataService.Model;
using System.Collections.Generic;
namespace DataService.Repository.Interface
{
    public interface IUserRepository : IRepository<UserModel>
    {
        public IEnumerable<UserModel> GetOldestUser();
    }
}
