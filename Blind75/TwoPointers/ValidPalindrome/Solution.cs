using System.Text;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in s.ToLower())
        {
            if (Char.IsNumber(c) || c >= 97 && c <= 122)
            {
                sb.Append(c);
            }
        }

        if (sb.Length == 0) return true;

        string cleanedString = sb.ToString();

        var i = 0;
        var j = cleanedString.Length - 1;

        while (i < j)
        {
            if (cleanedString[i] != cleanedString[j]) return false;

            i++;
            j--;
        }
        return true;
    }
}