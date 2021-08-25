using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMongoDB.Service.Interface;

namespace TesteMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        [Route("GetUsers")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _usersService.GetUsersAsync();
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
