using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrustructer.Abstracts;
using SchoolProject.Infrustructer.Repositories;

namespace SchoolProject.Infrustructer
{
    public static class ModuleInfurstructerDepandencies
    {
        //This is Extention Method 
        public static IServiceCollection AddInfurstructerDepandencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}