using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeLibrary.LeetCodeLibrary
{
    //设计一个支持 push，pop，top 操作，并能在常数时间内检索到最小元素的栈。

    //push(x)-- 将元素 x 推入栈中。
    //pop()-- 删除栈顶的元素。
    //top()-- 获取栈顶元素。
    //getMin() -- 检索栈中的最小元素。
    //示例:

    //MinStack minStack = new MinStack();
    //    minStack.push(-2);
    //minStack.push(0);
    //minStack.push(-3);
    //minStack.getMin();   --> 返回 -3.
    //minStack.pop();
    //minStack.top();      --> 返回 0.
    //minStack.getMin();   --> 返回 -2.

    //来源：力扣（LeetCode）
    //链接：https://leetcode-cn.com/problems/min-stack
    //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class No155
    {
        public class MinStack
        {
            /// <summary>
            /// 内部栈
            /// </summary>
            private List<int> minStack;
            public MinStack()
            {
                minStack = new List<int>();
            }

            public void Push(int x)
            {
                minStack.Add(x);
            }

            public void Pop()
            {
                if (minStack.Count > 0)
                {
                    minStack.RemoveAt(minStack.Count - 1);
                }
            }

            public int Top()
            {
                return minStack.Last();
            }

            public int GetMin()
            {
                return minStack.Min();
            }
        }

        /**
         * Your MinStack object will be instantiated and called as such:
         * MinStack obj = new MinStack();
         * obj.Push(x);
         * obj.Pop();
         * int param_3 = obj.Top();
         * int param_4 = obj.GetMin();
         */
    }
}
