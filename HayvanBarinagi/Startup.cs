using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HayvanBarinagi.Models;

namespace HayvanBarinagi
{
    public class Startup
    {


        public void ConfigureServices(IServiceCollection services)
        {
            IConfiguration configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            services.AddSingleton(configuration);


        }

    }
}
