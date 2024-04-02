using LW1.Data;
using LW1.Exceptions;
using LW1.External;
using LW1.Forms;
using LW1.Models.Service;
using LW1.Repositories;
using LW1.Repositories.Interfaces;
using LW1.Services;
using LW1.Services.Interfaces;
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
        Application.ThreadException += new ThreadExceptionEventHandler(UIThreadException);
        
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomainExceptionHandler);
        
        ApplicationConfiguration.Initialize();

        var host = CreateHostBuilder().Build();
        var serviceProvider = host.Services;

        using var scope = host.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<DataContext>();
        context.Init();
        
        Application.Run(serviceProvider.GetRequiredService<Forms.MainForm>());
    }

    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services)=>
            {
                services.AddTransient<IAirportRepository, AirportRepository>();
                services.AddTransient<IAirportService, AirportService>();
                services.AddTransient<MainForm>();
                services.AddSingleton<DataContext>();
            });
    }

    
    
    private static void CurrentDomainExceptionHandler(object sender, UnhandledExceptionEventArgs args)
    {
        Exception ex = (Exception)args.ExceptionObject;
        ExceptionHandler(ex);
    }
    
    private static void UIThreadException(object sender, ThreadExceptionEventArgs t)
    {
        Exception ex = t.Exception;
        ExceptionHandler(ex);
    }

    private static void ExceptionHandler(Exception ex)
    {
        try
        {
            switch (ex)
            {
                case InvalidValidationException<Airport> ive:
                    Win32.MessageBox(0, ive.ValueObject.ToString(), ive.Description, 0);
                    break;
                case CustomInvalidCastException cice:
                    Win32.MessageBox(0, cice.StackTrace, cice.StackTrace, 0);
                    break;
                case FormatException fe:
                    Win32.MessageBox(0, "Неверный формат введенных данных", "Ошибка формата ввода", 0);
                    break;
                default:
                    Win32.MessageBox(0, ex.Message, "Untyped exception", 0);
                    break;
            }
        }
        catch (Exception innerEx)
        {
            try
            {
                Win32.MessageBox(0, "Fatal exception happend inside UnhadledExceptionHandler: \n\n"
                                    + innerEx.Message, "Fatal exception", 0);
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}