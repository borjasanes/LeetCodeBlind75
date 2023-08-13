namespace Blind75.Arrays.Annagrams;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var result = new Dictionary<string, IList<string>>();

        foreach (string str in strs)
        {
            var key = new char[26];
            foreach (char letter in str)
            {
                key[letter - 'a']++;
            }
            var dicKey = new string(key);

            if (result.ContainsKey(dicKey))
            {
                result[dicKey].Add(str);
                continue;
            }
            result[dicKey] = new List<string> { str };
        }
        return result.Values.ToList();
    }
}