using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
        
            List<string> months = new List<string>() { "January" , "February" };
            List<string> spring = new List<string>() {"March", "April", "May" };
            List<string> summer = new List<string>() { "June", "July", "August" };
            List<string> autumn = new List<string>() { "September", "October", "November" };
            months.AddRange(spring);
            months.AddRange(summer);
            months.AddRange(autumn);
            months.Add("December");
         
            Console.WriteLine("\n*********Original version*********");
            PrintList(months);
            ShuffleList(months);
            Console.WriteLine("\n*********Shuffle version**********");
            PrintList(months);
            Console.WriteLine("\n");

            List<int> numbers =RandomNumbers(10);
            Console.WriteLine("\n*********Original version*********");
            PrintList(numbers);
            ShuffleList(numbers);
            Console.WriteLine("\n*********Shuffle version**********");
            PrintList(numbers);

            Console.ReadLine();
        }

   
      static void PrintList(List<int> numList)
        {
            foreach(int item in numList)
            {
                Console.Write(item+" ");
            }
        }

      static void PrintList(List <string> strList)
        {
            foreach(string el in strList)
            {
                Console.Write(el+" ");
            }
        }

      static void ShuffleList(List<string> list)
        {
            Random rnd = new Random();
            int n = list.Count;
            for (int i = 0; i < n; i++)
            {
                Swap(list, rnd.Next(0,n), rnd.Next(n - i));
            }
        }

      static void ShuffleList(List<int> numbers)
        {
            Random rnd = new Random();
            for (int i = 0; i < numbers.Count; i++)
            {
                Swap(numbers, rnd.Next(0, numbers.Count), rnd.Next(numbers.Count - i));
            }
        }

      static List<int> RandomNumbers(int n)
        {
            Random rnd = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                numbers.Add(rnd.Next(0, 101));

            }
            return numbers;
        }

      static void Swap(List<string> list, int index1, int index2)
        {
            string temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

      static void Swap(List <int> list, int index1, int index2)
        {
            int temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }


    }
}
