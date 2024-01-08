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
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetDefaultFont(new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold));
            Application.EnableVisualStyles();
            //TODO: Create a DI and register services to be used in application lifetime

            //Services are registered here!
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());

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
                options.UseSqlServer(@"Server=GEEOLIVEROS\\SQLEXPRESS;Database=microPOSDB;Trusted_Connection=True;");
            });
            #endregion


            //services.AddScoped<IPOSService, POSService>();

            //services.AddScoped<MainForm>(); // Replace Form1 with your main form class





            ////using ( var serviceScope = host.Services.CreateScope() )
            ////{
            ////    var serviceProvider = serviceScope.ServiceProvider;
            ////     var bootstrap = host.Services.GetRequiredService<MainForm>(); //sets the starting form

            ////    Application.Run(bootstrap);


            ////}
            //// Build the service provider
            //using (var serviceProvider = services.BuildServiceProvider())
            //{
            //    // Resolve the main form and run the application
            //    Application.Run(serviceProvider.GetRequiredService<MainForm>());


             public static IServiceProvider ServiceProvider { get; private set; }


                /// <summary>
                /// Create a host builder to build the service provider
                /// </summary>
                /// <returns></returns>
                static IHostBuilder CreateHostBuilder()
                        {
                            return Host.CreateDefaultBuilder()
                                .ConfigureServices((context, services) => {
                                    //services.AddScoped<TInterface, TImplementation>();
                                    services.AddTransient<MainForm>();
                                });
                        }


    }
    }
}