﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchprgm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            sw.Stop();
            Console.WriteLine("Elapsed Time:"+sw.ElapsedMilliseconds);
           
        }
    }
}
