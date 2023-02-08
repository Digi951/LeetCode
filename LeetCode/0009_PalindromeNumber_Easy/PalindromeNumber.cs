namespace LeetCode.PalindromeNumber
{
    // It is not allowed to convert the number to a String
    public static class PalindromeNumber
    {
        public static Boolean IsPalindrome(int number)
        {
            if (number < 0) { return false; }

            int input = number;
            int reversed = 0;

            while (input != 0)
            {
                reversed = reversed * 10 + input % 10;
                input /= 10;
            }

            return number == reversed;
        }
    }
}

