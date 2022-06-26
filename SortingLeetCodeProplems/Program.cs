using SortingLeetCodeProplems.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLeetCodeProplems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Console.WriteLine("Insert Input");

            var obj = new HowManyNumbersAreSmallerThanTheCurrentNumber();
            var result = obj.SmallerNumbersThanCurrent(ReadIntArray());
            Console.WriteLine("result: " + WriteIntArray(result));

            Console.ReadLine();
        }

        private static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int[] ReadIntArray()
        {
            var data = Console.ReadLine();
            var dataList = data.Split(',').ToList().Select(x => Convert.ToInt32(x)).ToList();
            return dataList.ToArray();
        }

        private static string WriteIntArray(int[] result)
        {
           return string.Join(",", result);
        }
    }
}
