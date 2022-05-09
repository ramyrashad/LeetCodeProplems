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

            var obj = new MinimumSumOfFourDigitNumberAfterSplittingDigits();
            var result = obj.MinimumSum(ReadInt());
            Console.WriteLine("result: " + result);

            Console.ReadLine();
        }

        private static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
