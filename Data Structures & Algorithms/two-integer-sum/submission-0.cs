public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> keyVal = new ();

        for(int i=0; i< nums.Length; i++)
        {
            int req = target- nums[i];

           if(keyVal.TryGetValue(req, out var value))
           {
                return [value, i]; 
           }
            
            keyVal[nums[i]] = i;
        }
        
        return Array.Empty<int>();

    }
}
