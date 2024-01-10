using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.Logging;
using Microsoft.Extensions.Hosting;
using POS.Contracts;
using POS.Services;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace POS
{
    internal static class Program
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
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);
            Application.SetDefaultFont(new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold));
            Application.EnableVisualStyles();
            //TODO: Create a DI and register services to be used in application lifetime

            //Services are registered here!
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());

           


            


    }
        public static IServiceProvider? ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    //services.AddScoped<TInterface, TImplementation>();
                    #region Logging Service
                    services.AddLogging(
                                                   log =>
                                                   {
                                                       log.AddConsole();
                                                       log.SetMinimumLevel(LogLevel.Trace);
                                                   });
                    #endregion
                    #region DB Context
                    services.AddDbContext<ApplicationDBContext>(options =>
                    {
                        options.UseSqlServer(@"Server=GEEOLIVEROS\SQLEXPRESS;Database=microPOSDB;Trusted_Connection=True;");
                    });
                    #endregion


                    services.AddTransient< POSService>();
                    services.AddScoped<ICategoryRepository, CategoryRepository>();
                    services.AddScoped<IProductRepository, ProductRepository>();

                    services.AddTransient<MainForm>();
                });
        }
    }
}