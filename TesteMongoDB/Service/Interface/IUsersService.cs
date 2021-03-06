using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMongoDB.Domain.Entities;

namespace TesteMongoDB.Service.Interface
{
    public interface IUsersService
    {
        Task<IEnumerable<Users>> GetUsersAsync();
    }
}
