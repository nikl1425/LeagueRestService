using System;
using DataService.Repository.Interface;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataService.Repository.Instatiation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly MySqlContext _context;

        public Repository(MySqlContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.AddRange(entities);
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            _context.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.RemoveRange(entities);
        }
    }

}
