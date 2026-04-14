public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
      Dictionary<string, List<string>> keyVal = new ();

      for(int i=0; i< strs.Length; i++)
      {
        var charaters = strs[i].ToCharArray();
        Array.Sort(charaters);
        var key = new string(charaters);

        if(!keyVal.ContainsKey(key))
        {
            keyVal[key] = new List<string>();
        }
        keyVal[key].Add(strs[i]);
      }   

      return keyVal.Values.Cast<List<string>>().ToList();
    }
}
