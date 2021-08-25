using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMongoDB.Domain.Entities;
using TesteMongoDB.Repository.Configuration;
using TesteMongoDB.Repository.Interface;

namespace TesteMongoDB.Repository
{
    public class UsersRepository : MongoDBRepository, IUsersRepository
    {
        private readonly IMongoCollection<Users> _users;

        public UsersRepository()
        {
            _users = Database.GetCollection<Users>("users");
        }
        public async Task<IEnumerable<Users>> GetAll()
        {
            return await _users.Find(u => true).ToListAsync();
        }
    }
}
