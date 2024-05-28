using Microsoft.Extensions.DependencyInjection;
using SiparisAdisyon.Business.Abstract;
using SiparisAdisyon.Business.Concrete;
using SiparisAdisyon.Core.Repository.EntityFramework;
using SiparisAdisyon.Entity.Databases.Mssql;
using SiparisAdisyon.Repository.Abstract;
using SiparisAdisyon.Repository.Concrete;
using System.Reflection;

namespace SiparisAdisyon.Business.DependencyInjection;

public static class ProjectDependencyInjection
{
    public static void AddProjectDependencyInjection(this IServiceCollection services)
    {

        services.AddScoped<ProjectDbContext>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IAuthRepository, AuthRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();

        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICompanyRepository, CompanyRepository>();



        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<ICategoryService, CategoryService>();

        services.AddScoped<IRoleService, RoleService>();

    }
}