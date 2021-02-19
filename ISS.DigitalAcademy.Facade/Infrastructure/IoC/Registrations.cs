using ISS.DigitalAcademy.Api.Registration.Command;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ISS.DigitalAcademy.Facade.Infrastructure.IoC
{
    public static class Registrations
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration, IWebHostEnvironment env)
        {
            services.Scan(x =>
            {
                x.AddTypes().FromAssemblyOf<SubmitContactHandler>()

                 // All Handlers
                 .AddClasses(c => c.Where(t => t.Name.EndsWith("Handler", StringComparison.OrdinalIgnoreCase)))
                 .AsImplementedInterfaces()
                 .WithTransientLifetime();
            });
        }
    }
}
