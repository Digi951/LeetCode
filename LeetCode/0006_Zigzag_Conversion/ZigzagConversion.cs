using System.Text;

namespace LeetCode.Zigzag_Conversion;

public static class ZigzagConversion
{
    public static String Convert(String input, Int32 numRows)
    {
        if (numRows == 1 || numRows >= input.Length) 
        {
            return input;
        }

        StringBuilder[] rows = new StringBuilder[numRows];
        for (Int32 i = 0; i < numRows; i++) 
        {
            rows[i] = new StringBuilder();
        }

        Int32 currentRow = 0;
        Boolean goingDown = false;

        foreach (Char c in input) {
            rows[currentRow].Append(c);
            if (currentRow == 0 || currentRow == numRows - 1) 
            {
                goingDown = !goingDown;
            }
            currentRow += goingDown ? 1 : -1;
        }

        StringBuilder result = new StringBuilder();
        foreach (StringBuilder row in rows) 
        {
            result.Append(row);
        }

        return result.ToString();
    }
}