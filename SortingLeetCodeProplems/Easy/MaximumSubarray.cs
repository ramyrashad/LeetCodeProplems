using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLeetCodeProplems.Easy
{
    internal class MaximumSubarray
    {
        public int GetSumOfMaximumSubarray(int[] nums)
        {
            if(nums.Length == 0)
                return 0;
            var maximumSum = nums[0];
            var currentSum = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                currentSum = currentSum + nums[i];

                currentSum = Math.Max(nums[i], currentSum);
                maximumSum = Math.Max(maximumSum, currentSum);

            }

            return maximumSum;
        }
    }
}
