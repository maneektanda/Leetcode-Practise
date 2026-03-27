namespace _242._Valid_Anagram__Easy_;

class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> frequencies = new Dictionary<char, int>();
        foreach (char letter in s){
            if (!frequencies.ContainsKey(letter)){
                frequencies.Add(letter, 1);
            }
            else
            {
                frequencies[letter]++;
            }
        }
        foreach (char letter in t)
        {
            if (!frequencies.ContainsKey(letter)) return false;
            else
            {
                frequencies[letter]--;
            }
        }
        foreach (KeyValuePair<char, int> letter in frequencies)
        {
            if (letter.Value != 0) return false;
        }
        return true;
    }
}