using CarDealershipsSystem.DAL;
using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.DAL.Repositories;
using CarDealershipsSystem.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CarDealershipsSystem.Application.Services;

namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    // To customize application configuration such as set high DPI settings or default font,
        //    // see https://aka.ms/applicationconfiguration.
        //    ApplicationConfiguration.Initialize();
        //    Application.Run(new MainWindow());

        //}

        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<MainWindow>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddDbContext<CarDealershipsDbContext>(options =>
                    {
                        options.UseSqlServer(@"data source=LAPTOP-9S2AK2B9;initial catalog=WarehouseDb;trusted_connection=true"
);
                    });

                    //Repositories
                    services.AddScoped<IBranchRepository, BranchRepository>();
                    services.AddScoped<IBuyerRepository, BuyerRepository>();
                    services.AddScoped<ICarRepository, CarRepository>();
                    services.AddScoped<ICarExemplarRepository, CarExemplarRepository>();

                    //Services
                    services.AddScoped<IBranchService, BranchService>();
                    services.AddScoped<IBuyerService, BuyerService>();
                    services.AddScoped<ICarService, CarService>();
                    services.AddScoped<ICarExemplarService, CarExemplarService>();
                    services.AddTransient<MainWindow>();
                });
        }
    }


}