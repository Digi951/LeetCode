using System.Reflection.Metadata.Ecma335;

namespace LeetCode.LongestPalindromicSubstring_Medium;

public static class LongestPalindromicSubstring
{
    public static string LongestPalindrome(string input)
    {
        int left = 0;
        int right = 0;
    
        string longestPalindrome = input[0].ToString();

        for (int i = 0; i < input.Length; i++)
        {
            // Odd length palindrome
            left = i;
            right = i;
            string oddPalindrome = ExpandAroundCenter(input, left, right);
        
            // Even length palindrome
            left = i;
            right = i + 1;
            string evenPalindrome = ExpandAroundCenter(input, left, right);

            if (oddPalindrome.Length > longestPalindrome.Length)
            {
                longestPalindrome = oddPalindrome;
            }

            if (evenPalindrome.Length > longestPalindrome.Length)
            {
                longestPalindrome = evenPalindrome;
            }
        }

        return longestPalindrome;
    }

    private static string ExpandAroundCenter(string input, int left, int right)
    {
        while (left >= 0 && right < input.Length && input[left] == input[right])
        {
            left--;
            right++;
        }

        return input.Substring(left + 1, right - left - 1);
    }

}