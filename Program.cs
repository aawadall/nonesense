using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var y = new List<int>();
            Random random = new Random();
            int maxIdx = 1_000; // Maximum index 
            for (int idx =0; idx < maxIdx; idx++)
            {
                int lowerBound = -10;
                int upperBound = 10;
                y.Add(random.Next(lowerBound, upperBound));
            }

            var c = y.GetTop(10);
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
            //var q = y.GetNegative();
            
            //var p = y.GetPositive().ToList();
            //var p = y.GetPositive();
            //foreach (var p_item in p)
            //{

            //}

            Console.ReadKey();
        }
    }

    public static class Extender
    {
        public static IEnumerable<int> GetPositive(this IEnumerable<int> test)
        {
            foreach (var item in test)
            {
                Console.WriteLine($"Testing {item} for +ve");
                if (item > 0)
                {
                    //Console.WriteLine($"{item} is +ve");  
                    yield return item;
                }
            }
        }

        public static IEnumerable<int> GetNegative(this IEnumerable<int> test)
        {
            foreach (var r in test)
            {
                if (r < 0)
                {
                    Console.WriteLine($"{r}");
                    yield return r;
                    yield break;
                }
            }
        }

        public static IEnumerable<int> GetTop(this IEnumerable<int> test, int count)
        {
            int counter = 0;
            foreach (var item in test)
            {
                Console.WriteLine($"Iteration # {counter}");
                yield return item;
                counter++;
                if (counter >= count) yield break;
            }
        }
    }
}
