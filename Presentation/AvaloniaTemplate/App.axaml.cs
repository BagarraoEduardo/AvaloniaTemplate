using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaTemplate.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using AvaloniaTemplate.Infraestructure.Integration.Extensions;
using AvaloniaTemplate.Core.Application.Extensions;

namespace AvaloniaTemplate;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);

        var host = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(configuration =>
            {
                configuration.AddJsonFile("appsettings.json");
            })
            .ConfigureServices((context, services) =>
            {
                var configuration = context.Configuration;

                services.SetupPresentation(configuration);
                services.SetupIntegration(configuration);
                services.SetupApplication(configuration);
            })
            .Build();

        base.Initialize();
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();
        }

        base.OnFrameworkInitializationCompleted();
    }
}