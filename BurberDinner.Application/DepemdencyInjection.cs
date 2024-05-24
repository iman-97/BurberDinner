using BurberDinner.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BurberDinner.Application;

public static class DepemdencyInjection
{
    public static IServiceCollection AddAplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
