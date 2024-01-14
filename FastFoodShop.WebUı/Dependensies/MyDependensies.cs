using DataAccessLayer.Database;
using Microsoft.EntityFrameworkCore;

namespace FastFoodShop.WebUı.Dependensies;
public static class MyDependensies
{
	public static IServiceCollection AddDependencyServices(this IServiceCollection services, ConfigurationManager configuration)
	{
		services.ConfigureServices();
		services.AddDbContext<AppDbContext>(x => x.UseSqlServer(configuration.GetConnectionString("SqlConnection")));
		return services;
	}
	public static IServiceCollection ConfigureServices(this IServiceCollection services) 
	{
		return services;
	}
}