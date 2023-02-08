using System;
using System.Text;

namespace LeetCode.LongestCommonPrefix;

public static class LongestCommonPrefix
{
    public static String Solution(String[] inputs)
    {
        var result = new StringBuilder();

        var shortestWord = inputs.Min(e => e.Length);

        for (int i = 0; i < shortestWord; i++)
        {
            var equal = true;
            var letter = inputs[0][i];

            for (int j = 0; j < inputs.Length; j++)
            {
                if (inputs[j][i] != letter)
                {
                    equal = false;
                    return result.ToString();
                }
            }

            if (equal) { result.Append(inputs[0][i]); }
        }

        return result.ToString();
    }
}

