using System.Collections;

namespace Blind75.Arrays.ValidAnagram;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var hashTable = new Hashtable();

        for (int i = 0; i < s.Length; i++)
        {
            if (!hashTable.ContainsKey(s[i]))
            {
                hashTable.Add(s[i], 1);
            }
            else
            {
                hashTable[s[i]] = (int)hashTable[s[i]] + 1;
            }

            if (!hashTable.ContainsKey(t[i]))
            {
                hashTable.Add(t[i], -1);
            }
            else
            {
                hashTable[t[i]] = (int)hashTable[t[i]] - 1;
            }
        }

        foreach (var key in hashTable.Keys)
        {
            if ((int)hashTable[key] != 0) return false;
        }
        return true;
    }
}