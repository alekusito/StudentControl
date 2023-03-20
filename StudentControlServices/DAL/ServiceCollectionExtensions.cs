using StudentControl.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace StudentControl.DAL
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection RegisterDataServices(this IServiceCollection services, IConfiguration configuration)
		{
            string mySqlConnectionString = configuration.GetConnectionString("DataBaseConnection") ?? "Error en cadena de conexión";
            services.AddDbContext<DataBaseContext>(options => options.UseMySql(configuration.GetConnectionString("DataBaseConnection"), ServerVersion.AutoDetect(mySqlConnectionString)));

			return services;
		}
    }
}

