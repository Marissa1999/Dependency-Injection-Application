﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarissaGoncalvesLab7
{
    public class GreetingService : IGreetingService
    {
        public string Greet(string name) => $"Hello, {name}";
    }
}
