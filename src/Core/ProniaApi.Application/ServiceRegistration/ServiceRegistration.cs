using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ProniaApi.Application.ServiceRegistration
{
	public static class ServiceRegistration
	{
		public static IServiceCollection AddApplicationService(this IServiceCollection services)
		{
			services.AddAutoMapper(Assembly.GetExecutingAssembly());

			return services;
		}
	}
}
