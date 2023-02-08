using System;
namespace LeetCode.RemoveElement_Easy;

public static class RemoveElement
{
    public static Int32 Remove(Int32?[] nums, Int32 value)
    {
        if (nums is null || nums.Length == 0) { return 0; }

        Int32 lastRegularIndex = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == value)
            {
                nums[i] = null;
                continue;
            }

            if (nums[i] != value && lastRegularIndex < i)
            {
                nums[lastRegularIndex + 1] = nums[i];
                nums[i] = null;
                lastRegularIndex++;
                continue;
            }

            lastRegularIndex++;
        }

        return lastRegularIndex++;
    }
}

