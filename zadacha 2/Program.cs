using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            byte count = 1;
            byte maxCount = 0;
            int repeatedElements = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    count++;
                    repeatedElements = numbers[i];  
                }
                else
                {
                    if (count>maxCount)
                    {
                        maxCount=count;
                    }
                    count = 1;
                }
            }
        }
    }
}
