using System;
using DataService.Repository.Interface;
namespace DataService
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        int Complete();
    }
}
