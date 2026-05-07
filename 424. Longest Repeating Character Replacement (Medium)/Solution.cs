namespace Solution;

class Program
{
    static int CharacterReplacement(string s, int k)
    {
        int max = 0;
        for (int left = 0; left < s.Length; left++)
        {
            int replacements = k;
            int count = 0;
            for (int right = left; right < s.Length; right++)
            {
                if (s[left] == s[right])
                {
                    count++;
                    max = Math.Max(max, right - left + 1);
                }
                else if (replacements > 0)
                {
                    count++;
                    replacements--;
                    max = Math.Max(max, right - left + 1);
                }
                else
                {
                    break;
                }
            }
        }
        return max;
    }
}