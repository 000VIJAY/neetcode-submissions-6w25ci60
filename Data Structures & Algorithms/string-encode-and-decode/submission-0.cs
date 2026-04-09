public class Solution {

    public string Encode(IList<string> strs) {
        
        StringBuilder sb = new ();

        for(int i=0; i< strs.Count; i++)
        {
            sb.Append(strs[i].Length);
            sb.Append('#');
            sb.Append(strs[i]);
        }
        
        return sb.ToString();
        
    }

    public List<string> Decode(string s) {
        List<string> strs = new ();

        int i=0;
        while(i< s.Length)
        {
            var hashIndex = s.IndexOf('#',i);
            int wordLength = int.Parse(s.Substring(i, hashIndex - i));

            int wordStartIndex = hashIndex + 1;
            string word = s.Substring(wordStartIndex, wordLength);

            strs.Add(word);

            i = wordStartIndex + wordLength;
        }

        return strs;
 
   }
}
