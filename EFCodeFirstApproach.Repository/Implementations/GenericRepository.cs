using EFCodeFirstApproach.DataAccess;
using EFCodeFirstApproach.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach.Repository.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly TransactionContext _transactionContext;

        private DbSet<T> _entity; 
        public GenericRepository(TransactionContext transactionContext)
        {
            _transactionContext = transactionContext;
            _entity = _transactionContext.Set<T>();
        }
        public async Task<T> Add(T obj)
        {
            var result = await _entity.AddAsync(obj);
            _transactionContext.SaveChanges();
            return result.Entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entity.ToListAsync();
        }
    }
}
