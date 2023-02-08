using System;
using System.Text;
using LeetCode.Extensions;

namespace LeetCode.LongestSubstringWithoutRepeatingCharacters;

public static class LongestSubstringWithoutRepeatingCharacters
{
    public static Int32 LongestSubstring(String input)
    {
        String tempSubstring = String.Empty;
        Int32 longestSubstring = 0;

        foreach (var i in 0..(input.Count() - 1))
        {
            if (!tempSubstring.Contains(input[i]))
            {
                tempSubstring = new string(tempSubstring + input[i]);
            }
            else
            {
                if (tempSubstring.Length > longestSubstring) { longestSubstring = tempSubstring.Length; }
                tempSubstring = input[i].ToString();
            }
        }

        return longestSubstring;
    }
}

