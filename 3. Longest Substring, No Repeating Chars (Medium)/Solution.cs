namespace _3._Longest_Substring__No_Repeating_Chars__Medium_;

class Solution
{
    public static int LengthOfLongestSubstring(string s)
    {
        HashSet<char> chars = new HashSet<char>();

        int left = 0;
        int max = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (chars.Contains(s[right]))
            {
                chars.Remove(s[left]);
                left++;
            }
            chars.Add(s[right]);
            max = Math.Max(max, right - left + 1);
        }
        return max;
    }
}