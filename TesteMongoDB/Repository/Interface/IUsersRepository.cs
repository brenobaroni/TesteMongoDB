using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMongoDB.Domain.Entities;

namespace TesteMongoDB.Repository.Interface
{
    public interface IUsersRepository
    {
        Task<IEnumerable<Users>> GetAll();
    }
}
