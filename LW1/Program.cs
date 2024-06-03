using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LW1;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var host = CreateHostBuilder().Build();
        var serviceProvider = host.Services;

        using var scope = host.Services.CreateScope();
        
        Application.Run(serviceProvider.GetRequiredService<Form1>());
    }

    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services)=>
            {
                services.AddTransient<Form1>();
            });
    }
}