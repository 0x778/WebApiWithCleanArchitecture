using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrustructer.Abstracts;
using SchoolProject.Infrustructer.Repositories;
using SchoolProject.Service.Abstract;
using SchoolProject.Service.Implemention;

namespace SchoolProject.Service
{
    public static class ModuleServiceDepandencies
    {
        public static IServiceCollection AddServiceDepandencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }
    }
}