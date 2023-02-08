using System;
namespace LeetCode.LengthOfLastWord
{
    public static class LengthOfLastWord
    {
        public static Int32 Length(String input)
        {
            return input.Trim().Split().LastOrDefault().Length;
        }
    }
}

