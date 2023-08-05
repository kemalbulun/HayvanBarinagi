using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class Startup
{
   

    public void ConfigureServices(IServiceCollection services)
    {
        Func<IServiceProvider, IConfiguration> Configuration = null;
        
        services.AddSingleton<IConfiguration>(Configuration);

        
    }

   
}

    

