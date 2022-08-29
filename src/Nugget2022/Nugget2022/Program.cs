using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OpenTelemetry;
using OpenTelemetry.Exporter;
using OpenTelemetry.Logs;
using OpenTelemetry.Resources;

namespace Nugget2022
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(builder => builder
                    .AddOpenTelemetry(options =>
                    {
                        options.IncludeScopes = false;
                        options.IncludeFormattedMessage = true;
                        options.ParseStateValues = true;
                        options.SetResourceBuilder(ResourceBuilder.CreateDefault()
                            .AddTelemetrySdk()
                            .AddEnvironmentVariableDetector());
                        options.AddOtlpExporter(config =>
                        {
                            config.Endpoint = new Uri("http://localhost:4318/v1/logs");
                            config.Protocol = OtlpExportProtocol.HttpProtobuf;
                            config.ExportProcessorType = ExportProcessorType.Batch;
                            config.BatchExportProcessorOptions.ExporterTimeoutMilliseconds = 1000;
                        });
                        options.AttachLogsToActivityEvent();
                    })
                    .AddConsole())
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}