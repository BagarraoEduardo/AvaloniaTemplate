using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaTemplate.Core.Application.Extensions;

public static class ApplicationExtensions
{
    public static IServiceCollection SetupApplication(this IServiceCollection services, IConfiguration configuration) => services;
}
