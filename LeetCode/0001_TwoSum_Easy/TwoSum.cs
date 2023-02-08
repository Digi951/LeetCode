using System.Collections;

namespace LeetCode.TwoSum;

public static class TwoSum
{
    public static Int32[] Solution(int[] nums, int target)
    {
        var numberMap = new Dictionary<Int32, Int32>();

        for (int i = 0; i < nums.Length; i++)
        {
            Int32 complement = target - nums[i];

            if (numberMap.ContainsKey(complement))
            {
                return new int[] { (Int32)numberMap[complement], i };
            }
            if (!numberMap.ContainsKey(nums[i]))
            {
                numberMap.Add(nums[i], i);

            }
        }

        throw new ArgumentException();
        
    }
}

