using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreNetDevelopment.Services
{
    public class Greeter : IGreeter
    {
        public string GetGreeting()
        {
            return "Hello from Greeter";
        }
    }
}
