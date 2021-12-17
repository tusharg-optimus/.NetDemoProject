using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach.Service.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();

        public Task<T> Add(T obj);
    }
}
