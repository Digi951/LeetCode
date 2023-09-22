using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using LeetCode.Extensions;

namespace LeetCode.LongestSubstringWithoutRepeatingCharacters;

public static class LongestSubstringWithoutRepeatingCharacters
{
    public static Int32 LongestSubstring(String input)
    {
        HashSet<Char> longestSubstring = new();
        Int32 left = 0;
        Int32 right = 0;
        Int32 maxLength = 0;

        while (right < input.Length)
        {
            if (!longestSubstring.Contains(input[right]))
            {
                longestSubstring.Add(input[right]);
                maxLength = longestSubstring.Count > maxLength ? longestSubstring.Count: maxLength;
                right++;
            }
            else
            {
                longestSubstring.Remove(input[left]);
                left++;
            }
        }
        

        return maxLength;
    }
}

