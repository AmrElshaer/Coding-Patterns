using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSolving._75_Blind_leetcode_questions
{
    internal class ContainsDuplicate
    {
        public bool ContainDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }
                set.Add(nums[i]);
            }
            return false;
        }
    }
}
