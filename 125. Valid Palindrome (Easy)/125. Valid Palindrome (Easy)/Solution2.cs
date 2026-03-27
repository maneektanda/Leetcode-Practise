namespace _125._Valid_Palindrome__Easy_;

public class Solution2 {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while ((left < right) && !Char.IsLetter(s[left]) && !Char.IsDigit(s[left]))
            {
                left++;
            }
            while ((left < right) && !Char.IsLetter(s[right]) && !Char.IsDigit(s[right]))
            {
                right--;
            }
            if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}