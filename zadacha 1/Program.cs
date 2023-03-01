using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi broi elementi: ");
            int n =int.Parse (Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vuvedi chislo: ");
                int item=int.Parse(Console.ReadLine()); 
                numbers.Add(item);
            }


            //
            //int newIndex = n / 2;
            //numbers.Insert(newIndex,6);

            ////
            //int minElement = numbers.Min();
            //numbers.Add(minElement);

            ////da iztriq nulite 
            // foreach (int chervenokvadratche in numbers)
            while (numbers.Contains (0)) ;
            {
                numbers.Remove(0);
            }
            
               
            
           



            //pechat
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"numbers[{i}]= {numbers[i]}");
            }

            Console.WriteLine("broqt na elementite v spisaka e: "+numbers.Count);
        }
    }
}
