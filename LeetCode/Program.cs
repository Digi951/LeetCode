using LeetCode.LongestPalindromicSubstring_Medium;
using LeetCode.Zigzag_Conversion;
using LeetCode.ReverseInteger_Medium;
using LeetCode.ThreeSum_Medium;
using LeetCode.ThreeSum_Closest;
using LeetCode.Extensions;
using LeetCode.ValidParentheses;
using LeetCode.LongestCommonPrefix;
using LeetCode.PalindromeNumber;
using LeetCode.RomanToInteger;
using LeetCode.TwoSum;
using LeetCode.RemoveDuplicatesFromSortedArray;
using LeetCode.RemoveElement_Easy;
using LeetCode.SearchInsertPosition;
using LeetCode.LengthOfLastWord;
using LeetCode.PlusOne;
using LeetCode.Sqrt;
using LeetCode.ClimbingStairs;
using LeetCode.ReverseVowelsOfAString;
using LeetCode.LongestPalindromeByConcatenating;
using LeetCode.LongestSubstringWithoutRepeatingCharacters;
using LeetCode.ContainerWithMostWater_Medium;



// 01 Two Sum
//int[] numbers = { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
//var result = TwoSum.Solution(numbers, 11);

// 03 Longst Substring without repeating characters
// var input = "abcabcbb";
// var result = LongestSubstringWithoutRepeatingCharacters.LongestSubstring(input);

// 05 Longest Palindromic Substring
// var input = "cbbd";
//var result = LongestPalindromicSubstring.LongestPalindrome(input);

// 06 ZigzagConversion
// var input = "PAYPALISHIRING";
// var result = ZigzagConversion.Convert(input, 3);

// 07 Reverse Integer
//var input = 1534236;
//var result = ReverseInteger.Reverse(input);

// 09 Palindrome Number
//Console.WriteLine(PalindromeNumber.IsPalindrome(121));

// 11 ContainerWithMostWater
var input = new Int32[]{1, 8, 6, 2, 5, 4, 8, 3, 7};
// var input = new Int32[]{1, 2, 1};
var result = ContainerWithMostWater.MaxArea(input);

// 13 Roman To Integer
//RomanToInteger.RomanToInt("MCMXCIV");

// 14 Longest Common Prefix
//var strings = new String[] { "flower", "flow", "flight" };
//var result = LongestCommonPrefix.Solution(strings);

// 15 Three Sum
// int[] numbers = {-1,0,1,2,-1,-4};
// var result = ThreeSum.FindCombinations(numbers);

// 16 Three Sum Closest
// int[] numbers = { -1, 2, 1, -4 };
//int[] numbers = { 4, 0, 5, -5, 3, 3, 0, -4, -5 };
//int target = -2;
//var result = ThreeSumClosest.FindClosestSum(numbers, target);

// 20 Valid Parentheses
//var result = ValidParentheses.IsValid("{[()][()]}");

// 21 Merge Two Sorted Lists


// 26 Remove duplicates from sorted array
//var nums = new Int32?[] { 0, 0, 1, 1, 1, 2, 3 };
//var result = RemoveDuplicates.Solution(nums);

// 27 Remove Element
//var nums = new Int32?[] { 3, 1, 2, 2, 3, 0, 4, 3 };
//var result = RemoveElement.Remove(nums, 3);

// 35 Search Insert Position
//var nums = new Int32[] { 1, 2, 3, 5, 6, 7, 8 };
//var result = SearchInsertPosition.SearchInsert(nums, 3);

// 58 Length of last word
//var result = LengthOfLastWord.Length("luffy is still joyboy ");

// 66 Plus One
//var digits = new Int32[] { 9, 9, 9, 9 };
//var result = PlusOne.Solve(digits);

// 69 Sqrt
//var result = Sqrt.Calc(63);

// 70 Climbing Stairs
//var result = ClimbingStairs.ClimbStairs(6);

// 345 Reverse Vowels of a String
//var input = "Hello World";
//var result = ReverseVowels.Reverse(input);

// 2131 Longest Palindrome
//var words = new String[] { "lc", "cl", "gg" };
//var result = LongestPalindrome.Calc(words);
//Console.WriteLine(result);

//words = new String[] { "ab", "ty", "yt", "lc", "cl", "ab" };
//result = LongestPalindrome.Calc(words);
//Console.WriteLine(result);

//words = new String[] { "cc", "cc", "xx", "ta" };
//result = LongestPalindrome.Calc(words);
//Console.WriteLine(result);

Console.ReadKey();