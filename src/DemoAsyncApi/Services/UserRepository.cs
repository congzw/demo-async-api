using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoAsyncApi.Contexts;
using DemoAsyncApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoAsyncApi.Services
{
    public class UserRepository : IUserRepository, IDisposable
    {
        private UserDbContext _userDbContext;

        public UserRepository(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext ?? throw new ArgumentNullException(nameof(userDbContext));
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _userDbContext.Users.ToListAsync();
        }

        public Task<User> GetUserAsync(Guid id)
        {
            return _userDbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public void Dispose()
        {
            Disposed(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Disposed(bool disposing)
        {
            if (disposing)
            {
                if (_userDbContext != null)
                {
                    _userDbContext.Dispose();
                    _userDbContext = null;
                }
            }
        }
    }
}