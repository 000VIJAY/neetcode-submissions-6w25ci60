public class Solution {
    public bool IsValid(string s) {
        
        if(s.Length < 2) return false;
        Stack<char> openingBrackets = new ();

        for(int i =0; i< s.Length; i++)
        {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                openingBrackets.Push(s[i]);
                continue;
            }

            if(s[i]== ')' || s[i]==']' || s[i] == '}')
            {
                if(openingBrackets.Count <1) return false;
                char poppedOB = openingBrackets.Pop();

                if( (poppedOB == '{' && s[i]== '}') ||
                    (poppedOB == '[' && s[i]== ']') ||
                    (poppedOB == '(' && s[i]== ')'))
                    {
                        continue;
                    }else{
                        return false;
                    }
            }
        }

        if(openingBrackets.Count > 0)
        {
            return false;
        }

        return true;
    }
}
