namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public bool IsValid(string s)
    {
        if (s.Length == 0) return true;
        if (s.Length == 1) return false;
        
        Stack<char> parentheses = new Stack<char> ();
        
        for (int i = 0; i < s.Length; i++)
        {
            // if char is openeing, push to stack and continue
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                parentheses.Push(s[i]);
                continue;
            }
            // if char is closing and and peek has corresponding opening, pop from stack and continue
            if (s[i] == ')')
            {
                if (parentheses.Count() == 0) return false;
                if (parentheses.Peek() == '(')
                {
                    parentheses.Pop();
                    continue;                    
                }
                // if char is closing and and peek doesn't have corresponding opening, return false
                else return false;
            }
            if (s[i] == ']')
            {
                if (parentheses.Count() == 0) return false;
                if (parentheses.Peek() == '[')
                {
                    parentheses.Pop();
                    continue;                    
                }
                else return false;
            }
            if (s[i] == '}')
            {
                if (parentheses.Count() == 0) return false;
                if (parentheses.Peek() == '{')
                {
                    parentheses.Pop();
                    continue;                    
                }
                else return false;
            }
        }
        // after iterating, if stack.count != 0 return false
        if (parentheses.Count() != 0) return false;

        // return true
        return true;
    }

}
