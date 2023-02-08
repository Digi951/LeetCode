using System;

namespace LeetCode.RemoveDuplicatesFromSortedArray;

public static class RemoveDuplicates
{
    public static Int32 Solution(Int32?[] nums)
    {
        if (nums is null || nums.Length == 0) { return 0; }

        Int32? lastNumber = nums[0];
        Int32 lastRegularIndex = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == lastNumber)
            {
                nums[i] = null;
            }
            else if (nums[i] != lastNumber)
            {
                lastNumber = nums[i];
                nums[lastRegularIndex + 1] = nums[i];
                lastRegularIndex++;
                nums[i] = null;
            }
        }

        return lastRegularIndex + 1;
    }
}

