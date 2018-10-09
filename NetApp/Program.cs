﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am .net 4.7.1 App");
            while (true)
            {
                var q = new Queue<int>();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 0; i < 10000000; i++)
                {
                    q.Enqueue(i);
                    q.Dequeue();
                }
                Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
                Thread.Sleep(1000);
            }
        }
    }
}