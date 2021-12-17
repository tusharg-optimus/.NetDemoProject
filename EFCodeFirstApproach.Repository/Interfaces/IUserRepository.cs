using EFCodeFirstApproach.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach.Repository.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
    }
}
