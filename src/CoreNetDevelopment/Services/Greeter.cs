using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CoreNetDevelopment.Services
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
