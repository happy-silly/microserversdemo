using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.Elasticsearch;

namespace Business
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
//#if DEBUG
//                .AddJsonFile("appsettings.Development.json")
//#else
                .AddJsonFile("appsettings.json")
//#endif
                .AddEnvironmentVariables()
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
//#if DEBUG
                .MinimumLevel.Debug()
//#else
//                .MinimumLevel.Information()
//#endif
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                //.WriteTo.Async(c => c.File("Logs/logs.txt"))
                .WriteTo.Elasticsearch(
                    new ElasticsearchSinkOptions(new Uri(configuration["ElasticSearch:Url"]))
                    {
                        AutoRegisterTemplate = true,
                        AutoRegisterTemplateVersion = AutoRegisterTemplateVersion.ESv6,
                        IndexFormat = "msdemo-log-{0:yyyy.MM}"
                    })
                //.WriteTo.Console()
                .CreateLogger();

            try
            {
                Log.Information("Starting Business.Host");
                CreateHostBuilder(args).Build().Run();
                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly!");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        internal static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .UseAutofac()
                .UseSerilog();
    }
}
