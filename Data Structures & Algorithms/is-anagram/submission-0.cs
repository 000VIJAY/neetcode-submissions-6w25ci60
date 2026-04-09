public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int[] asc = new int[26];

        for(int i=0; i< s.Length; i++)
        {
            asc[s[i] - 'a']++;
            asc[t[i] - 'a']--;
        }

        for(int i=0; i< asc.Length; i++)
        {
            if(asc[i]!=0) return false;
        }
        return true;
    }
}
