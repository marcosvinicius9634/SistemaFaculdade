using Microsoft.Extensions.DependencyInjection;
using SistemaNassau.Application.Interface;
using SistemaNassau.Application.Services;
using SistemaNassau.Domain.Interface;
using SistemaNassau.Infra.Repositores;

namespace Template.IoC
{
    public static class NativeInjector
    {
        public static void RegisterService(IServiceCollection services)
        {
            #region Services
            services.AddScoped<IUserService, UserService>();

            #endregion

            #region Repository

            services.AddScoped<IUserRepository, UserRepository>();

            #endregion
        }
    }
}