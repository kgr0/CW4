using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4
{
    public static class Task3
    {
        public static void Foo()
        {
            Console.WriteLine("Enter N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter M: ");
            int M = Convert.ToInt32(Console.ReadLine());

            IEnumerable<int> nums = Enumerable.Range(1, N);

            // IEnumerable<int> res = nums.SelectMany(p => Enumerable.Range(1, M));

            // var sortedResults = from r in res orderby Guid.NewGuid() ascending select r;
            Random _rand = new Random();
            var result = nums.SelectMany(p => Enumerable.Range(0, M)
                        .Select(r => _rand.Next(100))
                        .ToList());

            Console.WriteLine();
            int j = 1;
            foreach (var i in result)
            {
                Console.Write(i + " ");
                if (j % M == 0)
                    Console.WriteLine();
                j++;
            }
        }
    }
}
