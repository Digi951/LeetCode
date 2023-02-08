using System;
namespace LeetCode.ValidParentheses;

public static class ValidParentheses
{
    public static Boolean IsValid(String inputs)
    {
        var parentheses = new Stack<Char>();

        foreach (var input in inputs)
        {
            if (parentheses.Count > 0)
            {
                if (parentheses.First() == '(' && input == ')'
                || parentheses.First() == '[' && input == ']'
                || parentheses.First() == '{' && input == '}')
                {
                    parentheses.Pop();
                    continue;
                }
            }
            
            parentheses.Push(input);
        }

        return parentheses.Count == 0;
    }
}
