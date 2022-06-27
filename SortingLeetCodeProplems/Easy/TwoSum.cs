using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLeetCodeProplems.Easy
{
    internal class TwoSum
    {
        public int[] GetTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            var index = 0;
            foreach (int num in nums)
            {
                if (dic.ContainsKey(target - num))
                    return new int[2] { dic[target - num], index };
                if (!dic.ContainsKey(num))
                    dic.Add(num, index);
                index++;
            }
            return new int[2];
        }
    }
}
