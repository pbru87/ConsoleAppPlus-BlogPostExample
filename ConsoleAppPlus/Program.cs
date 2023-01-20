using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using SuWPB.DotNetUtils.Extensions;
using ConsoleAppPlus;

// Set up dependency injection
using IHost host = CreateHostBuilder(args).Build();
using var scope = host.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
    // Define entry point
    await services.GetRequiredService<App>().Run(args);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

#region Local Methods
static IHostBuilder CreateHostBuilder(string[] args)
{
    // ToDo: Uncomment if appsettings.json should be taken from another project/directory.
    // Configure location of appsettings.json
    //var workingDir = Directory.GetCurrentDirectory();
    //var solutionDir = new DirectoryInfo(workingDir).GetParent(5)!.FullName;
    //var appsettingsFolder = Path.Combine(solutionDir, "src", "<OTHER_PROJECT_FOLDER>");
    //var fileProvider = new PhysicalFileProvider(appsettingsFolder);

    // Configure HostBuilder
    return Host.CreateDefaultBuilder(args)
        // ToDo: Uncomment if appsettings.json should be taken from another project/directory.
        //.ConfigureAppConfiguration((_, config) =>
        //{
        //    config.AddJsonFile(fileProvider, "appsettings.json", false, true);
        //})
        .ConfigureServices((_, services) =>
        {
            // ToDo: Register your required services here!
            services.AddSingleton<App>();
        });
}
#endregion
