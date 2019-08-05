using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    class No1
    {
        //给定一个整数数组 nums和一个目标值 target，请你在该数组中找出和为目标值的那 两个整数，并返回他们的数组下标。
        //你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。

        //示例:
        //给定 nums = [2, 7, 11, 15], target = 9
        //因为 nums[0] + nums[1] = 2 + 7 = 9
        //所以返回[0, 1]

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/two-sum
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
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
