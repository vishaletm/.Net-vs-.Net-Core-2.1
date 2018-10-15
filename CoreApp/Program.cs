using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace CoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am .net Core 2.1 App");
          // QueueCollection();
          //SortedSetExample();
         // Concat();
        // OrderBy();
        Serialize();
        }

void QueueCollection()
{
     Console.WriteLine("Collection Example 1");
      while (true)
            {
                var q = new Queue<int>();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 0; i < 10000000;i++)
                {
                    q.Enqueue(i);
                    q.Dequeue();
                }
                Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
                Thread.Sleep(1000);
            }
}
        static void SortedSetExample()
        {
             Console.WriteLine("Collection Example 2");
             var sw = Stopwatch.StartNew();
        var ss = new SortedSet<int>(Enumerable.Repeat(42, 400000));
        Console.WriteLine(sw.Elapsed);
        }
        static void Concat()
        {
            //
             IEnumerable<int> zeroToTen = Enumerable.Range(0, 10);
        IEnumerable<int> result = zeroToTen;
        for (int i = 0; i < 10000; i++)
        {
            result = result.Concat(zeroToTen);
        }

        var sw = Stopwatch.StartNew();
        foreach (int i in result) { }
        Console.WriteLine(sw.Elapsed);
    
            //
        }
         static void OrderBy()
        {
            Console.WriteLine("Linq  Example Order by");
            IEnumerable<int> tenMillionToZero = Enumerable.Range(0, 10000000).Reverse();
            while (true)
            {
                var sw = Stopwatch.StartNew();
                int fifth = tenMillionToZero.OrderBy(i => i).Skip(4).First();
                Console.WriteLine(sw.Elapsed);
            }
        }

        static void Serialize()
        {
            Console.WriteLine("Serilization Example");
            var books = new List<Book>();
            for (int i = 0; i < 1000000; i++)
            {
                string id = i.ToString();
                books.Add(new Book { Name = id, Id = id });
            }

            var formatter = new BinaryFormatter();
            var mem = new MemoryStream();
            formatter.Serialize(mem, books);
            mem.Position = 0;

            var sw = Stopwatch.StartNew();
            formatter.Deserialize(mem);
            sw.Stop();

            Console.WriteLine(sw.Elapsed.TotalSeconds);
        }

        [Serializable]
        private class Book
        {
            public string Name;
            public string Id;
        }
    }
}
