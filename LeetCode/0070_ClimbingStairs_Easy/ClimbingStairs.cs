using System;
using LeetCode.Extensions;

namespace LeetCode.ClimbingStairs;

public static class ClimbingStairs
{
    public static Int32 ClimbStairs(Int32 number)
    {
        if (number >= 1 && number <= 3)
        {
            return number;
        }

        var firstNumber = 0;
        var secondNumber = 1;
        var result = 0;

        foreach (var i in 0..(number - 1))
        {
            result = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = result;
        }

        return result;
    }
}

