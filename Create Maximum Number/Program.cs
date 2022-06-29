using System;
using System.Collections.Generic;

namespace Create_Maximum_Number
{
  class Program
  {
    static void Main(string[] args)
    {
      var nums1 = new int[] { 5, 4, 3, 2, 1, 8};
      Solution s = new Solution();
      var answer = s.MaxArray(nums1, 3);
      Console.WriteLine(string.Join(",", answer));
    }
  }

  public class Solution
  {
    public int[] MaxArray(int[] nums, int len)
    {
      Stack<int> stack = new Stack<int>();
      for (int i = 0; i < nums.Length; i++)
      {
        while (stack.Count + nums.Length - i > len && stack.Count > 0 && stack.Peek() < nums[i])
        {
          stack.Pop();
        }
        if (stack.Count < len)
        {
          stack.Push(nums[i]);
        }
      }
      int[] result = new int[len];
      for (int i = len - 1; i >= 0; i--)
      {
        result[i] = stack.Pop();
      }
      return result;
    }
  }
}
