using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarissaGoncalvesLab7
{
    public class HomeController
    {

        private readonly IGreetingService _greetingService;

        public HomeController(IGreetingService greetingService)
        {
            _greetingService = greetingService ?? throw new ArgumentNullException(nameof(greetingService));
        }

        public string Hello(string name) => _greetingService.Greet(name);

    }
}
