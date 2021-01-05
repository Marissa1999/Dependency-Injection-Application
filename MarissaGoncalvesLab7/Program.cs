using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarissaGoncalvesLab7
{
    class Program
    {
        static void Main()
        {
            using (ServiceProvider container = RegisterServices())
            {
                var controller = container.GetRequiredService<HomeController>();
                string result = controller.Hello("VANIER");
                Console.WriteLine(result);
            }
        }

        static ServiceProvider RegisterServices()
        { 
            var services = new ServiceCollection();
            services.AddSingleton<IGreetingService, GreetingService>();
            services.AddTransient<HomeController>();
            return services.BuildServiceProvider();
        }
    }

}
