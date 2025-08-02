public class Solution 
{
    public bool IsValid(string s) 
    {
        Stack<char> chars = new Stack<char>();
        
        foreach(char c in s)
        {
            if(c == '(' || c == '{' || c == '[')
            {
                chars.Push(c);
            } 
            else
            {
                if(chars.Count == 0)
                {
                    return false;
                }
                char top = chars.Pop();
                if((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '[') )
                {
                    return false;
                }
            }            
        }
        if(chars.Count > 0)
        {
            return false;
        }
        return true;
    }
}