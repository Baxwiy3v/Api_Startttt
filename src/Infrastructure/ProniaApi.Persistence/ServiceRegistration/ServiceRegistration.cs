﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProniaApi.Application.Abstractions.Repositories;
using ProniaApi.Application.Abstractions.Services;
using ProniaApi.Domain.Entities;
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
            services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 8;
                opt.User.RequireUniqueEmail = true;
                opt.Lockout.AllowedForNewUsers = true;
                opt.Lockout.MaxFailedAccessAttempts = 3;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            }).AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>();


            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
			services.AddScoped<ITagService, TagService>();
            services.AddScoped<IColorService, ColorService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();



            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IColorRepository, ColorRepository>();


            return services;
		}
	}
}
