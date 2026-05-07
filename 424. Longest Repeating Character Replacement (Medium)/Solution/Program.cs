namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    static int CharacterReplacement(string s, int k)
    {
        if (s.Length == 0) return 0;
        if (s.Length == 1) return 1;

        int left = 0;
        int right = 1;
        int counter = k;
        int max_length = 0;

        while ((left + (right - left)) < s.Length)
        {
            if (s[left] == s[right])
            {
                max_length = Math.Max(max_length, right - left);
                right++;
                continue;
            }
            else if (counter > 0)
            {
                counter--;
                max_length = Math.Max(max_length, right - left);
                right++;
                continue;
            }
            else
            {
                left++;
                right = left + 1;
                counter = k;
            }
        }
        return max_length;
    }
}
