using System.Collections.Generic;
using Common;
using DemoAsyncApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoAsyncApi.Contexts
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var mockUserCount = 20;
            var userIds = GuidHelper.CreateMockGuidQueue(mockUserCount);
            var users = new List<User>();
            for (int i = 1; i <= mockUserCount; i++)
            {
                users.Add(new User()
                {
                    Id = userIds.Dequeue(),
                    Username = "User" + i.ToString("00"),
                    FullName = "User" + i.ToString("00"),
                    Desc = "User Desc ..."
                });
            }
            modelBuilder.Entity<User>().HasData(users);

            base.OnModelCreating(modelBuilder);
        }
    }
}
