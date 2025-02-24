using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaTemplate.Infraestructure.Integration.Extensions;

public static class IntegrationExtensions
{
    public static IServiceCollection SetupIntegration(this IServiceCollection services, IConfiguration configuration) => services;
}
