using System;
using LeetCode.Extensions;

namespace LeetCode.ReverseVowelsOfAString
{
    public static class ReverseVowels
    {
        public static String Reverse(String input)
        {
            var reversedVowels = new List<(Char vowel, Int32 index)>();

            var vowels = new Char[] { 'a', 'e', 'i', 'o', 'u' };

            foreach (var i in 0..(input.Length - 1))
            {
                if (vowels.Contains(input[i]))
                {
                    reversedVowels.Add((input[i], i));
                }
            }

            var result = input.ToCharArray();

            foreach (Int32 i in 0..(reversedVowels.Count - 1))
            {
                var index = reversedVowels[reversedVowels.Count - 1 - i].index;

                result[index] = reversedVowels[i].vowel;
            }

            return new String(result);
        }
    }
}

