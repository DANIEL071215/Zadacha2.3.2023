 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaVChas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            List<int> numbers = Console.ReadLine().Split( ).Select(int.Parse).ToList();// chislata koito sme vuveli ot klaviaturata se printirat s space
            PrintCount(numbers);

            Console.WriteLine("");
            int[] array1=Console.ReadLine().Split( ).Select(int.Parse).ToArray();// dobavqme nov masiv array1 i ni go chete 
            AddArrayToList(numbers, array1);

            Console.WriteLine("");
            int number = int.Parse(Console.ReadLine()); 
            IsNumberInList(numbers, number);

            Console.WriteLine("");
            int[] array2 = Console.ReadLine().Split( ).Select(int.Parse).ToArray();//dobavqme vtoriq masiv array2 i ni go chete
            AddArrayToList2(numbers, array2);
        }

        private static void AddArrayToList2(List<int> numbers, int[] array2)
        {
          numbers.InsertRange(3,array2);
            numbers.Sort();
            Console.WriteLine($" Dobavqme vtoriq masiv: {string.Join("*" ,numbers)}");//tuk dobavqme vtoriq masiv i razdelqme chislata s *
        }

        private static void IsNumberInList(List<int> numbers, int number)
        {
            if (numbers.Contains(number))
            {
                Console.WriteLine($"Chisloto {number} e na {numbers.IndexOf(number)}");
            }
            else
            {
                Console.WriteLine($"Chisloto {number} ne e v spisuka");
            }
        }

        private static void AddArrayToList(List<int> numbers, int[] array1)
        {
            numbers.AddRange(array1);
            numbers.Sort();
            Console.WriteLine($"Dobavqme purviq masiv: {string.Join(" " , numbers)}");
        }

        private static void PrintCount(List<int> numbers)
        {
            Console.WriteLine($"Broq na elementite na spisuka sa: {numbers.Count}");
        }
    }
}
