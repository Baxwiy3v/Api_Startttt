using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProniaApi.Application.Abstractions.Repositories;
using ProniaApi.Application.Abstractions.Services;
using ProniaApi.Persistence.Data;
using ProniaApi.Persistence.Implementations.Repositories;
using ProniaApi.Persistence.Implementations.Repositoriesı;
using ProniaApi.Persistence.Implementations.Services;

namespace ProniaApi.Persistence.ServiceRegistration
{
	public static class ServiceRegistration
	{
		public static IServiceCollection AddPersistenceService(this IServiceCollection services,IConfiguration configuration)
		{
			services.AddDbContext<AppDbContext>(o => o.UseSqlServer(configuration.GetConnectionString("Default")));

			services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
			services.AddScoped<ITagService, TagService>();




			services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IColorRepository, ColorRepository>();


            return services;
		}
	}
}
