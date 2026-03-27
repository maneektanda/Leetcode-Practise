namespace _49._Group_Anagrams__Medium_;

class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
        int[] letters = new int[26];
        for (int i = 0; i < strs.Length; i++)
        {
            Array.Fill(letters, 0);
            for (int j = 0; j < strs[i].Length; j++)
            {
                letters[strs[i][j] - 'a']++;    
            }
            string key = "";
            foreach (int letter in letters)
            {
                key += letter + " ";
            }
            if (anagrams.ContainsKey(key))
            {
                anagrams[key].Add(strs[i]);
            }
            else
            {
                anagrams.Add(key, new List<string> {strs[i]});
            }
        }
        List<List<string>> result = new List<List<string>>();
        foreach (KeyValuePair<string, List<string>> anagram in anagrams)
        {
            result.Add(anagram.Value);
        }
        return result;
    }
}