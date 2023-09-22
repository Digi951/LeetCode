namespace LeetCode._0016_3Sum_Closest;

public class ThreeSumClosest
{
    public static Int32 FindClosestSum(Int32[] nums, Int32 target)
    {
        Array.Sort(nums);
        Int32 closestSum = Int32.MaxValue;

        for (Int32 i = 0; i < nums.Length - 2; i++)
        {
            Int32 left = i + 1;
            Int32 right = nums.Length - 1;

            while (left < right)
            {
                Int32 tempSum = nums[i] + nums[left] + nums[right];

                if (tempSum == target)
                {
                    return tempSum;
                }

                if (Math.Abs(target - tempSum) < Math.Abs(target - closestSum))
                {
                    closestSum = tempSum;
                }

                if (tempSum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
        
        return closestSum;
    }
}