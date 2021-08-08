using System;
using System.Collections.Generic;
using System.Linq;
using DataService;
using DataService.Model;
using DataService.Repository.Interface;


namespace DataService.Repository.Instatiation
{
    public class UserRepository : Repository<UserModel>, IUserRepository
    {
        public UserRepository(MySqlContext context) : base(context)
        {
            
        }

        public IEnumerable<UserModel> GetOldestUser()
        {
            IEnumerable<UserModel> oldestUsers = UserContext.Set<UserModel>().
                OrderBy(x => x.age).
                Take(5).
                ToList();

            return oldestUsers;
        }


        // Cast inheritet _context to UserContext
        public MySqlContext UserContext
        { 
            get { return _context;  }
        }
    }
}
