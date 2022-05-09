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

            var num1String = intArray[0].ToString() + intArray[2].ToString();
            var num2String = intArray[1].ToString() + intArray[3].ToString();

            return Convert.ToInt32(num1String) + Convert.ToInt32(num2String);
        }
    }
}
