using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoAsyncApi.Entities;

namespace DemoAsyncApi.Services
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUser(Guid id);
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserAsync(Guid id);
    }
}
