using System;

namespace LeetCode.LongestPalindromeByConcatenating;

public static class LongestPalindrome
{
    public static Int32 Calc(String[] words)
    {
        var container = new List<String>();
        Int32 index  = 0;
        Int32 offset = words.Count() % 2 == 0 ? 0 : 2;

        foreach (var word in words)
        {
            var reverserdWord = new String(word.Reverse().ToArray());

            if (container.Contains(word))
            {
                container.Remove(word);
                index++;
            }
            else
            {
                container.Add(reverserdWord);
            }

        }

        Boolean equal = false;

        foreach (var item in container)
        {
            if (item[0] == item[1])
            {
                equal = true;
            }

            if (equal && container.Count() > 1) { offset++; }
            
        }

        return 2 * 2 * index + offset;
    }
}

