namespace _3._Longest_Substring__No_Repeating_Chars__Medium_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    static int LenghtOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;
        if (s.Length == 1) return 1;

        int maxLength = 0;
        int start = 0;
        int length = 1;
        

        while ((start + length) < s.Length)
        {
            string substring = s.Substring(start, length);
            if (IsUnique(substring))
            {
                maxLength = Math.Max(maxLength, substring.Length);
                length++;
            }
            else
            {
                start++;
            }
        }

        string finalSubstring = s.Substring(start, length);
        if (IsUnique(finalSubstring))
        {
            maxLength = Math.Max(maxLength, finalSubstring.Length);
        }

        return maxLength;
    }

    static bool IsUnique(string s)
    {
        HashSet<char> seen = new HashSet<char>();
        foreach (char c in s)
        {
            seen.Add(c);
        }
        return s.Length == seen.Count;
    }
}

