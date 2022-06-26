using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLeetCodeProplems.Easy
{
    // Link : https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/

    internal class HowManyNumbersAreSmallerThanTheCurrentNumber
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var intArray = nums.ToList();
            intArray.Sort();

            var result = new int[intArray.Count];

            for (int i = 0; i < intArray.Count; i++)
            {
                if (i > 0 && intArray[i] == intArray[i - 1])
                    result[i] = result[i - 1];
                else
                    result[i] = i;
            }

            return result;
        }
    }
}
