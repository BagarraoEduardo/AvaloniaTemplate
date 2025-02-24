using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaTemplate.Extensions;

public static class PresentationExtensions
{
    public static IServiceCollection SetupPresentation(this IServiceCollection services, IConfiguration configuration) => services;
}
