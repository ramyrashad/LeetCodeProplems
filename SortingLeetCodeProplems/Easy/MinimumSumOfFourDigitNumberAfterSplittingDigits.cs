using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLeetCodeProplems.Easy
{
    // Link : https://leetcode.com/problems/minimum-sum-of-four-digit-number-after-splitting-digits/

    internal class MinimumSumOfFourDigitNumberAfterSplittingDigits
    {
        public int MinimumSum(int num)
        {
            char[] numberArray = num.ToString().ToCharArray();
            var intArray = numberArray.ToList().Select(a => Convert.ToInt32(a.ToString())).ToList();

            intArray.Sort();

            var num1 = intArray[0] * 10 + intArray[2];
            var num2 = intArray[1] * 10 + intArray[3];

            return num1 + num2;
        }
    }
}
