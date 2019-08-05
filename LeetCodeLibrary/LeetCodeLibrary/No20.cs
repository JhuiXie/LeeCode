using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    class No20
    {
        //给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。

        //有效字符串需满足：

        //左括号必须用相同类型的右括号闭合。
        //左括号必须以正确的顺序闭合。
        //注意空字符串可被认为是有效字符串。

        //示例 1:

        //输入: "()"
        //输出: true
        //示例 2:

        //输入: "()[]{}"
        //输出: true
        //示例 3:

        //输入: "(]"
        //输出: false
        //示例 4:

        //输入: "([)]"
        //输出: false
        //示例 5:

        //输入: "{[]}"
        //输出: true

        //来源：力扣（LeetCode）
        //链接：https://leetcode-cn.com/problems/valid-parentheses
        //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public class Solution
        {
            public bool IsValid(string s)
            {
                if (string.IsNullOrEmpty(s))
                {
                    return true;
                }
                //记录上一个字符
                List<string> lastStrList = new List<string>();
                for (int i = 0; i < s.Length; i++)
                {
                    //当前位置字符
                    var tempStr = s.Substring(i, 1);
                    if (lastStrList.Count == 0 || tempStr == "(" || tempStr == "[" || tempStr == "{")
                    {
                        lastStrList.Add(tempStr);
                    }
                    else
                    {
                        switch (tempStr)
                        {
                            case ")":
                                if (CheckString(lastStrList, tempStr, "("))
                                {
                                    continue;
                                }
                                else
                                {
                                    return false;
                                }
                            case "]":
                                if (CheckString(lastStrList, tempStr, "["))
                                {
                                    continue;
                                }
                                else
                                {
                                    return false;
                                }
                            case "}":
                                if (CheckString(lastStrList, tempStr, "{"))
                                {
                                    continue;
                                }
                                else
                                {
                                    return false;
                                }
                            default:
                                return false;
                        }
                    }
                }
                if (lastStrList.Count == 0)
                {
                    return true;
                }
                return false;
            }

            /// <summary>
            /// 检查数组最后一个数和输入的字符串是否成对
            /// </summary>
            /// <param name="lastStrList"></param>
            /// <param name="lastString"></param>
            private bool CheckString(List<string> lastStrList, string lastString, string rightString)
            {
                //如果匹配
                if (lastStrList.Last() == rightString)
                {
                    //移除最后一项
                    lastStrList.RemoveAt(lastStrList.Count - 1);
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
