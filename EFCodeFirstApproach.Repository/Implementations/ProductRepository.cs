using EFCodeFirstApproach.DataAccess;
using EFCodeFirstApproach.DataAccess.Entity;
using EFCodeFirstApproach.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach.Repository.Implementations
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(TransactionContext transactionContext) : base(transactionContext)
        {
                
        }
    }
}
