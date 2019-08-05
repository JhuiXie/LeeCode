using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCodeLibrary
{
    class No20
    {
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
