using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLeetCodeProplems.Easy
{
    internal class ContainsDuplicate
    {
        public bool IsContainsDuplicate(int[] nums)
        {
            var result = false;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (dic.ContainsKey(num))
                    return true;
                dic.Add(num, num);
            }

            return result;
        }
    }
}
