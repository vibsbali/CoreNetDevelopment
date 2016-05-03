using Microsoft.Extensions.Configuration;

namespace CoreNetDevelopment.Services.Greeting
{
    public class Greeter : IGreeter
    {
        public IConfiguration Configuration { get; private set; }
        public Greeter(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public string GetGreeting()
        {
            return Configuration["greeting"];
        }
    }
}
