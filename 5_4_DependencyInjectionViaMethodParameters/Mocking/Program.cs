﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_DependencyInjectionViaMethodParameters.Mocking
{
    public class Program
    {
        public static void Main()
        {
            var service = new VideoService();
            var title = service.ReadVideoTitle(new FileReader());
        }
    }
}
