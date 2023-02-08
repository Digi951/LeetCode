using System;
namespace LeetCode.Sqrt;

public static class Sqrt
{
    public static Int32 Calc(Int32 input)
    {
        Int32 result = 0;
        Int32 index = -1;

        while(result < input)
        {
            index++;

            var tempResult = index * index;

            if (tempResult <= input)
            {
                result = tempResult;
            }
            else
            {
                index--;
                break;
            }
        }

        return index;
    }
}

