using System;
using System.Collections.Generic;

namespace LeetCode.RomanToInteger;

public static class RomanToInteger
{
    public static int RomanToInt(String input)
    {
        var romanNumbers = new Dictionary<Char, Int32>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        Int32 number = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (i + 1 < input.Length && romanNumbers[input[i + 1]] > romanNumbers[input[i]])
            {
                number -= romanNumbers[input[i]];
            }
            else
            {
                number += romanNumbers[input[i]];
            }
        }

        return number;
    }
}

