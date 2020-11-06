using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4
{
    public static class Task2
    {
        public static void Foo()
        {
            Console.WriteLine("Enter a list of cities: ");
            List<string> list = new List<string>();
            string input;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "X")
                    break;
                else
                    list.Add(input);
            }

            Dictionary<char, List<string>> dict = list
                  .GroupBy(city => city[0])
                  .ToDictionary(city => city.Key,
                                group => group.OrderBy(city => city)
                                               .ToList());

            //foreach (var group in dict)
            //{
            //    Console.WriteLine($"Key: {group.Key}");
            //    foreach (var city in group.Value)
            //    {
            //        Console.WriteLine($"\t{city}");
            //    }
            //}

            char letter = ' ';
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter a letter: ");
                while (letter < 65 || letter > 90)
                {
                    letter = Convert.ToChar(Console.Read());
                }

                var result = dict.Where(group => group.Key == letter).FirstOrDefault();
                if (result.Value == null)
                {
                    Console.WriteLine("PUSTE");
                }
                else
                {
                    foreach (var city in result.Value)
                    {
                        Console.Write($"{city} ");
                    }
                    Console.WriteLine();
                }

                letter = Convert.ToChar(Console.Read());
            }
        }
    }
}
