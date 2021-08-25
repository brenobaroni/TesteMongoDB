using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMongoDB.Domain.Entities;
using TesteMongoDB.Repository.Interface;
using TesteMongoDB.Service.Interface;

namespace TesteMongoDB.Service
{
    public class UsersService : IUsersService
    {
        IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<IEnumerable<Users>> GetUsersAsync()
        {
            try
            {
                return await _usersRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
