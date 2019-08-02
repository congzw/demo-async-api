using DemoAsyncApi.Contexts;
using DemoAsyncApi.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DemoAsyncApi.Extensions
{
    public static class UserDbExtensions
    {
        public static void AddUserDb(this IServiceCollection services, IConfiguration config)
        {
            var userDb = config["ConnectionStrings:UserDb"];
            services.AddDbContext<UserDbContext>(o => o.UseSqlServer(userDb));
            services.AddScoped<IUserRepository, UserRepository>();
            //services.AddSingleton<ISimpleJsonFile>(sp => sp.GetService<SimpleJson>());
        }
    }
}