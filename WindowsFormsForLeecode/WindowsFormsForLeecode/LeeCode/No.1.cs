using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsForLeecode.LeeCode
{
    class No1
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                List<int> resultList = new List<int>();
                if (nums.Length > 0)
                {
                    int len = nums.Length;
                    for (int i = 0; i < len - 1; i++)
                    {
                        for (int j = (i + 1); j < len; j++)
                        {
                            if (nums[i] + nums[j] == target)
                            {
                                resultList.Add(i);
                                resultList.Add(j);
                                break;
                            }
                        }
                    }
                }

                return resultList.ToArray();
            }
        }
    }
}
