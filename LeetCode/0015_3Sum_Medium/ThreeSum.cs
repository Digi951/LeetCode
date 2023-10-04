using System.Collections;
using System.Collections.Immutable;

namespace LeetCode.ThreeSum_Medium;

public static class ThreeSum
{
    public static IList<IList<int>> FindCombinations(Int32[] nums)
    {
        Array.Sort(nums);
        List<IList<Int32>> combinations = new List<IList<Int32>>();
    
        for (Int32 i = 0; i < nums.Length - 2; i++)
        {
            if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
            {
                Int32 left = i + 1;
                Int32 right = nums.Length - 1;

                while (left < right)
                {
                    Int32 sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        combinations.Add(new List<Int32> { nums[i], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }

        return combinations;
    }
}