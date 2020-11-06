using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4
{
    public static class Task1
    {
        public static void Foo()
        {
            Console.WriteLine("Enter N:");

            int N = Convert.ToInt32(Console.ReadLine());

            IEnumerable<int> nums = Enumerable.Range(1, N);

            var result = from num in nums
                         where num != 5 && num != 9 && (num % 2 == 1 || num % 7 == 0)
                         select num * num;

            Console.WriteLine("Sum: " + result.Sum());
            Console.WriteLine("Count: " + result.Count());
            Console.WriteLine("First: " + result.First());
            Console.WriteLine("Last: " + result.Last());
            Console.WriteLine("Third: " + result.ElementAtOrDefault(2));
        }
    }
}
