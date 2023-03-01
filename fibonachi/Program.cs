using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(1);
            Console.WriteLine("vuvedi koe pored na fibonachi iskash");
            byte numfib = byte.Parse(Console.ReadLine());
            for (int i = 2; i < numfib; i++)
            {
                numbers.Add(numbers[i-2] + numbers[i-1]);
            }
            Console.WriteLine(string.Join(" , ",numbers));
        }

    }
}
