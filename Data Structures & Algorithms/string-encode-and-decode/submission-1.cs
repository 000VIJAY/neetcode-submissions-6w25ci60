public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder encoded = new StringBuilder();
        for(int i =0; i< strs.Count; i++)
        {
            encoded.Append(strs[i].Length);
            encoded.Append('#');
            encoded.Append(strs[i]);
        }

        return encoded.ToString();
    }

    public List<string> Decode(string s) {
        List<string> strs = new();

        int i=0;
        while(i<s.Length)
        {
            var hashIndex = s.IndexOf('#',i);
            int wordLength =  int.Parse(s.Substring(i, hashIndex-i));

            int wordSize = hashIndex+1;

            string word = s.Substring(wordSize,wordLength);

            i = wordSize + wordLength;

            strs.Add(word);
        }
        return strs;

   }
}
