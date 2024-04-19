using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrustructer.Abstracts;
using SchoolProject.Infrustructer.Repositories;
using System.Reflection;

namespace SchoolProject.Core
{
    public static class ModuleCoreDepandencies
    {
        public static IServiceCollection AddModuleCoreDepandencies(this IServiceCollection services)
        {
            //Configuration Of Mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            //Configuration Of Automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;

        }
    }
}