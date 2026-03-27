namespace _125._Valid_Palindrome__Easy_;

public class Solution {
    public bool IsPalindrome(string s) {
        // check up until the middle or just before for odd lengths- (length / 2) - 1
        // 0th element compared to last, all others compared to negative of same index
        // use .ToLower() to account for case-insensitivity
        // for alphnumeric only, can use IsLetter(char) or IsDigit(char)

        // tests 
        // a//aaa


        string lower_case_s = s.ToLower();
        string new_s = "";
        for (int i = 0; i < lower_case_s.Length; i++){
            if (Char.IsLetter(lower_case_s[i]) || Char.IsDigit(lower_case_s[i])){
                string letter = lower_case_s[i].ToString();
                new_s += letter;
            }
        }
        
        if (new_s.Length == 0) return true;

        int stopping_point = (new_s.Length / 2) - 1;
        for (int i = 0; i <= stopping_point; i++){
            if (new_s[i] != new_s[^(i + 1)]){
                return false;
            }
        }

        return true;
    }
}
