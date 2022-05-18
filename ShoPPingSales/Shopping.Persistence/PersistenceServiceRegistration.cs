using Microsoft.Extensions.DependencyInjection;
using Shopping.Application.Contracts.Persistence;
using Shopping.Application.Contracts.Persistence.Produits;
using Shopping.Application.Contracts.Persistence.Utilisateurs;
using Shopping.Persistence.Produits;
using Shopping.Persistence.Utilisateurs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Shopping.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnString")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IGenericProduitRepository, GenericProduitRepository>();
            services.AddScoped<IUtilisateurRepository, UtilisateurRepository>();

            return services;
        }
    }
}
