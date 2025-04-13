using EntityFramework.Core.Basics.Repo;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Core.Basics.web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<BlogsDbContext>(options =>
            {
                options.UseSqlServer(connString);
            });
        }
    }
}