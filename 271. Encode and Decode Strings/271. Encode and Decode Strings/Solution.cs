namespace _271._Encode_and_Decode_Strings;

class Solution
{
    public string Encode(IList<string> strs)
    {
        string encoded_msg = "";
        encoded_msg += strs.Count.ToString().PadLeft(3, '0');
        for (int i = 0; i < strs.Count; i++)
        {
            encoded_msg += strs[i].Length.ToString().PadLeft(3, '0') + strs[i];
        }
        return encoded_msg;
    }

    public List<string> Decode(string s)
    {
        List<string> decoded_msg = new List<string>();
        int words_to_remove = Convert.ToInt32(s.Substring(0, 3));
        int start = 3;

        while (words_to_remove > 0)
        {
            string word = "";
            int word_length = Convert.ToInt32(s.Substring(start, 3));
            word += s.Substring(start + 3, word_length);
            decoded_msg.Add(word);
            start += 3 + word_length;
            words_to_remove--;
        }
        return decoded_msg;
    }
}