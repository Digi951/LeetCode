using System;
namespace LeetCode.PlusOne;

public static class PlusOne
{
    public static Int32[] Solve(Int32[] digits)
    {
        Int32 number = 0;
        Double invertedIndex = digits.Length - 1;

        for (int i = 0; i < digits.Length; i++)
        {
            number += digits[i] * (Int32)Math.Pow(10, invertedIndex);
            invertedIndex--;
        }

        number++;

        var digitsOfNumber = number.ToString().Length;
        var result = new Int32[digitsOfNumber];

        for (int i = digitsOfNumber - 1; i >= 0; i--)
        {
            result[i] = number % 10;
            number /= 10;
        }

        return result;
        
    }
}

