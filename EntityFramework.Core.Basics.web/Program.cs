using EntityFramework.Core.Basics.Repo;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Core.Basics.web{
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<BlogsDbContext>(options=>{
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        });
    }
}
}