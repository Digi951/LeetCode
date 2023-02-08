using System;
namespace LeetCode.SearchInsertPosition;

public static class SearchInsertPosition
{
    public static Int32 SearchInsert(Int32[] nums, Int32 target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= target) { return i; }
        }

        return nums.Length;
    }
}

