using System;
using DemoAsyncApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoAsyncApi.Controllers
{
    [Route("api/sync_users")]
    public class SyncUserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public SyncUserController(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }
        
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userRepository.GetUsers();
            return Ok(users);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetUser(Guid id)
        {
            var user = _userRepository.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
