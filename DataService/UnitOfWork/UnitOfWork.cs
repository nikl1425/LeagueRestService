using System;
using DataService.Repository.Interface;
using DataService.Repository.Instatiation;


namespace DataService
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MySqlContext _context;

        
        public UnitOfWork(MySqlContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
        }

        public IUserRepository Users { get; private set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
