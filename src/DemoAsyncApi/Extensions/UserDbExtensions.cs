using DemoAsyncApi.Contexts;
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
            //services.AddSingleton<SimpleJson>();
            //services.AddSingleton<ISimpleJsonFile>(sp => sp.GetService<SimpleJson>());
        }
    }
}