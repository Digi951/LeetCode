namespace LeetCode.ReverseInteger_Medium;

public static class ReverseInteger
{
    public static int Reverse(Int32 input)
    {
        String parsedInput = input.ToString();
        Char[]? reversedArray;
        String result = String.Empty;
        
        if (input < 0)
        {
            parsedInput = parsedInput.Remove(0,1);
            reversedArray = parsedInput.ToCharArray();
            Array.Reverse(reversedArray);  
            result = "-" + new String(reversedArray);
        }
        else
        {
            reversedArray = parsedInput.ToCharArray();
            Array.Reverse(reversedArray); 
            result = new String(reversedArray);
        }
        
        int.TryParse(result, out int converted);
        
        return converted;
    }
}